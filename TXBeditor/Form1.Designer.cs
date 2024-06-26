﻿namespace TXBeditor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ListViewItem listViewItem11 = new ListViewItem(new string[] { "Width", "N/A" }, -1);
            ListViewItem listViewItem12 = new ListViewItem(new string[] { "Height", "N/A" }, -1);
            ListViewItem listViewItem13 = new ListViewItem(new string[] { "Byte Alignment", "N/A" }, -1);
            ListViewItem listViewItem14 = new ListViewItem(new string[] { "Bit Depth", "N/A" }, -1);
            ListViewItem listViewItem15 = new ListViewItem(new string[] { "Bytes Per Color", "N/A" }, -1);
            ImageListView = new ListView();
            image_index = new ColumnHeader();
            image_id = new ColumnHeader();
            TIM2PictureBox = new PictureBox();
            label1 = new Label();
            CurrImgIDField = new NumericUpDown();
            ImageListPushUp = new Button();
            ImageListPushDown = new Button();
            ImageListAdd = new Button();
            ImageListRemove = new Button();
            GroupBoxTXB = new GroupBox();
            GroupBoxTIM2 = new GroupBox();
            TIM2DataListView = new ListView();
            Property = new ColumnHeader();
            Value = new ColumnHeader();
            toolStrip1 = new ToolStrip();
            StripFile = new ToolStripDropDownButton();
            StripFileOpen = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            StripFileSave = new ToolStripMenuItem();
            StripFileSaveAs = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            StripFileQuit = new ToolStripMenuItem();
            StripEdit = new ToolStripDropDownButton();
            StripEditExport = new ToolStripMenuItem();
            StripEditImport = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            StripEditExportAll = new ToolStripMenuItem();
            StripEditImportAll = new ToolStripMenuItem();
            StripHelp = new ToolStripDropDownButton();
            StripHelpImgLib = new ToolStripMenuItem();
            toolTip1 = new ToolTip(components);
            GroupBoxImageList = new GroupBox();
            GroupBoxView = new GroupBox();
            ViewZoomReset = new Button();
            ViewZoomSubs = new Button();
            ViewZoomAdd = new Button();
            BGColorButton = new Button();
            StripBGContextMenu = new ContextMenuStrip(components);
            BGColorStripDefault = new ToolStripMenuItem();
            BGColorStripCustom = new ToolStripMenuItem();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)TIM2PictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CurrImgIDField).BeginInit();
            GroupBoxTXB.SuspendLayout();
            GroupBoxTIM2.SuspendLayout();
            toolStrip1.SuspendLayout();
            GroupBoxImageList.SuspendLayout();
            GroupBoxView.SuspendLayout();
            StripBGContextMenu.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // ImageListView
            // 
            ImageListView.AllowColumnReorder = true;
            ImageListView.Columns.AddRange(new ColumnHeader[] { image_index, image_id });
            ImageListView.FullRowSelect = true;
            ImageListView.GridLines = true;
            ImageListView.Location = new Point(6, 14);
            ImageListView.MultiSelect = false;
            ImageListView.Name = "ImageListView";
            ImageListView.Size = new Size(180, 237);
            ImageListView.TabIndex = 1;
            ImageListView.UseCompatibleStateImageBehavior = false;
            ImageListView.View = View.Details;
            ImageListView.ItemSelectionChanged += OnImageItemSelection;
            // 
            // image_index
            // 
            image_index.Text = "Index";
            image_index.Width = 88;
            // 
            // image_id
            // 
            image_id.Text = "Load ID";
            image_id.Width = 88;
            // 
            // TIM2PictureBox
            // 
            TIM2PictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TIM2PictureBox.BorderStyle = BorderStyle.Fixed3D;
            TIM2PictureBox.Location = new Point(2, 2);
            TIM2PictureBox.Name = "TIM2PictureBox";
            TIM2PictureBox.Size = new Size(514, 514);
            TIM2PictureBox.TabIndex = 3;
            TIM2PictureBox.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 24);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 6;
            label1.Text = "Load ID";
            // 
            // CurrImgIDField
            // 
            CurrImgIDField.Location = new Point(71, 22);
            CurrImgIDField.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            CurrImgIDField.Minimum = new decimal(new int[] { int.MinValue, 0, 0, int.MinValue });
            CurrImgIDField.Name = "CurrImgIDField";
            CurrImgIDField.Size = new Size(147, 23);
            CurrImgIDField.TabIndex = 8;
            CurrImgIDField.ValueChanged += OnCurrentImageIDChanged;
            // 
            // ImageListPushUp
            // 
            ImageListPushUp.Image = Properties.Resources.arrow_up;
            ImageListPushUp.Location = new Point(192, 145);
            ImageListPushUp.Name = "ImageListPushUp";
            ImageListPushUp.Size = new Size(26, 50);
            ImageListPushUp.TabIndex = 9;
            toolTip1.SetToolTip(ImageListPushUp, "Move the currently selected texture up");
            ImageListPushUp.UseVisualStyleBackColor = true;
            ImageListPushUp.Click += ImageListPushedUp;
            // 
            // ImageListPushDown
            // 
            ImageListPushDown.Image = Properties.Resources.arrow_down;
            ImageListPushDown.Location = new Point(192, 201);
            ImageListPushDown.Name = "ImageListPushDown";
            ImageListPushDown.Size = new Size(26, 50);
            ImageListPushDown.TabIndex = 10;
            toolTip1.SetToolTip(ImageListPushDown, "Move the currently selected texture down");
            ImageListPushDown.UseVisualStyleBackColor = true;
            ImageListPushDown.Click += ImageListPushedDown;
            // 
            // ImageListAdd
            // 
            ImageListAdd.Image = Properties.Resources.image_add;
            ImageListAdd.Location = new Point(192, 14);
            ImageListAdd.Name = "ImageListAdd";
            ImageListAdd.Size = new Size(26, 50);
            ImageListAdd.TabIndex = 13;
            toolTip1.SetToolTip(ImageListAdd, "Add a new TIM2 (.tm2) texture to the TXB image list");
            ImageListAdd.UseVisualStyleBackColor = true;
            ImageListAdd.Click += OnImageListAdd;
            // 
            // ImageListRemove
            // 
            ImageListRemove.Image = Properties.Resources.image_delete;
            ImageListRemove.Location = new Point(192, 70);
            ImageListRemove.Name = "ImageListRemove";
            ImageListRemove.Size = new Size(26, 50);
            ImageListRemove.TabIndex = 14;
            ImageListRemove.Text = "-";
            toolTip1.SetToolTip(ImageListRemove, "Remove the currently selected texture from the image list");
            ImageListRemove.UseVisualStyleBackColor = true;
            ImageListRemove.Click += OnImageListRemoved;
            // 
            // GroupBoxTXB
            // 
            GroupBoxTXB.Controls.Add(CurrImgIDField);
            GroupBoxTXB.Controls.Add(label1);
            GroupBoxTXB.Enabled = false;
            GroupBoxTXB.Location = new Point(12, 284);
            GroupBoxTXB.Name = "GroupBoxTXB";
            GroupBoxTXB.Size = new Size(224, 51);
            GroupBoxTXB.TabIndex = 15;
            GroupBoxTXB.TabStop = false;
            GroupBoxTXB.Text = "TXB Specific";
            // 
            // GroupBoxTIM2
            // 
            GroupBoxTIM2.Controls.Add(TIM2DataListView);
            GroupBoxTIM2.Enabled = false;
            GroupBoxTIM2.Location = new Point(12, 347);
            GroupBoxTIM2.Name = "GroupBoxTIM2";
            GroupBoxTIM2.Size = new Size(224, 134);
            GroupBoxTIM2.TabIndex = 16;
            GroupBoxTIM2.TabStop = false;
            GroupBoxTIM2.Text = "TIM2 Specific";
            // 
            // TIM2DataListView
            // 
            TIM2DataListView.Columns.AddRange(new ColumnHeader[] { Property, Value });
            TIM2DataListView.Enabled = false;
            TIM2DataListView.FullRowSelect = true;
            TIM2DataListView.GridLines = true;
            TIM2DataListView.HeaderStyle = ColumnHeaderStyle.None;
            TIM2DataListView.Items.AddRange(new ListViewItem[] { listViewItem11, listViewItem12, listViewItem13, listViewItem14, listViewItem15 });
            TIM2DataListView.LabelWrap = false;
            TIM2DataListView.Location = new Point(8, 22);
            TIM2DataListView.MultiSelect = false;
            TIM2DataListView.Name = "TIM2DataListView";
            TIM2DataListView.Scrollable = false;
            TIM2DataListView.Size = new Size(210, 98);
            TIM2DataListView.TabIndex = 0;
            TIM2DataListView.UseCompatibleStateImageBehavior = false;
            TIM2DataListView.View = View.Details;
            // 
            // Property
            // 
            Property.Text = "ColumnaHeader";
            Property.Width = 128;
            // 
            // Value
            // 
            Value.Width = 93;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { StripFile, StripEdit, StripHelp });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(772, 25);
            toolStrip1.TabIndex = 17;
            toolStrip1.Text = "toolStrip1";
            // 
            // StripFile
            // 
            StripFile.AutoToolTip = false;
            StripFile.DropDownItems.AddRange(new ToolStripItem[] { StripFileOpen, toolStripSeparator2, StripFileSave, StripFileSaveAs, toolStripSeparator1, StripFileQuit });
            StripFile.Image = Properties.Resources.folder_go;
            StripFile.ImageTransparentColor = Color.Magenta;
            StripFile.Name = "StripFile";
            StripFile.Size = new Size(54, 22);
            StripFile.Text = "File";
            // 
            // StripFileOpen
            // 
            StripFileOpen.Image = Properties.Resources.page_go;
            StripFileOpen.Name = "StripFileOpen";
            StripFileOpen.Size = new Size(180, 22);
            StripFileOpen.Text = "Open...";
            StripFileOpen.Click += StripFileOpen_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(177, 6);
            // 
            // StripFileSave
            // 
            StripFileSave.Enabled = false;
            StripFileSave.Image = Properties.Resources.page_save;
            StripFileSave.Name = "StripFileSave";
            StripFileSave.Size = new Size(180, 22);
            StripFileSave.Text = "Save";
            StripFileSave.Click += StripFileSave_Click;
            // 
            // StripFileSaveAs
            // 
            StripFileSaveAs.Enabled = false;
            StripFileSaveAs.Name = "StripFileSaveAs";
            StripFileSaveAs.Size = new Size(180, 22);
            StripFileSaveAs.Text = "Save as...";
            StripFileSaveAs.Click += StripFileSaveAs_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(177, 6);
            // 
            // StripFileQuit
            // 
            StripFileQuit.Image = Properties.Resources.cancel;
            StripFileQuit.Name = "StripFileQuit";
            StripFileQuit.Size = new Size(180, 22);
            StripFileQuit.Text = "Quit";
            StripFileQuit.Click += StripFileQuit_Click;
            // 
            // StripEdit
            // 
            StripEdit.AutoToolTip = false;
            StripEdit.DropDownItems.AddRange(new ToolStripItem[] { StripEditExport, StripEditImport, toolStripSeparator3, StripEditExportAll, StripEditImportAll });
            StripEdit.Image = Properties.Resources.picture_edit;
            StripEdit.ImageTransparentColor = Color.Magenta;
            StripEdit.Name = "StripEdit";
            StripEdit.Size = new Size(56, 22);
            StripEdit.Text = "Edit";
            // 
            // StripEditExport
            // 
            StripEditExport.Enabled = false;
            StripEditExport.Image = Properties.Resources.image;
            StripEditExport.Name = "StripEditExport";
            StripEditExport.Size = new Size(180, 22);
            StripEditExport.Text = "Export to PNG";
            StripEditExport.Click += StripEditExport_Click;
            // 
            // StripEditImport
            // 
            StripEditImport.Enabled = false;
            StripEditImport.Image = Properties.Resources.image_edit;
            StripEditImport.Name = "StripEditImport";
            StripEditImport.Size = new Size(180, 22);
            StripEditImport.Text = "Import from PNG";
            StripEditImport.Click += StripEditImport_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(177, 6);
            // 
            // StripEditExportAll
            // 
            StripEditExportAll.Enabled = false;
            StripEditExportAll.Image = Properties.Resources.folder_picture;
            StripEditExportAll.Name = "StripEditExportAll";
            StripEditExportAll.Size = new Size(180, 22);
            StripEditExportAll.Text = "Batch Export";
            StripEditExportAll.Click += StripEditExportAll_Click;
            // 
            // StripEditImportAll
            // 
            StripEditImportAll.Enabled = false;
            StripEditImportAll.Image = Properties.Resources.folder_magnify;
            StripEditImportAll.Name = "StripEditImportAll";
            StripEditImportAll.Size = new Size(180, 22);
            StripEditImportAll.Text = "Batch Import";
            StripEditImportAll.Click += EditStripImportAll_Click;
            // 
            // StripHelp
            // 
            StripHelp.AutoToolTip = false;
            StripHelp.DropDownItems.AddRange(new ToolStripItem[] { StripHelpImgLib });
            StripHelp.Image = Properties.Resources.information;
            StripHelp.ImageTransparentColor = Color.Magenta;
            StripHelp.Name = "StripHelp";
            StripHelp.Size = new Size(61, 22);
            StripHelp.Text = "Help";
            // 
            // StripHelpImgLib
            // 
            StripHelpImgLib.Name = "StripHelpImgLib";
            StripHelpImgLib.Size = new Size(180, 22);
            StripHelpImgLib.Text = "About ImgLib";
            StripHelpImgLib.Click += StripHelpImgLib_Click;
            // 
            // GroupBoxImageList
            // 
            GroupBoxImageList.Controls.Add(ImageListView);
            GroupBoxImageList.Controls.Add(ImageListAdd);
            GroupBoxImageList.Controls.Add(ImageListPushDown);
            GroupBoxImageList.Controls.Add(ImageListRemove);
            GroupBoxImageList.Controls.Add(ImageListPushUp);
            GroupBoxImageList.Enabled = false;
            GroupBoxImageList.Location = new Point(12, 21);
            GroupBoxImageList.Name = "GroupBoxImageList";
            GroupBoxImageList.Size = new Size(224, 257);
            GroupBoxImageList.TabIndex = 18;
            GroupBoxImageList.TabStop = false;
            // 
            // GroupBoxView
            // 
            GroupBoxView.Controls.Add(ViewZoomReset);
            GroupBoxView.Controls.Add(ViewZoomSubs);
            GroupBoxView.Controls.Add(ViewZoomAdd);
            GroupBoxView.Controls.Add(BGColorButton);
            GroupBoxView.Enabled = false;
            GroupBoxView.Location = new Point(14, 487);
            GroupBoxView.Name = "GroupBoxView";
            GroupBoxView.Size = new Size(224, 57);
            GroupBoxView.TabIndex = 19;
            GroupBoxView.TabStop = false;
            GroupBoxView.Text = "View";
            // 
            // ViewZoomReset
            // 
            ViewZoomReset.Image = Properties.Resources.zoom;
            ViewZoomReset.Location = new Point(164, 22);
            ViewZoomReset.Name = "ViewZoomReset";
            ViewZoomReset.Size = new Size(26, 26);
            ViewZoomReset.TabIndex = 3;
            ViewZoomReset.UseVisualStyleBackColor = true;
            ViewZoomReset.Click += ViewZoomReset_Click;
            // 
            // ViewZoomSubs
            // 
            ViewZoomSubs.Image = Properties.Resources.zoom_out;
            ViewZoomSubs.Location = new Point(138, 22);
            ViewZoomSubs.Name = "ViewZoomSubs";
            ViewZoomSubs.Size = new Size(26, 26);
            ViewZoomSubs.TabIndex = 2;
            ViewZoomSubs.UseVisualStyleBackColor = true;
            ViewZoomSubs.Click += ViewZoomSubs_Click;
            // 
            // ViewZoomAdd
            // 
            ViewZoomAdd.Image = Properties.Resources.zoom_in;
            ViewZoomAdd.Location = new Point(190, 22);
            ViewZoomAdd.Name = "ViewZoomAdd";
            ViewZoomAdd.Size = new Size(26, 26);
            ViewZoomAdd.TabIndex = 1;
            ViewZoomAdd.UseVisualStyleBackColor = true;
            ViewZoomAdd.Click += ViewZoomAdd_Click;
            // 
            // BGColorButton
            // 
            BGColorButton.Location = new Point(6, 22);
            BGColorButton.Name = "BGColorButton";
            BGColorButton.Size = new Size(117, 26);
            BGColorButton.TabIndex = 0;
            BGColorButton.Text = "Background Color";
            BGColorButton.UseVisualStyleBackColor = true;
            BGColorButton.Click += BGColorButton_Click;
            // 
            // StripBGContextMenu
            // 
            StripBGContextMenu.Items.AddRange(new ToolStripItem[] { BGColorStripDefault, BGColorStripCustom });
            StripBGContextMenu.Name = "StripBGContextMenu";
            StripBGContextMenu.Size = new Size(145, 48);
            // 
            // BGColorStripDefault
            // 
            BGColorStripDefault.Image = Properties.Resources.arrow_undo;
            BGColorStripDefault.Name = "BGColorStripDefault";
            BGColorStripDefault.Size = new Size(144, 22);
            BGColorStripDefault.Text = "Default Color";
            BGColorStripDefault.Click += BGColorStripDefault_Click;
            // 
            // BGColorStripCustom
            // 
            BGColorStripCustom.Image = Properties.Resources.color_swatch;
            BGColorStripCustom.Name = "BGColorStripCustom";
            BGColorStripCustom.Size = new Size(144, 22);
            BGColorStripCustom.Text = "Custom...";
            BGColorStripCustom.Click += BGColorStripCustom_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(TIM2PictureBox);
            panel1.Location = new Point(242, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(518, 518);
            panel1.TabIndex = 20;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(772, 557);
            Controls.Add(panel1);
            Controls.Add(GroupBoxView);
            Controls.Add(toolStrip1);
            Controls.Add(GroupBoxImageList);
            Controls.Add(GroupBoxTIM2);
            Controls.Add(GroupBoxTXB);
            MaximizeBox = false;
            Name = "Form1";
            Text = " TXB Editor";
            ((System.ComponentModel.ISupportInitialize)TIM2PictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)CurrImgIDField).EndInit();
            GroupBoxTXB.ResumeLayout(false);
            GroupBoxTXB.PerformLayout();
            GroupBoxTIM2.ResumeLayout(false);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            GroupBoxImageList.ResumeLayout(false);
            GroupBoxView.ResumeLayout(false);
            StripBGContextMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListView ImageListView;
        private PictureBox TIM2PictureBox;
        private Label label1;
        private ColumnHeader image_index;
        private ColumnHeader image_id;
        private NumericUpDown CurrImgIDField;
        private Button ImageListPushUp;
        private Button ImageListPushDown;
        private Button ImageListAdd;
        private Button ImageListRemove;
        private GroupBox GroupBoxTXB;
        private GroupBox GroupBoxTIM2;
        private ToolStrip toolStrip1;
        private ToolStripDropDownButton StripFile;
        private ToolStripMenuItem StripFileOpen;
        private ToolStripDropDownButton StripEdit;
        private ToolStripDropDownButton StripHelp;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem StripFileSave;
        private ToolStripMenuItem StripFileSaveAs;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem StripFileQuit;
        private ToolStripMenuItem StripEditExport;
        private ToolStripMenuItem StripEditImport;
        private ToolStripMenuItem StripHelpImgLib;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem StripEditExportAll;
        private ToolStripMenuItem StripEditImportAll;
        private ListView TIM2DataListView;
        private ColumnHeader Property;
        private ColumnHeader Value;
        private ToolTip toolTip1;
        private GroupBox GroupBoxImageList;
        private GroupBox GroupBoxView;
        private ContextMenuStrip StripBGContextMenu;
        private Button BGColorButton;
        private ToolStripMenuItem BGColorStripDefault;
        private ToolStripMenuItem BGColorStripCustom;
        private Button ViewZoomSubs;
        private Button ViewZoomAdd;
        private Button ViewZoomReset;
        private Panel panel1;
    }
}
