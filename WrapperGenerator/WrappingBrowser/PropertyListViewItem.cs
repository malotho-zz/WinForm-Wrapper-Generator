using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

using WrapperGenerator.ObjectModel;

namespace WrapperGenerator.UI
{
	internal class PropertyListViewItem : ListViewItem
	{
		#region Fields
		private readonly WrappedProperty wrappedProperty;
		#endregion

		#region Constructors
		public PropertyListViewItem (PropertyInfo property)
		{
			this.wrappedProperty = new WrappedProperty (property);
			this.Tag = this.wrappedProperty;

			this.Text = wrappedProperty.Property.Name;
			this.SubItems.Add (wrappedProperty.Get.ToString ());
			this.SubItems.Add (wrappedProperty.Set.ToString ());
			this.SubItems.Add (wrappedProperty.Accessibility.ToString ());
			this.SubItems.Add (wrappedProperty.Virtual.ToString ());
			this.SubItems.Add (wrappedProperty.Interface);

			this.wrappedProperty.GetChanged += this.OnGetChanged;
			this.wrappedProperty.SetChanged += this.OnSetChanged;
			this.wrappedProperty.AccessibilityChanged += this.OnAccessibilityChanged;
			this.wrappedProperty.VirtualChanged += this.OnVirtualChanged;
			this.wrappedProperty.InterfaceChanged += this.OnInterfaceChanged;
		}
		#endregion

		#region Properties
		public WrappedProperty WrappedProperty
		{
			get
			{
				return this.wrappedProperty;
			}
		}
		#endregion

		#region Private Methods
		private void OnGetChanged (object sender, EventArgs e)
		{
			this.SubItems[1].Text = this.wrappedProperty.Get.ToString ();
		}

		private void OnSetChanged (object sender, EventArgs e)
		{
			this.SubItems[2].Text = this.wrappedProperty.Set.ToString ();
		}

		private void OnAccessibilityChanged (object sender, EventArgs e)
		{
			this.SubItems[3].Text = this.wrappedProperty.Accessibility.ToString ();
		}

		private void OnVirtualChanged (object sender, EventArgs e)
		{
			this.SubItems[4].Text = this.wrappedProperty.Virtual.ToString ();
		}

		private void OnInterfaceChanged (object sender, EventArgs e)
		{
			this.SubItems[5].Text = this.wrappedProperty.Interface;
		}
		#endregion
	}
}
