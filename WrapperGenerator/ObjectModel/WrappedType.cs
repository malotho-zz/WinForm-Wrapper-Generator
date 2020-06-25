using System;
using System.Collections.Generic;
using System.Text;

using WrapperGenerator.Utilities;

namespace WrapperGenerator.ObjectModel
{
	internal enum Acquisition : byte
	{
		Construct,
		Parameter,
		Property,
		UserManaged
	}

	internal enum Scope : byte
	{
		Instance,
		Static
	}

	internal class WrappedType
	{
		#region Fields
		private readonly Type type;
		private string fieldName;	
		private bool prefixMembers;	
		private Acquisition acquisition;
		private Scope scope;
		private readonly NotifyingCollection<WrappedMethod> wrappedMethods;
		private readonly NotifyingCollection<WrappedProperty> wrappedProperties;
		private readonly NotifyingCollection<WrappedEvent> wrappedEvents;
		#endregion  
        
		#region Constructors
		public WrappedType (Type type)
		{
			this.type = type;
			this.fieldName = "_" + type.Name;
			this.wrappedMethods = new NotifyingCollection<WrappedMethod> ();
			this.wrappedProperties = new NotifyingCollection<WrappedProperty> ();
			this.wrappedEvents = new NotifyingCollection<WrappedEvent> ();
		}
		#endregion

		#region Events
		/// <summary>       
		/// Event raised before the FieldName property has changed.       
		/// </summary>       
		public event EventHandler FieldNameChanging;

		/// <summary>       
		/// Event raised after the FieldName property has changed.       
		/// </summary>       
		public event EventHandler FieldNameChanged;

		/// <summary>       
		/// Event raised before the PrefixMembers property has changed.       
		/// </summary>       
		public event EventHandler PrefixMembersChanging;

		/// <summary>       
		/// Event raised after the PrefixMembers property has changed.       
		/// </summary>       
		public event EventHandler PrefixMembersChanged;

		/// <summary>       
		/// Event raised before the Acquisition property has changed.       
		/// </summary>       
		public event EventHandler AcquisitionChanging;

		/// <summary>       
		/// Event raised after the Acquisition property has changed.       
		/// </summary>       
		public event EventHandler AcquisitionChanged;

		/// <summary>       
		/// Event raised before the Scope property has changed.       
		/// </summary>       
		public event EventHandler ScopeChanging;

		/// <summary>       
		/// Event raised after the Scope property has changed.       
		/// </summary>       
		public event EventHandler ScopeChanged;
		#endregion

		#region Properties
		public Type Type
		{
			get
			{
				return this.type;
			}
		}

		/// <summary>
		/// Name of the field corresponding to this wrapped type
		/// </summary>
		public string FieldName
		{
			get
			{
				return this.fieldName;
			}
			set
			{
				if (this.fieldName != value)
				{
					this.RaiseFieldNameChangingEvent ();
					this.fieldName = value;
					this.RaiseFieldNameChangedEvent ();
				}
			}
		}

		/// <summary>
		/// Determines whether member names should be prefixed with the field name
		/// </summary>
		public bool PrefixMembers
		{
			get
			{
				return this.prefixMembers;
			}
			set
			{
				if (this.prefixMembers != value)
				{
					this.RaisePrefixMembersChangingEvent ();
					this.prefixMembers = value;
					this.RaisePrefixMembersChangedEvent ();
				}
			}
		}

		/// <summary>
		/// Determines how the instance of the wrapped type is acquired
		/// </summary>
		public Acquisition Acquisition
		{
			get
			{
				return this.acquisition;
			}
			set
			{
				if (this.acquisition != value)
				{
					this.RaiseAcquisitionChangingEvent ();
					this.acquisition = value;
					this.RaiseAcquisitionChangedEvent ();
				}
			}
		}

		/// <summary>
		/// The scope of the instance of the wrapped type
		/// </summary>
		public Scope Scope
		{
			get
			{
				return this.scope;
			}
			set
			{
				if (this.scope != value)
				{
					this.RaiseScopeChangingEvent ();
					this.scope = value;
					this.RaiseScopeChangedEvent ();
				}
			}
		}

		public ICollection<WrappedMethod> WrappedMethods
		{
			get
			{
				return this.wrappedMethods;
			}
		}

		public ICollection<WrappedProperty> WrappedProperties
		{
			get
			{
				return this.wrappedProperties;
			}
		}

		public ICollection<WrappedEvent> WrappedEvents
		{
			get
			{
				return this.wrappedEvents;
			}
		}
		#endregion

		#region Private Methods
		/// <summary>       
		/// Raises the FieldNameChanging event.       
		/// </summary>       
		private void RaiseFieldNameChangingEvent ()
		{
			if (this.FieldNameChanging != null)
			{
				this.FieldNameChanging (this, EventArgs.Empty);
			}
		}

		/// <summary>       
		/// Raises the FieldNameChanged event.       
		/// </summary>       
		private void RaiseFieldNameChangedEvent ()
		{
			if (this.FieldNameChanged != null)
			{
				this.FieldNameChanged (this, EventArgs.Empty);
			}
		}

		/// <summary>       
		/// Raises the PrefixMembersChanging event.       
		/// </summary>       
		private void RaisePrefixMembersChangingEvent ()
		{
			if (this.PrefixMembersChanging != null)
			{
				this.PrefixMembersChanging (this, EventArgs.Empty);
			}
		}

		/// <summary>       
		/// Raises the PrefixMembersChanged event.       
		/// </summary>       
		private void RaisePrefixMembersChangedEvent ()
		{
			if (this.PrefixMembersChanged != null)
			{
				this.PrefixMembersChanged (this, EventArgs.Empty);
			}
		}

		/// <summary>       
		/// Raises the AcquisitionChanging event.       
		/// </summary>       
		private void RaiseAcquisitionChangingEvent ()
		{
			if (this.AcquisitionChanging != null)
			{
				this.AcquisitionChanging (this, EventArgs.Empty);
			}
		}

		/// <summary>       
		/// Raises the AcquisitionChanged event.       
		/// </summary>       
		private void RaiseAcquisitionChangedEvent ()
		{
			if (this.AcquisitionChanged != null)
			{
				this.AcquisitionChanged (this, EventArgs.Empty);
			}
		}

		/// <summary>       
		/// Raises the ScopeChanging event.       
		/// </summary>       
		private void RaiseScopeChangingEvent ()
		{
			if (this.ScopeChanging != null)
			{
				this.ScopeChanging (this, EventArgs.Empty);
			}
		}

		/// <summary>       
		/// Raises the ScopeChanged event.       
		/// </summary>       
		private void RaiseScopeChangedEvent ()
		{
			if (this.ScopeChanged != null)
			{
				this.ScopeChanged (this, EventArgs.Empty);
			}
		}
		#endregion
	}
}
