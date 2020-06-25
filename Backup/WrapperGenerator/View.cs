using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

using WrapperGenerator.ObjectModel;

using TD.SandDock;

namespace WrapperGenerator.UI
{
	public partial class View : Form
	{
		#region Constants
		private const string defaultNamespace = "MyNamespace";
		private const string defaultClassName = "MyWrapper";
		#endregion

		#region Fields
		private readonly WrapperClass wrapperClass;
		private readonly Dictionary<Type, DockControl> typeDocuments;
		private readonly List<string> loadedAssemblies;
		#endregion

		#region Constructors
		public View ()
		{
			InitializeComponent ();

			this.wrapperClass = new WrapperClass ();
			this.typeDocuments = new Dictionary<Type, DockControl> ();
			this.loadedAssemblies = new List<string> ();

			this.Size = new Size (1200, 750);

			this.languageToolStripComboBox.SelectedIndex = 0;

			string mscorlib = Environment.ExpandEnvironmentVariables (@"%WinDir%\Microsoft.NET\Framework\v2.0.50727\mscorlib.dll");
            //if (File.Exists (mscorlib))
            //{
            //    this.assemblyBrowser.Assemblies.Add (mscorlib);
            //}
		}
		#endregion

		#region Properties
		private Language SelectedLanguage
		{
			get
			{
				return this.languageToolStripComboBox.SelectedItem.ToString () == "C#" ? Language.CSharp : Language.VBNet;
			}
		}
		#endregion

		#region Private Methods
		private void OnAddAssemblyToolStripButtonClick (object sender, EventArgs e)
		{
			if (this.openFileDialog.ShowDialog (this) == DialogResult.OK)
			{
				this.AddAssemblies (this.openFileDialog.FileNames);
			}
		}

