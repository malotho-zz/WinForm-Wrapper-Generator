namespace WrapperGenerator.UI
{
	partial class View
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent ()
		{
			this.components = new System.ComponentModel.Container ();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager (typeof (View));
			this.sandDockManager = new TD.SandDock.SandDockManager ();
			this.leftSandDock = new TD.SandDock.DockContainer ();
			this.typesDockControl = new TD.SandDock.DockControl ();
			this.rightSandDock = new TD.SandDock.DockContainer ();
			this.wrapperPropertiesDockControl = new TD.SandDock.DockControl ();
			this.wrapperClassPropertiesPanel = new System.Windows.Forms.Panel ();
			this.sealedCheckBox = new System.Windows.Forms.CheckBox ();
			this.partialCheckBox = new System.Windows.Forms.CheckBox ();
			this.classOptionsLabel = new System.Windows.Forms.Label ();
			this.classNameLabel = new System.Windows.Forms.Label ();
			this.namespaceTextBox = new System.Windows.Forms.TextBox ();
			this.classNameTextBox = new System.Windows.Forms.TextBox ();
			this.namespaceLabel = new System.Windows.Forms.Label ();
			this.memberPropertiesDockControl = new TD.SandDock.DockControl ();
			this.propertyGrid = new System.Windows.Forms.PropertyGrid ();
			this.bottomSandDock = new TD.SandDock.DockContainer ();
			this.topSandDock = new TD.SandDock.DockContainer ();
			this.documentContainer = new TD.SandDock.DocumentContainer ();
			this.toolStrip = new System.Windows.Forms.ToolStrip ();
			this.addAssemblyToolStripButton = new System.Windows.Forms.ToolStripButton ();
			this.generateToolStripButton = new System.Windows.Forms.ToolStripButton ();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator ();
			this.languageToolStripComboBox = new System.Windows.Forms.ToolStripComboBox ();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog ();
			this.assemblyBrowser = new WrapperGenerator.UI.AssemblyBrowser ();
			this.leftSandDock.SuspendLayout ();
			this.typesDockControl.SuspendLayout ();
			this.rightSandDock.SuspendLayout ();
			this.wrapperPropertiesDockControl.SuspendLayout ();
			this.wrapperClassPropertiesPanel.SuspendLayout ();
			this.memberPropertiesDockControl.SuspendLayout ();
			this.toolStrip.SuspendLayout ();
			this.SuspendLayout ();
			// 
			// sandDockManager
			// 
			this.sandDockManager.DockingManager = TD.SandDock.DockingManager.Whidbey;
			this.sandDockManager.OwnerForm = this;
			// 
			// leftSandDock
			// 
			this.leftSandDock.Controls.Add (this.typesDockControl);
			this.leftSandDock.Dock = System.Windows.Forms.DockStyle.Left;
			this.leftSandDock.Guid = new System.Guid ("cdb069a0-40e6-45aa-a48b-2d76d7c62aef");
			this.leftSandDock.LayoutSystem = new TD.SandDock.SplitLayoutSystem (250, 400, System.Windows.Forms.Orientation.Horizontal, new TD.SandDock.LayoutSystemBase[] {
            ((TD.SandDock.LayoutSystemBase)(new TD.SandDock.ControlLayoutSystem(250, 489, new TD.SandDock.DockControl[] {
                        this.typesDockControl}, this.typesDockControl)))});
			this.leftSandDock.Location = new System.Drawing.Point (0, 25);
			this.leftSandDock.Manager = this.sandDockManager;
			this.leftSandDock.Name = "leftSandDock";
			this.leftSandDock.Size = new System.Drawing.Size (254, 489);
			this.leftSandDock.TabIndex = 1;
			// 
			// typesDockControl
			// 
			this.typesDockControl.Closable = false;
			this.typesDockControl.Controls.Add (this.assemblyBrowser);
			this.typesDockControl.Guid = new System.Guid ("9dec5917-e63a-47bc-9e45-f45b87777d5e");
			this.typesDockControl.Location = new System.Drawing.Point (0, 18);
			this.typesDockControl.Name = "typesDockControl";
			this.typesDockControl.Size = new System.Drawing.Size (250, 448);
			this.typesDockControl.TabIndex = 1;
			this.typesDockControl.Text = "Types";
			// 
			// rightSandDock
			// 
			this.rightSandDock.Controls.Add (this.wrapperPropertiesDockControl);
			this.rightSandDock.Controls.Add (this.memberPropertiesDockControl);
			this.rightSandDock.Dock = System.Windows.Forms.DockStyle.Right;
			this.rightSandDock.Guid = new System.Guid ("187db238-ae5d-46ae-9743-2fdeaddce720");
			this.rightSandDock.LayoutSystem = new TD.SandDock.SplitLayoutSystem (250, 400, System.Windows.Forms.Orientation.Horizontal, new TD.SandDock.LayoutSystemBase[] {
            ((TD.SandDock.LayoutSystemBase)(new TD.SandDock.ControlLayoutSystem(250, 188, new TD.SandDock.DockControl[] {
                        this.wrapperPropertiesDockControl}, this.wrapperPropertiesDockControl))),
            ((TD.SandDock.LayoutSystemBase)(new TD.SandDock.ControlLayoutSystem(250, 296, new TD.SandDock.DockControl[] {
                        this.memberPropertiesDockControl}, this.memberPropertiesDockControl)))});
			this.rightSandDock.Location = new System.Drawing.Point (758, 25);
			this.rightSandDock.Manager = this.sandDockManager;
			this.rightSandDock.Name = "rightSandDock";
			this.rightSandDock.Size = new System.Drawing.Size (254, 489);
			this.rightSandDock.TabIndex = 2;
			// 
			// wrapperPropertiesDockControl
			// 
			this.wrapperPropertiesDockControl.Closable = false;
			this.wrapperPropertiesDockControl.Controls.Add (this.wrapperClassPropertiesPanel);
			this.wrapperPropertiesDockControl.Guid = new System.Guid ("4f56c065-823c-47dd-9dc4-dab5fe4a4f4c");
			this.wrapperPropertiesDockControl.Location = new System.Drawing.Point (4, 18);
			this.wrapperPropertiesDockControl.Name = "wrapperPropertiesDockControl";
			this.wrapperPropertiesDockControl.Size = new System.Drawing.Size (250, 147);
			this.wrapperPropertiesDockControl.TabIndex = 1;
			this.wrapperPropertiesDockControl.Text = "Wrapper Properties";
			// 
			// wrapperClassPropertiesPanel
			// 
			this.wrapperClassPropertiesPanel.BackColor = System.Drawing.SystemColors.Window;
			this.wrapperClassPropertiesPanel.Controls.Add (this.sealedCheckBox);
			this.wrapperClassPropertiesPanel.Controls.Add (this.partialCheckBox);
			this.wrapperClassPropertiesPanel.Controls.Add (this.classOptionsLabel);
			this.wrapperClassPropertiesPanel.Controls.Add (this.classNameLabel);
			this.wrapperClassPropertiesPanel.Controls.Add (this.namespaceTextBox);
			this.wrapperClassPropertiesPanel.Controls.Add (this.classNameTextBox);
			this.wrapperClassPropertiesPanel.Controls.Add (this.namespaceLabel);
			this.wrapperClassPropertiesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.wrapperClassPropertiesPanel.Location = new System.Drawing.Point (0, 0);
			this.wrapperClassPropertiesPanel.Name = "wrapperClassPropertiesPanel";
			this.wrapperClassPropertiesPanel.Size = new System.Drawing.Size (250, 147);
			this.wrapperClassPropertiesPanel.TabIndex = 11;
			// 
			// sealedCheckBox
			// 
			this.sealedCheckBox.AutoSize = true;
			this.sealedCheckBox.Location = new System.Drawing.Point (67, 100);
			this.sealedCheckBox.Name = "sealedCheckBox";
			this.sealedCheckBox.Size = new System.Drawing.Size (59, 17);
			this.sealedCheckBox.TabIndex = 12;
			this.sealedCheckBox.Text = "Sealed";
			this.sealedCheckBox.UseVisualStyleBackColor = true;
			this.sealedCheckBox.CheckedChanged += new System.EventHandler (this.OnSealedCheckBoxCheckedChanged);
			// 
			// partialCheckBox
			// 
			this.partialCheckBox.AutoSize = true;
			this.partialCheckBox.Location = new System.Drawing.Point (6, 101);
			this.partialCheckBox.Name = "partialCheckBox";
			this.partialCheckBox.Size = new System.Drawing.Size (55, 17);
			this.partialCheckBox.TabIndex = 11;
			this.partialCheckBox.Text = "Partial";
			this.partialCheckBox.UseVisualStyleBackColor = true;
			this.partialCheckBox.CheckedChanged += new System.EventHandler (this.OnPartialCheckBoxCheckedChanged);
			// 
			// classOptionsLabel
			// 
			this.classOptionsLabel.AutoSize = true;
			this.classOptionsLabel.Font = new System.Drawing.Font ("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.classOptionsLabel.Location = new System.Drawing.Point (3, 83);
			this.classOptionsLabel.Name = "classOptionsLabel";
			this.classOptionsLabel.Size = new System.Drawing.Size (102, 14);
			this.classOptionsLabel.TabIndex = 10;
			this.classOptionsLabel.Text = "Class Options:";
			// 
			// classNameLabel
			// 
			this.classNameLabel.AutoSize = true;
			this.classNameLabel.Font = new System.Drawing.Font ("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.classNameLabel.Location = new System.Drawing.Point (3, 43);
			this.classNameLabel.Name = "classNameLabel";
			this.classNameLabel.Size = new System.Drawing.Size (89, 14);
			this.classNameLabel.TabIndex = 9;
			this.classNameLabel.Text = "Class Name:";
			// 
			// namespaceTextBox
			// 
			this.namespaceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.namespaceTextBox.BackColor = System.Drawing.SystemColors.Info;
			this.namespaceTextBox.Location = new System.Drawing.Point (6, 20);
			this.namespaceTextBox.Name = "namespaceTextBox";
			this.namespaceTextBox.Size = new System.Drawing.Size (241, 20);
			this.namespaceTextBox.TabIndex = 6;
			this.namespaceTextBox.Text = "MyNamespace";
			this.namespaceTextBox.Leave += new System.EventHandler (this.OnNamespaceTextBoxLeave);
			this.namespaceTextBox.TextChanged += new System.EventHandler (this.OnNamespaceTextBoxTextChanged);
			// 
			// classNameTextBox
			// 
			this.classNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.classNameTextBox.BackColor = System.Drawing.SystemColors.Info;
			this.classNameTextBox.Location = new System.Drawing.Point (6, 60);
			this.classNameTextBox.Name = "classNameTextBox";
			this.classNameTextBox.Size = new System.Drawing.Size (241, 20);
			this.classNameTextBox.TabIndex = 8;
			this.classNameTextBox.Text = "MyWrapper";
			this.classNameTextBox.Leave += new System.EventHandler (this.OnClassNameTextBoxLeave);
			this.classNameTextBox.TextChanged += new System.EventHandler (this.OnClassNameTextBoxTextChanged);
			// 
			// namespaceLabel
			// 
			this.namespaceLabel.AutoSize = true;
			this.namespaceLabel.Font = new System.Drawing.Font ("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.namespaceLabel.Location = new System.Drawing.Point (3, 3);
			this.namespaceLabel.Name = "namespaceLabel";
			this.namespaceLabel.Size = new System.Drawing.Size (88, 14);
			this.namespaceLabel.TabIndex = 7;
			this.namespaceLabel.Text = "Namespace:";
			// 
			// memberPropertiesDockControl
			// 
			this.memberPropertiesDockControl.Closable = false;
			this.memberPropertiesDockControl.Controls.Add (this.propertyGrid);
			this.memberPropertiesDockControl.Guid = new System.Guid ("bd0c0c4f-be5f-4167-9f53-d7037239500f");
			this.memberPropertiesDockControl.Location = new System.Drawing.Point (4, 210);
			this.memberPropertiesDockControl.Name = "memberPropertiesDockControl";
			this.memberPropertiesDockControl.Size = new System.Drawing.Size (250, 256);
			this.memberPropertiesDockControl.TabIndex = 0;
			this.memberPropertiesDockControl.Text = "Member Properties";
			// 
			// propertyGrid
			// 
			this.propertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.propertyGrid.Location = new System.Drawing.Point (0, 0);
			this.propertyGrid.Name = "propertyGrid";
			this.propertyGrid.Size = new System.Drawing.Size (250, 256);
			this.propertyGrid.TabIndex = 0;
			// 
			// bottomSandDock
			// 
			this.bottomSandDock.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.bottomSandDock.Guid = new System.Guid ("17296cba-dba6-495a-8347-8f1d226b739b");
			this.bottomSandDock.LayoutSystem = new TD.SandDock.SplitLayoutSystem (250, 400);
			this.bottomSandDock.Location = new System.Drawing.Point (0, 514);
			this.bottomSandDock.Manager = this.sandDockManager;
			this.bottomSandDock.Name = "bottomSandDock";
			this.bottomSandDock.Size = new System.Drawing.Size (1012, 0);
			this.bottomSandDock.TabIndex = 3;
			// 
			// topSandDock
			// 
			this.topSandDock.Dock = System.Windows.Forms.DockStyle.Top;
			this.topSandDock.Guid = new System.Guid ("76b8fadd-9f84-4373-833b-7fd49a1434e6");
			this.topSandDock.LayoutSystem = new TD.SandDock.SplitLayoutSystem (250, 400);
			this.topSandDock.Location = new System.Drawing.Point (0, 25);
			this.topSandDock.Manager = this.sandDockManager;
			this.topSandDock.Name = "topSandDock";
			this.topSandDock.Size = new System.Drawing.Size (1012, 0);
			this.topSandDock.TabIndex = 4;
			// 
			// documentContainer
			// 
			this.documentContainer.Guid = new System.Guid ("aeeeb869-dcbb-4b4b-9899-48dd0e2845d2");
			this.documentContainer.LayoutSystem = new TD.SandDock.SplitLayoutSystem (250, 400);
			this.documentContainer.Location = new System.Drawing.Point (254, 25);
			this.documentContainer.Manager = null;
			this.documentContainer.Name = "documentContainer";
			this.documentContainer.Renderer = new TD.SandDock.Rendering.WhidbeyRenderer ();
			this.documentContainer.Size = new System.Drawing.Size (504, 489);
			this.documentContainer.TabIndex = 5;
			this.documentContainer.ActiveDocumentChanged += new TD.SandDock.ActiveDocumentEventHandler (this.OnDocumentContainerActiveDocumentChanged);
			this.documentContainer.ControlRemoved += new System.Windows.Forms.ControlEventHandler (this.OnDocumentContainerControlRemoved);
			this.documentContainer.ControlAdded += new System.Windows.Forms.ControlEventHandler (this.OnDocumentContainerControlAdded);
			// 
			// toolStrip
			// 
			this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip.Items.AddRange (new System.Windows.Forms.ToolStripItem[] {
            this.addAssemblyToolStripButton,
            this.generateToolStripButton,
            this.toolStripSeparator1,
            this.languageToolStripComboBox});
			this.toolStrip.Location = new System.Drawing.Point (0, 0);
			this.toolStrip.Name = "toolStrip";
			this.toolStrip.Size = new System.Drawing.Size (1012, 25);
			this.toolStrip.TabIndex = 6;
			// 
			// addAssemblyToolStripButton
			// 
			this.addAssemblyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.addAssemblyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject ("addAssemblyToolStripButton.Image")));
			this.addAssemblyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.addAssemblyToolStripButton.Name = "addAssemblyToolStripButton";
			this.addAssemblyToolStripButton.Size = new System.Drawing.Size (23, 22);
			this.addAssemblyToolStripButton.ToolTipText = "Add Assembly";
			this.addAssemblyToolStripButton.Click += new System.EventHandler (this.OnAddAssemblyToolStripButtonClick);
			// 
			// generateToolStripButton
			// 
			this.generateToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.generateToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject ("generateToolStripButton.Image")));
			this.generateToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.generateToolStripButton.Name = "generateToolStripButton";
			this.generateToolStripButton.Size = new System.Drawing.Size (23, 22);
			this.generateToolStripButton.ToolTipText = "Generate Wrapper Class";
			this.generateToolStripButton.Click += new System.EventHandler (this.OnGenerateToolStripButtonClick);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size (6, 25);
			// 
			// languageToolStripComboBox
			// 
			this.languageToolStripComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.languageToolStripComboBox.Items.AddRange (new object[] {
            "C#",
            "VB.NET"});
			this.languageToolStripComboBox.Name = "languageToolStripComboBox";
			this.languageToolStripComboBox.Size = new System.Drawing.Size (75, 25);
			// 
			// openFileDialog
			// 
			this.openFileDialog.Filter = "Assemblies|*.dll";
			this.openFileDialog.Multiselect = true;
			// 
			// assemblyBrowser
			// 
			this.assemblyBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
			this.assemblyBrowser.ImageIndex = 0;
			this.assemblyBrowser.Location = new System.Drawing.Point (0, 0);
			this.assemblyBrowser.Name = "assemblyBrowser";
			this.assemblyBrowser.SelectedImageIndex = 0;
			this.assemblyBrowser.ShowLines = false;
			this.assemblyBrowser.Size = new System.Drawing.Size (250, 448);
			this.assemblyBrowser.TabIndex = 6;
			this.assemblyBrowser.DoubleClick += new System.EventHandler (this.OnAssemblyBrowserDoubleClick);
			this.assemblyBrowser.KeyDown += new System.Windows.Forms.KeyEventHandler (this.OnAssemblyBrowserKeyDown);
			// 
			// View
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF (6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size (1012, 514);
			this.Controls.Add (this.documentContainer);
			this.Controls.Add (this.leftSandDock);
			this.Controls.Add (this.rightSandDock);
			this.Controls.Add (this.bottomSandDock);
			this.Controls.Add (this.topSandDock);
			this.Controls.Add (this.toolStrip);
			this.Name = "View";
			this.Text = ".NET Wrapper Class Generator";
			this.leftSandDock.ResumeLayout (false);
			this.typesDockControl.ResumeLayout (false);
			this.rightSandDock.ResumeLayout (false);
			this.wrapperPropertiesDockControl.ResumeLayout (false);
			this.wrapperClassPropertiesPanel.ResumeLayout (false);
			this.wrapperClassPropertiesPanel.PerformLayout ();
			this.memberPropertiesDockControl.ResumeLayout (false);
			this.toolStrip.ResumeLayout (false);
			this.toolStrip.PerformLayout ();
			this.ResumeLayout (false);
			this.PerformLayout ();

		}

		#endregion

		private TD.SandDock.SandDockManager sandDockManager;
		private TD.SandDock.DocumentContainer documentContainer;
		private TD.SandDock.DockContainer leftSandDock;
		private TD.SandDock.DockContainer rightSandDock;
		private TD.SandDock.DockContainer bottomSandDock;
		private TD.SandDock.DockContainer topSandDock;
		private AssemblyBrowser assemblyBrowser;
		private TD.SandDock.DockControl typesDockControl;
		private TD.SandDock.DockControl memberPropertiesDockControl;
		private System.Windows.Forms.ToolStrip toolStrip;
		private System.Windows.Forms.ToolStripButton addAssemblyToolStripButton;
		private System.Windows.Forms.ToolStripButton generateToolStripButton;
		private System.Windows.Forms.PropertyGrid propertyGrid;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private TD.SandDock.DockControl wrapperPropertiesDockControl;
		private System.Windows.Forms.Panel wrapperClassPropertiesPanel;
		private System.Windows.Forms.Label classNameLabel;
		private System.Windows.Forms.TextBox namespaceTextBox;
		private System.Windows.Forms.TextBox classNameTextBox;
		private System.Windows.Forms.Label namespaceLabel;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripComboBox languageToolStripComboBox;
		private System.Windows.Forms.Label classOptionsLabel;
		private System.Windows.Forms.CheckBox partialCheckBox;
		private System.Windows.Forms.CheckBox sealedCheckBox;
	}
}

