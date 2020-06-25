using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

using WrapperGenerator.Utilities;

namespace WrapperGenerator.UI
{
	public partial class AssemblyBrowser : TreeView
	{
		#region Enums
		internal enum ImageIndices : byte
		{
			Assembly,
			Namespace,
			Class,
			Method
		}
		#endregion

		#region Fields
		private readonly NotifyingCollection<string> assemblies;
		#endregion

		#region Constructors
		public AssemblyBrowser ()
		{
			InitializeComponent ();

			this.assemblies = new NotifyingCollection<string> ();
			this.assemblies.ItemAdded += this.OnAssemblyAdded;

			AppDomain.CurrentDomain.ReflectionOnlyAssemblyResolve += this.OnReflectionOnlyAssemblyResolve;
		}
		#endregion

		#region Properties
		public ICollection<string> Assemblies
		{
			get
			{
				return this.assemblies;
			}
		}
		#endregion

		#region Private Methods
		private void OnAssemblyAdded (object sender, ItemAddedEventArgs<string> e)
		{
			this.AddAssembly (e.Item);
		}

		private Assembly OnReflectionOnlyAssemblyResolve (object sender, ResolveEventArgs args)
		{
			try
			{
				return Assembly.ReflectionOnlyLoad (args.Name);
			}
			catch (FileNotFoundException exception)
			{
				string message = exception.Message;
				message += Environment.NewLine + Environment.NewLine + "Locate file manually?";
				if (MessageBox.Show (message, "File Not Found", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					if (this.openFileDialog.ShowDialog (this) == DialogResult.OK)
					{
						return Assembly.ReflectionOnlyLoadFrom (this.openFileDialog.FileName);
					}
				}
			}
			return null;
		}

		private void AddAssembly (string assemblyPath)
		{
            try
            {
                Assembly assembly = null;
                foreach (Assembly loadedAssembly in AppDomain.CurrentDomain.ReflectionOnlyGetAssemblies())
                {
                    // TODO: Should be comparing AssemblyNames, but how do you get the AssemblyName without loading the assembly?
                    if (Path.GetFileName(loadedAssembly.CodeBase).ToLower() == Path.GetFileName(assemblyPath).ToLower())
                    {
                        assembly = loadedAssembly;
                        break;
                    }
                }

                if (assembly == null)
                {
                    assembly = Assembly.ReflectionOnlyLoadFrom(assemblyPath);
                }
                AssemblyNode assemblyNode = new AssemblyNode(assembly);
                assemblyNode.Expand();
                this.Nodes.Add(assemblyNode);
            }
            catch
            {
                this.assemblies.Remove(assemblyPath);
                throw;
            }
		}
		#endregion
	}
}
