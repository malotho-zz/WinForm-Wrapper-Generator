using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

using WrapperGenerator.ObjectModel;

namespace WrapperGenerator.UI
{
	internal class MethodListViewItem : ListViewItem
	{
		#region Fields
		private readonly WrappedMethod wrappedMethod;
		#endregion

		#region Constructors
		public MethodListViewItem (MethodInfo method)
		{
			this.wrappedMethod = new WrappedMethod (method);
			this.Tag = this.wrappedMethod;

			this.Text = wrappedMethod.Method.ToString ();
			this.SubItems.Add (wrappedMethod.Accessibility.ToString ());
			this.SubItems.Add (wrappedMethod.Virtual.ToString ());
			this.SubItems.Add (wrappedMethod.Interface);

			this.wrappedMethod.AccessibilityChanged += this.OnAccessibilityChanged;
			this.wrappedMethod.VirtualChanged += this.OnVirtualChanged;
			this.wrappedMethod.InterfaceChanged += this.OnInterfaceChanged;
		}
		#endregion

		#region Properties
		public WrappedMethod WrappedMethod
		{
			get
			{
				return this.wrappedMethod;
			}
		}
		#endregion

		#region Private Methods
		private void OnAccessibilityChanged (object sender, EventArgs e)
		{
			this.SubItems[1].Text = this.wrappedMethod.Accessibility.ToString ();
		}

		private void OnVirtualChanged (object sender, EventArgs e)
		{
			this.SubItems[2].Text = this.wrappedMethod.Virtual.ToString ();
		}

		private void OnInterfaceChanged (object sender, EventArgs e)
		{
			this.SubItems[3].Text = this.wrappedMethod.Interface;
		}
		#endregion
	}
}
