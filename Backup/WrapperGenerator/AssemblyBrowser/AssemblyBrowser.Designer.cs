namespace WrapperGenerator.UI
{
	partial class AssemblyBrowser
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose (bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose ();
			}
			base.Dispose (disposing);
		}

		#region Component Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent ()
		{
			this.components = new System.ComponentModel.Container ();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager (typeof (AssemblyBrowser));
			this.imageList = new System.Windows.Forms.ImageList (this.components);
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog ();
			this.SuspendLayout ();
			// 
			// imageList
			// 
			this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject ("imageList.ImageStream")));
			this.imageList.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList.Images.SetKeyName (0, "Assembly.png");
			this.imageList.Images.SetKeyName (1, "Namespace.png");
			this.imageList.Images.SetKeyName (2, "Class.png");
			this.imageList.Images.SetKeyName (3, "Method.png");
			// 
			// openFileDialog
			// 
			this.openFileDialog.Filter = "Assemblies|*.dll";
			// 
			// AssemblyBrowser
			// 
			this.ImageIndex = 0;
			this.ImageList = this.imageList;
			this.LineColor = System.Drawing.Color.Black;
			this.SelectedImageIndex = 0;
			this.ResumeLayout (false);

		}

		#endregion

		private System.Windows.Forms.ImageList imageList;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
	}
}
