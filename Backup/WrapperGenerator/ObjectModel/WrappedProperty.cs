using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Text;

namespace WrapperGenerator.ObjectModel
{
	internal class WrappedProperty : WrappedMember
	{
		#region Fields
		private readonly PropertyInfo property;
		private bool _get;
		private bool _set;
		#endregion  
        
		#region Constructors
		public WrappedProperty (PropertyInfo property)
			: base ()
		{
			this.property = property;

			this._get = this.property.CanRead && this.property.GetGetMethod (true).IsPublic;
			this._set = this.property.CanWrite && this.property.GetSetMethod (true).IsPublic;
		}
		#endregion

		#region Events
		/// <summary>       
		/// Event raised before the Get property has changed.       
		/// </summary>       
		public event EventHandler GetChanging;

		/// <summary>       
		/// Event raised after the Get property has changed.       
		/// </summary>       
		public event EventHandler GetChanged;

		/// <summary>       
		/// Event raised before the Set property has changed.       
		/// </summary>       
		public event EventHandler SetChanging;

		/// <summary>       
		/// Event raised after the Set property has changed.       
		/// </summary>       
		public event EventHandler SetChanged;
		#endregion

		#region Properties
		[Browsable (false)]
		public PropertyInfo Property
		{
			get
			{
				return this.property;
			}
		}

		/// <summary>
		/// Determines whether the wrapped property has a getter
		/// </summary>
		[Category ("Property")]
		[Description ("Determines whether the property has a 'get'.")]
		public bool Get
		{
			get
			{
				return this._get;
			}
			set
			{
				if (this._get != value)
				{
					if (value)
					{
						if (!this.property.CanRead)
						{
							throw new ArgumentException (string.Format ("Wrapped property '{0}' does not have a 'get'", this.property.Name));
						}

						if (!this.property.GetGetMethod (true).IsPublic)
						{
							throw new ArgumentException (string.Format ("Wrapped property '{0}' has a 'get' but it is not public", this.property.Name));
						}
					}

					if (!value && !this.Set)
					{
						throw new ArgumentException (string.Format ("Wrapped property '{0}' must have either 'get' or 'set'", this.property.Name));
					}

					this.RaiseGetChangingEvent ();
					this._get = value;
					this.RaiseGetChangedEvent ();
				}
			}
		}

		/// <summary>
		/// Determines whether the wrapped property has a setter
		/// </summary>
		[Category ("Property")]
		[Description ("Determines whether the property has a 'set'.")]
		public bool Set
		{
			get
			{
				return this._set;
			}
			set
			{
				if (this._set != value)
				{
					if (value)
					{
						if (!this.property.CanWrite)
						{
							throw new ArgumentException (string.Format ("Wrapped property '{0}' does not have a 'set'", this.property.Name));
						}

						if (!this.property.GetSetMethod (true).IsPublic)
						{
							throw new ArgumentException (string.Format ("Wrapped property '{0}' has a 'set' but it is not public", this.property.Name));
						}
					}


					if (!value && !this.Get)
					{
						throw new ArgumentException (string.Format ("Wrapped property '{0}' must have either 'get' or 'set'", this.property.Name));
					}

					this.RaiseSetChangingEvent ();
					this._set = value;
					this.RaiseSetChangedEvent ();
				}
			}
		}
		#endregion

		#region Private Methods
		/// <summary>       
		/// Raises the GetChanging event.       
		/// </summary>       
		private void RaiseGetChangingEvent ()
		{
			if (this.GetChanging != null)
			{
				this.GetChanging (this, EventArgs.Empty);
			}
		}

		/// <summary>       
		/// Raises the GetChanged event.       
		/// </summary>       
		private void RaiseGetChangedEvent ()
		{
			if (this.GetChanged != null)
			{
				this.GetChanged (this, EventArgs.Empty);
			}
		}

		/// <summary>       
		/// Raises the SetChanging event.       
		/// </summary>       
		private void RaiseSetChangingEvent ()
		{
			if (this.SetChanging != null)
			{
				this.SetChanging (this, EventArgs.Empty);
			}
		}

		/// <summary>       
		/// Raises the SetChanged event.       
		/// </summary>       
		private void RaiseSetChangedEvent ()
		{
			if (this.SetChanged != null)
			{
				this.SetChanged (this, EventArgs.Empty);
			}
		}
		#endregion
	}
}
