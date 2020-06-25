using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

using WrapperGenerator.Utilities;

namespace WrapperGenerator.ObjectModel
{
	internal class WrapperClass
	{
		#region Fields
		private string className;
		private string _namespace;
		private bool partial;
		private bool _sealed;
		private readonly NotifyingCollection<WrappedType> wrappedTypes;
		#endregion           

		#region Constructors
		public WrapperClass ()
		{
			this.className = "MyWrapperClass";
			this._namespace = "MyNamespace";
			this.partial = false;
			this._sealed = false;
			this.wrappedTypes = new NotifyingCollection<WrappedType> ();
		}
		#endregion

		#region Events
		/// <summary>       
		/// Event raised before the ClassName property has changed.       
		/// </summary>       
		public event EventHandler ClassnameChanging;

		/// <summary>       
		/// Event raised after the ClassName property has changed.       
		/// </summary>       
		public event EventHandler ClassnameChanged;

		/// <summary>       
		/// Event raised before the Namespace property has changed.       
		/// </summary>       
		public event EventHandler NamespaceChanging;

		/// <summary>       
		/// Event raised after the Namespace property has changed.       
		/// </summary>       
		public event EventHandler NamespaceChanged;

		/// <summary>       
		/// Event raised before the Partial property has changed.       
		/// </summary>       
		public event EventHandler PartialChanging;

		/// <summary>       
		/// Event raised after the Partial property has changed.       
		/// </summary>       
		public event EventHandler PartialChanged;

		/// <summary>       
		/// Event raised before the Sealed property has changed.       
		/// </summary>       
		public event EventHandler SealedChanging;

		/// <summary>       
		/// Event raised after the Sealed property has changed.       
		/// </summary>       
		public event EventHandler SealedChanged;
		#endregion

		#region Properties
		/// <summary>
		/// Name of the wrapper class
		/// </summary>
		public string ClassName
		{
			get
			{
				return this.className;
			}
			set
			{
				if (this.className != value)
				{
					this.RaiseClassnameChangingEvent ();
					this.className = value;
					this.RaiseClassnameChangedEvent ();
				}
			}
		}

		/// <summary>
		/// Namespace of the wrapper class
		/// </summary>
		public string Namespace
		{
			get
			{
				return this._namespace;
			}
			set
			{
				if (this._namespace != value)
				{
					this.RaiseNamespaceChangingEvent ();
					this._namespace = value;
					this.RaiseNamespaceChangedEvent ();
				}
			}
		}

		/// <summary>
		/// Determines whether a partial class is generated
		/// </summary>
		public bool Partial
		{
			get
			{
				return this.partial;
			}
			set
			{
				if (this.partial != value)
				{
					this.RaisePartialChangingEvent ();
					this.partial = value;
					this.RaisePartialChangedEvent ();
				}
			}
		}

		/// <summary>
		/// Determines whether the wrapper class is sealed
		/// </summary>
		public bool Sealed
		{
			get
			{
				return this._sealed;
			}
			set
			{
				if (this._sealed != value)
				{
					this.RaiseSealedChangingEvent ();
					this._sealed = value;
					this.RaiseSealedChangedEvent ();
				}
			}
		}

		[Browsable (false)]
		public ICollection<WrappedType> WrappedTypes
		{
			get
			{
				return this.wrappedTypes;
			}
		}
		#endregion

		#region Private Methods
		/// <summary>       
		/// Raises the ClassnameChanging event.       
		/// </summary>       
		private void RaiseClassnameChangingEvent ()
		{
			if (this.ClassnameChanging != null)
			{
				this.ClassnameChanging (this, EventArgs.Empty);
			}
		}

		/// <summary>       
		/// Raises the ClassnameChanged event.       
		/// </summary>       
		private void RaiseClassnameChangedEvent ()
		{
			if (this.ClassnameChanged != null)
			{
				this.ClassnameChanged (this, EventArgs.Empty);
			}
		}

		/// <summary>       
		/// Raises the NamespaceChanging event.       
		/// </summary>       
		private void RaiseNamespaceChangingEvent ()
		{
			if (this.NamespaceChanging != null)
			{
				this.NamespaceChanging (this, EventArgs.Empty);
			}
		}

		/// <summary>       
		/// Raises the NamespaceChanged event.       
		/// </summary>       
		private void RaiseNamespaceChangedEvent ()
		{
			if (this.NamespaceChanged != null)
			{
				this.NamespaceChanged (this, EventArgs.Empty);
			}
		}

		/// <summary>       
		/// Raises the PartialChanging event.       
		/// </summary>       
		private void RaisePartialChangingEvent ()
		{
			if (this.PartialChanging != null)
			{
				this.PartialChanging (this, EventArgs.Empty);
			}
		}

		/// <summary>       
		/// Raises the PartialChanged event.       
		/// </summary>       
		private void RaisePartialChangedEvent ()
		{
			if (this.PartialChanged != null)
			{
				this.PartialChanged (this, EventArgs.Empty);
			}
		}

		/// <summary>       
		/// Raises the SealedChanging event.       
		/// </summary>       
		private void RaiseSealedChangingEvent ()
		{
			if (this.SealedChanging != null)
			{
				this.SealedChanging (this, EventArgs.Empty);
			}
		}

		/// <summary>       
		/// Raises the SealedChanged event.       
		/// </summary>       
		private void RaiseSealedChangedEvent ()
		{
			if (this.SealedChanged != null)
			{
				this.SealedChanged (this, EventArgs.Empty);
			}
		}
		#endregion
	}
}