		private void OnGenerateToolStripButtonClick (object sender, EventArgs e)
		{
			if (this.wrapperClass.WrappedTypes.Count > 0)
			{
				this.GenerateWrapper ();
			}
			else
			{
				string message = "At least one type must be wrapped. To add a wrapped type: " + Environment.NewLine + Environment.NewLine;
				message += "1. Add an assembly (Add Assembly ToolBar button)" + Environment.NewLine;
				message += "2. Expand the assembly node and a namespace node to locate a type to be wrapped" + Environment.NewLine;
				message += "3. Double-click a type node to add it to the set of types being wrapped";
				MessageBox.Show (message, "No Types Specified", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void OnAssemblyBrowserDoubleClick (object sender, EventArgs e)
		{
			this.AddType ();
		}

		private void OnAssemblyBrowserKeyDown (object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				this.AddType ();
			}
		}

		private void OnListViewSelectedIndexChanged (object sender, EventArgs e)
		{
			ListView listView = (ListView)sender;
			object[] selectedObjects = new object[listView.SelectedItems.Count];
			for (int i = 0; i < listView.SelectedItems.Count; i++)
			{
				selectedObjects[i] = listView.SelectedItems[i].Tag;
			}
			this.propertyGrid.SelectedObjects = selectedObjects;
		}

		private void OnDockControlSizeChanged (object sender, EventArgs e)
		{
			DockControl dockControl = (DockControl)sender;
			foreach (Control control in dockControl.Controls)
			{
				control.Size = dockControl.Size;
			}
		}

		private void OnDocumentContainerActiveDocumentChanged (object sender, ActiveDocumentEventArgs e)
		{
			this.propertyGrid.SelectedObjects = null;
		}

		private void OnDocumentContainerControlAdded (object sender, ControlEventArgs e)
		{
			WrappedTypeDocument document = (WrappedTypeDocument)e.Control;
			this.wrapperClass.WrappedTypes.Add (document.WrappingOptions.WrappedType);
		}

		private void OnDocumentContainerControlRemoved (object sender, ControlEventArgs e)
		{
			WrappedTypeDocument document = (WrappedTypeDocument)e.Control;
			this.wrapperClass.WrappedTypes.Remove (document.WrappingOptions.WrappedType);
		}

		private void OnNamespaceTextBoxTextChanged (object sender, EventArgs e)
		{
			if (this.namespaceTextBox.Text == View.defaultNamespace)
			{
				this.namespaceTextBox.BackColor = SystemColors.Info;
			}
			else
			{
				this.namespaceTextBox.BackColor = SystemColors.Window;
			}
			this.wrapperClass.Namespace = this.namespaceTextBox.Text;
		}

		private void OnClassNameTextBoxTextChanged (object sender, EventArgs e)
		{
			if (this.classNameTextBox.Text == View.defaultClassName)
			{
				this.classNameTextBox.BackColor = SystemColors.Info;
			}
			else
			{
				this.classNameTextBox.BackColor = SystemColors.Window;
			}
			this.wrapperClass.ClassName = this.classNameTextBox.Text;
		}

		private void OnNamespaceTextBoxLeave (object sender, EventArgs e)
		{
			if (this.namespaceTextBox.Text == string.Empty)
			{
				this.namespaceTextBox.Text = View.defaultNamespace;
			}
		}

		private void OnClassNameTextBoxLeave (object sender, EventArgs e)
		{
			if (this.classNameTextBox.Text == string.Empty)
			{
				this.classNameTextBox.Text = View.defaultClassName;
			}
		}

		private void OnPartialCheckBoxCheckedChanged (object sender, EventArgs e)
		{
			this.wrapperClass.Partial = this.partialCheckBox.Checked;
		}

		private void OnSealedCheckBoxCheckedChanged (object sender, EventArgs e)
		{
			this.wrapperClass.Sealed = this.sealedCheckBox.Checked;
		}

		private void AddAssemblies (string[] filePaths)
		{
			foreach (string filePath in filePaths)
			{
				if (this.loadedAssemblies.Contains (filePath.ToLower ()))
				{
					MessageBox.Show (filePath + " was already loaded.", "Assembly Already Loaded", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					try
					{
						this.assemblyBrowser.Assemblies.Add (filePath);
						this.loadedAssemblies.Add (filePath.ToLower ());
						this.assemblyBrowser.Focus ();
					}
					catch (BadImageFormatException)
					{
						MessageBox.Show (filePath + " is not a valid .NET assembly.", "Invalid Assembly", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					catch (Exception exception)
					{
						string message = "Failed to load " + filePath + Environment.NewLine + Environment.NewLine + exception.ToString ();
						MessageBox.Show (message, "Assembly Load Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					}
				}
			}
		}

		private void AddType ()
		{
			if (this.assemblyBrowser.SelectedNode is TypeNode)
			{
				TypeNode typeNode = (TypeNode)this.assemblyBrowser.SelectedNode;

				// NOTE: Allow multiple instances of the same type (this is probably common)
				//if (!this.typeDocuments.ContainsKey (typeNode.Type))
				//{
				WrappedType wrappedType = new WrappedType (typeNode.Type);

				WrappingOptions wrappingOptions = new WrappingOptions (wrappedType);
				wrappingOptions.MethodsListViewSelectedIndexChanged += this.OnListViewSelectedIndexChanged;
				wrappingOptions.PropertiesListViewSelectedIndexChanged += this.OnListViewSelectedIndexChanged;
				wrappingOptions.EventsListViewSelectedIndexChanged += this.OnListViewSelectedIndexChanged;

				WrappedTypeDocument document = new WrappedTypeDocument (wrappingOptions);
				document.SuspendLayout ();

				document.Guid = new Guid ("A694E86E-73C0-417e-B85D-A04361C3CDC4");
				document.SizeChanged += this.OnDockControlSizeChanged;

				document.PerformLayout ();

				this.documentContainer.AddDocument (document);

				//this.typeDocuments[typeNode.Type] = document;
				//}

				//this.typeDocuments[typeNode.Type].Activate ();

				document.Activate ();
			}
		}

		private void GenerateWrapper ()
		{
			string source = Generator.GenerateWrapper (this.wrapperClass, this.SelectedLanguage);
			GeneratedWrapper generatedWrapper = new GeneratedWrapper (source, this.SelectedLanguage);
			generatedWrapper.ShowDialog ();
		}
		#endregion
	}
}