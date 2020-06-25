using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace WrapperGenerator.UI
{
	public class TypeNode : TreeNode
	{
		#region Fields
		private readonly Type type;
		#endregion

		#region Constructors
		public TypeNode (Type type)
			: base (type.Name, (int)AssemblyBrowser.ImageIndices.Class, (int)AssemblyBrowser.ImageIndices.Class)
		{
			this.type = type;
		}
		#endregion

		#region Properties
		public Type Type
		{
			get
			{
				return this.type;
			}
		}
		#endregion
	}
}
