using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

using WrapperGenerator.ObjectModel;

namespace WrapperGenerator.UI
{
	internal class EventListViewItem : ListViewItem
	{
		#region Fields
		private readonly WrappedEvent wrappedEvent;
		#endregion

		#region Constructors
		public EventListViewItem (EventInfo _event)
		{
			this.wrappedEvent = new WrappedEvent (_event);
			this.Tag = this.wrappedEvent;

			this.Text = wrappedEvent.Event.ToString ();
			this.SubItems.Add (wrappedEvent.Accessibility.ToString ());
			this.SubItems.Add (wrappedEvent.Virtual.ToString ());
			this.SubItems.Add (wrappedEvent.Interface);

			this.wrappedEvent.AccessibilityChanged += this.OnAccessibilityChanged;
			this.wrappedEvent.VirtualChanged += this.OnVirtualChanged;
			this.wrappedEvent.InterfaceChanged += this.OnInterfaceChanged;
		}
		#endregion

		#region Properties
		public WrappedEvent WrappedEvent
		{
			get
			{
				return this.wrappedEvent;
			}
		}
		#endregion

		#region Private Events
		private void OnAccessibilityChanged (object sender, EventArgs e)
		{
			this.SubItems[1].Text = this.wrappedEvent.Accessibility.ToString ();
		}

		private void OnVirtualChanged (object sender, EventArgs e)
		{
			this.SubItems[2].Text = this.wrappedEvent.Virtual.ToString ();
		}

		private void OnInterfaceChanged (object sender, EventArgs e)
		{
			this.SubItems[3].Text = this.wrappedEvent.Interface;
		}
		#endregion
	}
}
