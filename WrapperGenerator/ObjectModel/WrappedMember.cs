using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Text;

namespace WrapperGenerator.ObjectModel
{
	internal abstract class WrappedMember
	{
		#region Fields
		private Accessibility accessibility;
		private bool _virtual;
		private string _interface;
		#endregion      

		#region Constructors
		public WrappedMember ()
		{
			this.accessibility = Accessibility.Public;
			this._virtual = false;
			this._interface = string.Empty;
		}
		#endregion

		#region Events
		/// <summary>       
		/// Event raised before the Accessibility property has changed.       
		/// </summary>       
		public event EventHandler AccessibilityChanging;

		/// <summary>       
		/// Event raised after the Accessibility property has changed.       
		/// </summary>       
		public event EventHandler AccessibilityChanged;

		/// <summary>       
		/// Event raised before the Interface property has changed.       
		/// </summary>       
		public event EventHandler InterfaceChanging;

		/// <summary>       
		/// Event raised after the Interface property has changed.       
		/// </summary>       
		public event EventHandler InterfaceChanged;

		/// <summary>       
		/// Event raised before the Virtual property has changed.       
		/// </summary>       
		public event EventHandler VirtualChanging;

		/// <summary>       
		/// Event raised after the Virtual property has changed.       
		/// </summary>       
		public event EventHandler VirtualChanged;
		#endregion

		#region Properties
		/// <summary>
		/// Accessibility of the wrapper method
		/// </summary>
		[Category ("Member")]
		[Description ("Specifies the level of accessibility of the member.")]
		public Accessibility Accessibility
		{
			get
			{
				return this.accessibility;
			}
			set
			{
				if (this.accessibility != value)
				{
					this.RaiseAccessibilityChangingEvent ();
					this.accessibility = value;
					this.RaiseAccessibilityChangedEvent ();
				}
			}
		}

		/// <summary>
		/// Whether the wrapper method is virtual
		/// </summary>
		[Category ("Member")]
		[Description ("Determines whether the member is virtual.")]
		public bool Virtual
		{
			get
			{
				return this._virtual;
			}
			set
			{
				if (this._virtual != value)
				{
					this.RaiseVirtualChangingEvent ();
					this._virtual = value;
					this.RaiseVirtualChangedEvent ();
				}
			}
		}

		/// <summary>
		/// Interface this method is implementing
		/// </summary>
		[Category ("Member")]
		[Description ("Specifies an interface that this member explicitly implements.")]
		public string Interface
		{
			get
			{
				return this._interface;
			}
			set
			{
				if (this._interface != value)
				{
					this.RaiseInterfaceChangingEvent ();
					this._interface = value;
					this.RaiseInterfaceChangedEvent ();
				}
			}
		}
		#endregion

		#region Private Methods
		/// <summary>       
		/// Raises the AccessibilityChanging event.       
		/// </summary>       
		private void RaiseAccessibilityChangingEvent ()
		{
			if (this.AccessibilityChanging != null)
			{
				this.AccessibilityChanging (this, EventArgs.Empty);
			}
		}

		/// <summary>       
		/// Raises the AccessibilityChanged event.       
		/// </summary>       
		private void RaiseAccessibilityChangedEvent ()
		{
			if (this.AccessibilityChanged != null)
			{
				this.AccessibilityChanged (this, EventArgs.Empty);
			}
		}

		/// <summary>       
		/// Raises the InterfaceChanging event.       
		/// </summary>       
		private void RaiseInterfaceChangingEvent ()
		{
			if (this.InterfaceChanging != null)
			{
				this.InterfaceChanging (this, EventArgs.Empty);
			}
		}

		/// <summary>       
		/// Raises the InterfaceChanged event.       
		/// </summary>       
		private void RaiseInterfaceChangedEvent ()
		{
			if (this.InterfaceChanged != null)
			{
				this.InterfaceChanged (this, EventArgs.Empty);
			}
		}

		/// <summary>       
		/// Raises the VirtualChanging event.       
		/// </summary>       
		private void RaiseVirtualChangingEvent ()
		{
			if (this.VirtualChanging != null)
			{
				this.VirtualChanging (this, EventArgs.Empty);
			}
		}

		/// <summary>       
		/// Raises the VirtualChanged event.       
		/// </summary>       
		private void RaiseVirtualChangedEvent ()
		{
			if (this.VirtualChanged != null)
			{
				this.VirtualChanged (this, EventArgs.Empty);
			}
		}
		#endregion
	}
}
