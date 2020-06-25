using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

using WrapperGenerator.ObjectModel;

namespace WrapperGenerator.UI
{
	internal partial class WrappingOptions : UserControl
	{
		#region Enums
		public enum ImageIndices : byte
		{
			Method,
			Property,
			Event
		}
		#endregion

		#region Fields
		private readonly WrappedType wrappedType;
		private string defaultFieldName;
		#endregion

		#region Constructors
		public WrappingOptions (WrappedType wrappedType)
		{
			InitializeComponent ();
			InitializeWrapper ();

			this.wrappedType = wrappedType;

			Tuple[] acquisitionModes = 
			{
				new Tuple (Acquisition.Construct, "Construct an instance of the wrapped type"),
				new Tuple (Acquisition.Parameter, "Pass an instance of the wrapped type as a parameter"),
				new Tuple (Acquisition.Property, "Set an instance of the wrapped type as a property"),
				new Tuple (Acquisition.UserManaged, "Allow user to control instance management of the wrapped type")
			};

			this.acquisitionComboBox.ValueMember = "Value1";
			this.acquisitionComboBox.DisplayMember = "Values";
			this.acquisitionComboBox.Items.AddRange (acquisitionModes);
			this.acquisitionComboBox.SelectedIndex = 0;

			this.defaultFieldName = wrappedType.FieldName;
			this.fieldNameTextBox.Text = this.defaultFieldName;
			
			// Methods
			MethodInfo[] methods = wrappedType.Type.GetMethods (BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static);
			Array.Sort<MethodInfo> (methods, this.MethodNameComparison);
			foreach (MethodInfo method in methods)
			{
				if (!method.Name.ToLower ().StartsWith ("get_") && !method.Name.ToLower ().StartsWith ("set_") &&
					!method.Name.ToLower ().StartsWith ("add_") && !method.Name.ToLower ().StartsWith ("remove_"))
				{
					MethodListViewItem listViewItem = new MethodListViewItem (method);
					listViewItem.ImageIndex = (int)WrappingOptions.ImageIndices.Method;
					this.methodsListView.Items.Add (listViewItem);
				}
			}

			// Properties
			PropertyInfo[] properties = wrappedType.Type.GetProperties (BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static);
			Array.Sort<PropertyInfo> (properties, this.PropertyNameComparison);
			foreach (PropertyInfo property in properties)
			{
				PropertyListViewItem listViewItem = new PropertyListViewItem (property);
				listViewItem.ImageIndex = (int)WrappingOptions.ImageIndices.Property;
				this.propertiesListView.Items.Add (listViewItem);
			}

			// Events
			EventInfo[] events = wrappedType.Type.GetEvents (BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static);
			Array.Sort<EventInfo> (events, this.EventNameComparison);
			foreach (EventInfo _event in events)
			{
				EventListViewItem listViewItem = new EventListViewItem (_event);
				listViewItem.ImageIndex = (int)WrappingOptions.ImageIndices.Event;
				this.eventsListView.Items.Add (listViewItem);
			}
		}
		#endregion

		#region Properties
		public WrappedType WrappedType
		{
			get
			{
				return this.wrappedType;
			}
		}
		#endregion

		#region Private Methods
		private void OnAcquisitionComboBoxSelectedIndexChanged (object sender, EventArgs e)
		{
			this.wrappedType.Acquisition = (Acquisition)((Tuple)this.acquisitionComboBox.SelectedItem).Value1;
		}

		private void OnFieldNameTextBoxTextChanged (object sender, EventArgs e)
		{
			if (this.fieldNameTextBox.Text == this.defaultFieldName)
			{
				this.fieldNameTextBox.BackColor = SystemColors.Info;
			}
			else
			{
				this.fieldNameTextBox.BackColor = SystemColors.Window;
			}
			this.wrappedType.FieldName = this.fieldNameTextBox.Text;
		}

		private void OnFieldNameTextBoxLeave (object sender, EventArgs e)
		{
			if (this.fieldNameTextBox.Text == string.Empty)
			{
				this.fieldNameTextBox.Text = this.defaultFieldName;
			}
		}

		private void OnPrefixCheckBoxCheckedChanged (object sender, EventArgs e)
		{
			this.wrappedType.PrefixMembers = this.prefixCheckBox.Checked;
		}

		private void OnMethodsListViewItemChecked (object sender, ItemCheckedEventArgs e)
		{
			MethodListViewItem listViewItem = (MethodListViewItem)e.Item;
			if (e.Item.Checked)
			{
				this.wrappedType.WrappedMethods.Add (listViewItem.WrappedMethod);
			}
			else
			{
				this.wrappedType.WrappedMethods.Remove (listViewItem.WrappedMethod);
			}
		}

		private void OnPropertiesListViewItemChecked (object sender, ItemCheckedEventArgs e)
		{
			PropertyListViewItem listViewItem = (PropertyListViewItem)e.Item;
			if (e.Item.Checked)
			{
				this.wrappedType.WrappedProperties.Add (listViewItem.WrappedProperty);
			}
			else
			{
				this.wrappedType.WrappedProperties.Remove (listViewItem.WrappedProperty);
			}
		}

		private void OnEventsListViewItemChecked (object sender, ItemCheckedEventArgs e)
		{
			EventListViewItem listViewItem = (EventListViewItem)e.Item;
			if (e.Item.Checked)
			{
				this.wrappedType.WrappedEvents.Add (listViewItem.WrappedEvent);
			}
			else
			{
				this.wrappedType.WrappedEvents.Remove (listViewItem.WrappedEvent);
			}
		}

		private int MethodNameComparison (MethodInfo method1, MethodInfo method2)
		{
			return Comparer<string>.Default.Compare (method1.Name, method2.Name);
		}

		private int PropertyNameComparison (PropertyInfo property1, PropertyInfo property2)
		{
			return Comparer<string>.Default.Compare (property1.Name, property2.Name);
		}

		private int EventNameComparison (EventInfo event1, EventInfo event2)
		{
			return Comparer<string>.Default.Compare (event1.Name, event2.Name);
		}
		#endregion

		#region Classes
		private class Tuple
		{
			#region Fields
			private readonly object value1;
			private readonly object value2;
			#endregion

			#region Constructors
			public Tuple (object value1, object value2)
			{
				this.value1 = value1;
				this.value2 = value2;
			}
			#endregion

			#region Properties
			public object Value1
			{
				get
				{
					return this.value1;
				}
			}

			public object Value2
			{
				get
				{
					return this.value2;
				}
			}

			public string Values
			{
				get
				{
					return this.Value1 + " - " + this.Value2;
				}
			}
			#endregion
		}
		#endregion
	}
}
