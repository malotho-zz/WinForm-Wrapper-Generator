using System;
using System.Collections.Generic;
using System.Text;

using TD.SandDock;

namespace WrapperGenerator.UI
{
	internal class WrappedTypeDocument : DockControl
	{
		#region Fields
		private WrappingOptions wrappingOptions;
		#endregion

		#region Constructors
		public WrappedTypeDocument (WrappingOptions wrappingOptions)
		{
			this.Controls.Add (wrappingOptions);
		}
		#endregion

		#region Properties
		public WrappingOptions WrappingOptions
		{
			get
			{
				return this.wrappingOptions;
			}
		}
		#endregion

		#region Protected Methods
		protected override void OnControlAdded (System.Windows.Forms.ControlEventArgs e)
		{
			if (this.Controls.Count > 1 || !(e.Control is WrappingOptions))
			{
				throw new InvalidOperationException (this.GetType ().Name + " can contain only one " + this.wrappingOptions.GetType ().Name + " and no other controls");
			}

			this.wrappingOptions = (WrappingOptions)e.Control;

			this.Text = this.wrappingOptions.WrappedType.FieldName;
			this.wrappingOptions.WrappedType.FieldNameChanged += this.OnWrappedTypeFieldNameChanged;

			base.OnControlAdded (e);
		}		
		#endregion

		#region Private Methods
		private void OnWrappedTypeFieldNameChanged (object sender, EventArgs e)
		{
			this.Text = this.wrappingOptions.WrappedType.FieldName;
		}
		#endregion
	}
}
