using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace WrapperGenerator.UI
{
	public class AssemblyNode : TreeNode
	{
		#region Fields
		private readonly Assembly assembly;
		private readonly Dictionary<string, TreeNode> namespaceNodes;
		#endregion

		#region Constructors
		public AssemblyNode (Assembly assembly)
			: base (assembly.GetName ().Name, (int)AssemblyBrowser.ImageIndices.Assembly, (int)AssemblyBrowser.ImageIndices.Assembly)
		{
			this.assembly = assembly;

			this.namespaceNodes = new Dictionary<string, TreeNode> (StringComparer.CurrentCultureIgnoreCase);

			List<Type> types = new List<Type> ();			

			foreach (Type type in assembly.GetTypes ())
			{
				if (type.IsPublic)
				{
					types.Add (type);
				}
			}

			types.Sort (this.TypeNameComparison);

			List<TreeNode> namespaceNodes = new List<TreeNode> ();
			foreach (Type type in types)
			{
				TreeNode namespaceNode = null;
				if (this.namespaceNodes.ContainsKey (type.Namespace))
				{
					namespaceNode = this.namespaceNodes[type.Namespace];
				}
				else
				{

					namespaceNode = new TreeNode (type.Namespace);
					namespaceNode.ImageIndex = namespaceNode.SelectedImageIndex = namespaceNode.StateImageIndex = (int)AssemblyBrowser.ImageIndices.Namespace;
					namespaceNodes.Add (namespaceNode);
					this.namespaceNodes[type.Namespace] = namespaceNode;
				}

				namespaceNode.Nodes.Add (new TypeNode (type));
			}

			namespaceNodes.Sort (this.TreeNodeTextComparison);

			foreach (TreeNode namespaceNode in namespaceNodes)
			{
				this.Nodes.Add (namespaceNode);
			}
		}
		#endregion

		#region Properties
		public Assembly Assembly
		{
			get
			{
				return this.assembly;
			}
		}
		#endregion

		#region Private Methods
		private int TypeNameComparison (Type type1, Type type2)
		{
			return Comparer<string>.Default.Compare (type1.Name, type2.Name);
		}

		private int TreeNodeTextComparison (TreeNode treeNode1, TreeNode treeNode2)
		{
			return Comparer<string>.Default.Compare (treeNode1.Text, treeNode2.Text);
		}
		#endregion
	}
}
