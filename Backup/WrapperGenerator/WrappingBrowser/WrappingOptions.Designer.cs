namespace WrapperGenerator.UI
{
	partial class WrappingOptions
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager (typeof (WrappingOptions));
			this.acquisitionLabel = new System.Windows.Forms.Label ();
			this.acquisitionComboBox = new System.Windows.Forms.ComboBox ();
			this.fieldNameLabel = new System.Windows.Forms.Label ();
			this.methodsLabel = new System.Windows.Forms.Label ();
			this.methodsListView = new System.Windows.Forms.ListView ();
			this.methodColumnHeader = new System.Windows.Forms.ColumnHeader ();
			this.accessibilityColumnHeader = new System.Windows.Forms.ColumnHeader ();
			this.virtualColumnHeader = new System.Windows.Forms.ColumnHeader ();
			this.interfaceColumnHeader = new System.Windows.Forms.ColumnHeader ();
			this.imageList = new System.Windows.Forms.ImageList (this.components);
			this.propertiesListView = new System.Windows.Forms.ListView ();
			this.propertyColumnHeader = new System.Windows.Forms.ColumnHeader ();
			this.getColumnHeader = new System.Windows.Forms.ColumnHeader ();
			this.setColumnHeader = new System.Windows.Forms.ColumnHeader ();
			this.propertyAccessibilityColumnHeader = new System.Windows.Forms.ColumnHeader ();
			this.propertyVirtualColumnHeader = new System.Windows.Forms.ColumnHeader ();
			this.interfacePropertyColumnHeader = new System.Windows.Forms.ColumnHeader ();
			this.propertiesLabel = new System.Windows.Forms.Label ();
			this.eventsListView = new System.Windows.Forms.ListView ();
			this.eventColumnHeader = new System.Windows.Forms.ColumnHeader ();
			this.eventAccessibilityColumnHeader = new System.Windows.Forms.ColumnHeader ();
			this.eventVirtualColumnHeader = new System.Windows.Forms.ColumnHeader ();
			this.eventInterfaceColumnHeader = new System.Windows.Forms.ColumnHeader ();
			this.eventsLabel = new System.Windows.Forms.Label ();
			this.fieldNameTextBox = new System.Windows.Forms.TextBox ();
			this.prefixCheckBox = new System.Windows.Forms.CheckBox ();
			this.SuspendLayout ();
			// 
			// acquisitionLabel
			// 
			this.acquisitionLabel.AutoSize = true;
			this.acquisitionLabel.Font = new System.Drawing.Font ("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.acquisitionLabel.Location = new System.Drawing.Point (3, 10);
			this.acquisitionLabel.Name = "acquisitionLabel";
			this.acquisitionLabel.Size = new System.Drawing.Size (184, 14);
			this.acquisitionLabel.TabIndex = 0;
			this.acquisitionLabel.Text = "Instance Acquisition Mode:";
			// 
			// acquisitionComboBox
			// 
			this.acquisitionComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.acquisitionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.acquisitionComboBox.FormattingEnabled = true;
			this.acquisitionComboBox.Location = new System.Drawing.Point (6, 27);
			this.acquisitionComboBox.Name = "acquisitionComboBox";
			this.acquisitionComboBox.Size = new System.Drawing.Size (600, 21);
			this.acquisitionComboBox.TabIndex = 1;
			this.acquisitionComboBox.SelectedIndexChanged += new System.EventHandler (this.OnAcquisitionComboBoxSelectedIndexChanged);
			// 
			// fieldNameLabel
			// 
			this.fieldNameLabel.AutoSize = true;
			this.fieldNameLabel.Font = new System.Drawing.Font ("Verdana", 9F, System.Drawing.FontStyle.Bold);
			this.fieldNameLabel.Location = new System.Drawing.Point (3, 61);
			this.fieldNameLabel.Name = "fieldNameLabel";
			this.fieldNameLabel.Size = new System.Drawing.Size (86, 14);
			this.fieldNameLabel.TabIndex = 2;
			this.fieldNameLabel.Text = "Field Name:";
			// 
			// methodsLabel
			// 
			this.methodsLabel.AutoSize = true;
			this.methodsLabel.Font = new System.Drawing.Font ("Verdana", 9F, System.Drawing.FontStyle.Bold);
			this.methodsLabel.Location = new System.Drawing.Point (3, 112);
			this.methodsLabel.Name = "methodsLabel";
			this.methodsLabel.Size = new System.Drawing.Size (131, 14);
			this.methodsLabel.TabIndex = 4;
			this.methodsLabel.Text = "Wrapped Methods:";
			// 
			// methodsListView
			// 
			this.methodsListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.methodsListView.CheckBoxes = true;
			this.methodsListView.Columns.AddRange (new System.Windows.Forms.ColumnHeader[] {
            this.methodColumnHeader,
            this.accessibilityColumnHeader,
            this.virtualColumnHeader,
            this.interfaceColumnHeader});
			this.methodsListView.FullRowSelect = true;
			this.methodsListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.methodsListView.Location = new System.Drawing.Point (6, 129);
			this.methodsListView.Name = "methodsListView";
			this.methodsListView.Size = new System.Drawing.Size (600, 154);
			this.methodsListView.SmallImageList = this.imageList;
			this.methodsListView.TabIndex = 5;
			this.methodsListView.UseCompatibleStateImageBehavior = false;
			this.methodsListView.View = System.Windows.Forms.View.Details;
			this.methodsListView.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler (this.OnMethodsListViewItemChecked);
			// 
			// methodColumnHeader
			// 
			this.methodColumnHeader.Text = "Method";
			this.methodColumnHeader.Width = 341;
			// 
			// accessibilityColumnHeader
			// 
			this.accessibilityColumnHeader.Text = "Accessibility";
			this.accessibilityColumnHeader.Width = 78;
			// 
			// virtualColumnHeader
			// 
			this.virtualColumnHeader.Text = "Virtual";
			// 
			// interfaceColumnHeader
			// 
			this.interfaceColumnHeader.Text = "Interface";
			this.interfaceColumnHeader.Width = 77;
			// 
			// imageList
			// 
			this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject ("imageList.ImageStream")));
			this.imageList.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList.Images.SetKeyName (0, "Method.png");
			this.imageList.Images.SetKeyName (1, "Property.png");
			this.imageList.Images.SetKeyName (2, "Event.png");
			// 
			// propertiesListView
			// 
			this.propertiesListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.propertiesListView.CheckBoxes = true;
			this.propertiesListView.Columns.AddRange (new System.Windows.Forms.ColumnHeader[] {
            this.propertyColumnHeader,
            this.getColumnHeader,
            this.setColumnHeader,
            this.propertyAccessibilityColumnHeader,
            this.propertyVirtualColumnHeader,
            this.interfacePropertyColumnHeader});
			this.propertiesListView.FullRowSelect = true;
			this.propertiesListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.propertiesListView.Location = new System.Drawing.Point (6, 317);
			this.propertiesListView.Name = "propertiesListView";
			this.propertiesListView.Size = new System.Drawing.Size (600, 154);
			this.propertiesListView.SmallImageList = this.imageList;
			this.propertiesListView.TabIndex = 7;
			this.propertiesListView.UseCompatibleStateImageBehavior = false;
			this.propertiesListView.View = System.Windows.Forms.View.Details;
			this.propertiesListView.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler (this.OnPropertiesListViewItemChecked);
			// 
			// propertyColumnHeader
			// 
			this.propertyColumnHeader.Text = "Property";
			this.propertyColumnHeader.Width = 220;
			// 
			// getColumnHeader
			// 
			this.getColumnHeader.Text = "Get";
			// 
			// setColumnHeader
			// 
			this.setColumnHeader.Text = "Set";
			// 
			// propertyAccessibilityColumnHeader
			// 
			this.propertyAccessibilityColumnHeader.Text = "Accessibility";
			this.propertyAccessibilityColumnHeader.Width = 78;
			// 
			// propertyVirtualColumnHeader
			// 
			this.propertyVirtualColumnHeader.Text = "Virtual";
			// 
			// interfacePropertyColumnHeader
			// 
			this.interfacePropertyColumnHeader.Text = "Interface";
			this.interfacePropertyColumnHeader.Width = 77;
			// 
			// propertiesLabel
			// 
			this.propertiesLabel.AutoSize = true;
			this.propertiesLabel.Font = new System.Drawing.Font ("Verdana", 9F, System.Drawing.FontStyle.Bold);
			this.propertiesLabel.Location = new System.Drawing.Point (3, 300);
			this.propertiesLabel.Name = "propertiesLabel";
			this.propertiesLabel.Size = new System.Drawing.Size (145, 14);
			this.propertiesLabel.TabIndex = 6;
			this.propertiesLabel.Text = "Wrapped Properties:";
			// 
			// eventsListView
			// 
			this.eventsListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.eventsListView.CheckBoxes = true;
			this.eventsListView.Columns.AddRange (new System.Windows.Forms.ColumnHeader[] {
            this.eventColumnHeader,
            this.eventAccessibilityColumnHeader,
            this.eventVirtualColumnHeader,
            this.eventInterfaceColumnHeader});
			this.eventsListView.FullRowSelect = true;
			this.eventsListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.eventsListView.Location = new System.Drawing.Point (6, 504);
			this.eventsListView.Name = "eventsListView";
			this.eventsListView.Size = new System.Drawing.Size (600, 154);
			this.eventsListView.SmallImageList = this.imageList;
			this.eventsListView.TabIndex = 9;
			this.eventsListView.UseCompatibleStateImageBehavior = false;
			this.eventsListView.View = System.Windows.Forms.View.Details;
			this.eventsListView.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler (this.OnEventsListViewItemChecked);
			// 
			// eventColumnHeader
			// 
			this.eventColumnHeader.Text = "Property";
			this.eventColumnHeader.Width = 341;
			// 
			// eventAccessibilityColumnHeader
			// 
			this.eventAccessibilityColumnHeader.Text = "Accessibility";
			this.eventAccessibilityColumnHeader.Width = 78;
			// 
			// eventVirtualColumnHeader
			// 
			this.eventVirtualColumnHeader.Text = "Virtual";
			// 
			// eventInterfaceColumnHeader
			// 
			this.eventInterfaceColumnHeader.Text = "Interface";
			this.eventInterfaceColumnHeader.Width = 77;
			// 
			// eventsLabel
			// 
			this.eventsLabel.AutoSize = true;
			this.eventsLabel.Font = new System.Drawing.Font ("Verdana", 9F, System.Drawing.FontStyle.Bold);
			this.eventsLabel.Location = new System.Drawing.Point (3, 487);
			this.eventsLabel.Name = "eventsLabel";
			this.eventsLabel.Size = new System.Drawing.Size (120, 14);
			this.eventsLabel.TabIndex = 8;
			this.eventsLabel.Text = "Wrapped Events:";
			// 
			// fieldNameTextBox
			// 
			this.fieldNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.fieldNameTextBox.BackColor = System.Drawing.SystemColors.Info;
			this.fieldNameTextBox.Location = new System.Drawing.Point (6, 79);
			this.fieldNameTextBox.Name = "fieldNameTextBox";
			this.fieldNameTextBox.Size = new System.Drawing.Size (418, 20);
			this.fieldNameTextBox.TabIndex = 10;
			this.fieldNameTextBox.Leave += new System.EventHandler (this.OnFieldNameTextBoxLeave);
			this.fieldNameTextBox.TextChanged += new System.EventHandler (this.OnFieldNameTextBoxTextChanged);
			// 
			// prefixCheckBox
			// 
			this.prefixCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.prefixCheckBox.AutoSize = true;
			this.prefixCheckBox.Location = new System.Drawing.Point (430, 81);
			this.prefixCheckBox.Name = "prefixCheckBox";
			this.prefixCheckBox.Size = new System.Drawing.Size (176, 17);
			this.prefixCheckBox.TabIndex = 11;
			this.prefixCheckBox.Text = "Prefix Members with Field Name";
			this.prefixCheckBox.UseVisualStyleBackColor = true;
			this.prefixCheckBox.CheckedChanged += new System.EventHandler (this.OnPrefixCheckBoxCheckedChanged);
			// 
			// WrappingOptions
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF (6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.Controls.Add (this.prefixCheckBox);
			this.Controls.Add (this.fieldNameTextBox);
			this.Controls.Add (this.eventsListView);
			this.Controls.Add (this.eventsLabel);
			this.Controls.Add (this.propertiesListView);
			this.Controls.Add (this.propertiesLabel);
			this.Controls.Add (this.methodsListView);
			this.Controls.Add (this.methodsLabel);
			this.Controls.Add (this.fieldNameLabel);
			this.Controls.Add (this.acquisitionComboBox);
			this.Controls.Add (this.acquisitionLabel);
			this.Name = "WrappingOptions";
			this.Size = new System.Drawing.Size (609, 673);
			this.ResumeLayout (false);
			this.PerformLayout ();

		}

		#endregion

		private System.Windows.Forms.Label acquisitionLabel;
		private System.Windows.Forms.ComboBox acquisitionComboBox;
		private System.Windows.Forms.Label fieldNameLabel;
		private System.Windows.Forms.Label methodsLabel;
		private System.Windows.Forms.ListView methodsListView;
		private System.Windows.Forms.ColumnHeader methodColumnHeader;
		private System.Windows.Forms.ImageList imageList;
		private System.Windows.Forms.ColumnHeader accessibilityColumnHeader;
		private System.Windows.Forms.ColumnHeader virtualColumnHeader;
		private System.Windows.Forms.ColumnHeader interfaceColumnHeader;
		private System.Windows.Forms.ListView propertiesListView;
		private System.Windows.Forms.ColumnHeader propertyColumnHeader;
		private System.Windows.Forms.ColumnHeader propertyAccessibilityColumnHeader;
		private System.Windows.Forms.ColumnHeader propertyVirtualColumnHeader;
		private System.Windows.Forms.ColumnHeader interfacePropertyColumnHeader;
		private System.Windows.Forms.Label propertiesLabel;
		private System.Windows.Forms.ColumnHeader getColumnHeader;
		private System.Windows.Forms.ColumnHeader setColumnHeader;
		private System.Windows.Forms.ListView eventsListView;
		private System.Windows.Forms.ColumnHeader eventColumnHeader;
		private System.Windows.Forms.ColumnHeader eventAccessibilityColumnHeader;
		private System.Windows.Forms.ColumnHeader eventVirtualColumnHeader;
		private System.Windows.Forms.ColumnHeader eventInterfaceColumnHeader;
		private System.Windows.Forms.Label eventsLabel;
		private System.Windows.Forms.TextBox fieldNameTextBox;
		private System.Windows.Forms.CheckBox prefixCheckBox;
	}
}
