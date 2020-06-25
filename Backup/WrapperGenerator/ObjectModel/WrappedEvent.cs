using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Text;

namespace WrapperGenerator.ObjectModel
{
	internal class WrappedEvent : WrappedMember
	{
		#region Fields
		private readonly EventInfo _event;
		#endregion      

		#region Constructors
		public WrappedEvent (EventInfo _event) 
			: base ()
		{
			this._event = _event;
		}
		#endregion

		#region Properties
		[Browsable (false)]
		public EventInfo Event
		{
			get
			{
				return this._event;
			}
		}
		#endregion
	}
}
