using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Text;

namespace WrapperGenerator.ObjectModel
{
	public enum Accessibility : byte
	{
		Public = MethodAttributes.Public,
		Protected,
		Private = MethodAttributes.Private
	}
}
