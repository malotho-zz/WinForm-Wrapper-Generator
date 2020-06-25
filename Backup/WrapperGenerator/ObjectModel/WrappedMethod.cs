using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Text;

namespace WrapperGenerator.ObjectModel
{
	internal class WrappedMethod : WrappedMember
	{
		#region Fields
		private readonly MethodInfo method;
		#endregion      

		#region Constructors
		public WrappedMethod (MethodInfo method) 
			: base ()
		{
			this.method = method;
		}
		#endregion

		#region Properties
		[Browsable (false)]
		public MethodInfo Method
		{
			get
			{
				return this.method;
			}
		}
		#endregion
	}
}
