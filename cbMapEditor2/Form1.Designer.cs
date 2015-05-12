namespace cbMapEditor2
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tlgrid_Inform = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tl_width = new System.Windows.Forms.ToolStripLabel();
            this.cpWidth = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tl_height = new System.Windows.Forms.ToolStripLabel();
            this.cpHeight = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btGrid32 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btGrid16 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btGrid8 = new System.Windows.Forms.ToolStripButton();
            this.btnUndo = new System.Windows.Forms.ToolStripButton();
            this.btnRedo = new System.Windows.Forms.ToolStripButton();
            this.mainContainer = new System.Windows.Forms.SplitContainer();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.bt_Draw = new cbMapEditor2.Components.ToggleButton();
            this.bt_fill = new cbMapEditor2.Components.ToggleButton();
            this.bt_zoom = new cbMapEditor2.Components.ToggleButton();
            this.mpMap = new System.Windows.Forms.PictureBox();
            this.mpSprites = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusTileNumber = new System.Windows.Forms.ToolStripStatusLabel();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openTileSheetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openMapFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.openTilesheetFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.toolSelect = new cbMapEditor2.Components.ToggleButton();
            this.toolPaint = new cbMapEditor2.Components.ToggleButton();
            this.toolFill = new cbMapEditor2.Components.ToggleButton();
            this.recentMapsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.mainContainer.Panel1.SuspendLayout();
            this.mainContainer.Panel2.SuspendLayout();
            this.mainContainer.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mpMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mpSprites)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlgrid_Inform,
            this.toolStripSeparator2,
            this.tl_width,
            this.cpWidth,
            this.toolStripSeparator1,
            this.tl_height,
            this.cpHeight,
            this.toolStripSeparator3,
            this.btGrid32,
            this.toolStripSeparator4,
            this.btGrid16,
            this.toolStripSeparator5,
            this.btGrid8,
            this.btnUndo,
            this.btnRedo});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(819, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tlgrid_Inform
            // 
            this.tlgrid_Inform.Name = "tlgrid_Inform";
            this.tlgrid_Inform.Size = new System.Drawing.Size(81, 22);
            this.tlgrid_Inform.Text = "Grid Dimension:";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tl_width
            // 
            this.tl_width.Name = "tl_width";
            this.tl_width.Size = new System.Drawing.Size(35, 22);
            this.tl_width.Text = "Width";
            // 
            // cpWidth
            // 
            this.cpWidth.Name = "cpWidth";
            this.cpWidth.Size = new System.Drawing.Size(100, 25);
            this.cpWidth.Text = "320";
            this.cpWidth.TextChanged += new System.EventHandler(this.updateMapSize);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tl_height
            // 
            this.tl_height.Name = "tl_height";
            this.tl_height.Size = new System.Drawing.Size(42, 22);
            this.tl_height.Text = "Height:";
            // 
            // cpHeight
            // 
            this.cpHeight.Name = "cpHeight";
            this.cpHeight.Size = new System.Drawing.Size(100, 25);
            this.cpHeight.Text = "200";
            this.cpHeight.TextChanged += new System.EventHandler(this.updateMapSize);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btGrid32
            // 
            this.btGrid32.Checked = true;
            this.btGrid32.CheckOnClick = true;
            this.btGrid32.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btGrid32.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btGrid32.Image = ((System.Drawing.Image)(resources.GetObject("btGrid32.Image")));
            this.btGrid32.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btGrid32.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btGrid32.Name = "btGrid32";
            this.btGrid32.Size = new System.Drawing.Size(41, 22);
            this.btGrid32.Text = "32x32";
            this.btGrid32.Click += new System.EventHandler(this.btGrid32_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // btGrid16
            // 
            this.btGrid16.CheckOnClick = true;
            this.btGrid16.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btGrid16.Image = ((System.Drawing.Image)(resources.GetObject("btGrid16.Image")));
            this.btGrid16.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btGrid16.Name = "btGrid16";
            this.btGrid16.Size = new System.Drawing.Size(41, 22);
            this.btGrid16.Text = "16x16";
            this.btGrid16.Click += new System.EventHandler(this.btGrid16_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // btGrid8
            // 
            this.btGrid8.CheckOnClick = true;
            this.btGrid8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btGrid8.Image = ((System.Drawing.Image)(resources.GetObject("btGrid8.Image")));
            this.btGrid8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btGrid8.Name = "btGrid8";
            this.btGrid8.Size = new System.Drawing.Size(29, 22);
            this.btGrid8.Text = "8x8";
            this.btGrid8.Click += new System.EventHandler(this.btGrid8_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUndo.Enabled = false;
            this.btnUndo.Image = ((System.Drawing.Image)(resources.GetObject("btnUndo.Image")));
            this.btnUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(23, 22);
            this.btnUndo.Text = "Undo";
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnRedo
            // 
            this.btnRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRedo.Enabled = false;
            this.btnRedo.Image = ((System.Drawing.Image)(resources.GetObject("btnRedo.Image")));
            this.btnRedo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.Size = new System.Drawing.Size(23, 22);
            this.btnRedo.Text = "Redo";
            this.btnRedo.Click += new System.EventHandler(this.btnRedo_Click);
            // 
            // mainContainer
            // 
            this.mainContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.mainContainer.Location = new System.Drawing.Point(0, 49);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // mainContainer.Panel1
            // 
            this.mainContainer.Panel1.AutoScroll = true;
            this.mainContainer.Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.mainContainer.Panel1.Controls.Add(this.toolStrip2);
            this.mainContainer.Panel1.Controls.Add(this.mpMap);
            // 
            // mainContainer.Panel2
            // 
            this.mainContainer.Panel2.AutoScroll = true;
            this.mainContainer.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.mainContainer.Panel2.Controls.Add(this.mpSprites);
            this.mainContainer.Size = new System.Drawing.Size(819, 416);
            this.mainContainer.SplitterDistance = 250;
            this.mainContainer.TabIndex = 2;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bt_Draw,
            this.bt_fill,
            this.bt_zoom});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(819, 25);
            this.toolStrip2.TabIndex = 0;
            // 
            // bt_Draw
            // 
            this.bt_Draw.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bt_Draw.Image = global::cbMapEditor2.Properties.Resources.pencil_16;
            this.bt_Draw.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bt_Draw.ImgOnPressed = null;
            this.bt_Draw.ImgOnReleased = null;
            this.bt_Draw.Name = "bt_Draw";
            this.bt_Draw.Size = new System.Drawing.Size(23, 22);
            this.bt_Draw.Text = "Draw";
            // 
            // bt_fill
            // 
            this.bt_fill.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bt_fill.Image = global::cbMapEditor2.Properties.Resources.construction_bucket_icon;
            this.bt_fill.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bt_fill.ImgOnPressed = global::cbMapEditor2.Properties.Resources.bucketonPressed;
            this.bt_fill.ImgOnReleased = global::cbMapEditor2.Properties.Resources.construction_bucket_icon;
            this.bt_fill.Name = "bt_fill";
            this.bt_fill.Size = new System.Drawing.Size(23, 22);
            this.bt_fill.Text = "Fill";
            // 
            // bt_zoom
            // 
            this.bt_zoom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bt_zoom.Image = global::cbMapEditor2.Properties.Resources.search_16;
            this.bt_zoom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bt_zoom.ImgOnPressed = global::cbMapEditor2.Properties.Resources.search_16;
            this.bt_zoom.ImgOnReleased = null;
            this.bt_zoom.Name = "bt_zoom";
            this.bt_zoom.Size = new System.Drawing.Size(23, 22);
            this.bt_zoom.Text = "Zoom";
            // 
            // mpMap
            // 
            this.mpMap.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mpMap.Location = new System.Drawing.Point(3, 28);
            this.mpMap.Name = "mpMap";
            this.mpMap.Size = new System.Drawing.Size(320, 200);
            this.mpMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.mpMap.TabIndex = 1;
            this.mpMap.TabStop = false;
            // 
            // mpSprites
            // 
            this.mpSprites.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mpSprites.Location = new System.Drawing.Point(3, 3);
            this.mpSprites.Name = "mpSprites";
            this.mpSprites.Size = new System.Drawing.Size(100, 50);
            this.mpSprites.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.mpSprites.TabIndex = 0;
            this.mpSprites.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusTileNumber});
            this.statusStrip1.Location = new System.Drawing.Point(0, 468);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(819, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.Visible = false;
            // 
            // statusTileNumber
            // 
            this.statusTileNumber.Enabled = false;
            this.statusTileNumber.Name = "statusTileNumber";
            this.statusTileNumber.Size = new System.Drawing.Size(67, 17);
            this.statusTileNumber.Text = "Tile Number:";
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.assetsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(819, 24);
            this.menu.TabIndex = 4;
            this.menu.Text = "menu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMapToolStripMenuItem,
            this.recentMapsToolStripMenuItem,
            this.openMapToolStripMenuItem,
            this.closeMapToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newMapToolStripMenuItem
            // 
            this.newMapToolStripMenuItem.Image = global::cbMapEditor2.Properties.Resources.document_16;
            this.newMapToolStripMenuItem.Name = "newMapToolStripMenuItem";
            this.newMapToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newMapToolStripMenuItem.Text = "New Map";
            this.newMapToolStripMenuItem.Click += new System.EventHandler(this.newMapToolStripMenuItem_Click);
            // 
            // openMapToolStripMenuItem
            // 
            this.openMapToolStripMenuItem.Image = global::cbMapEditor2.Properties.Resources.folder_16;
            this.openMapToolStripMenuItem.Name = "openMapToolStripMenuItem";
            this.openMapToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openMapToolStripMenuItem.Text = "Open Map";
            this.openMapToolStripMenuItem.Click += new System.EventHandler(this.openMapToolStripMenuItem_Click);
            // 
            // closeMapToolStripMenuItem
            // 
            this.closeMapToolStripMenuItem.Image = global::cbMapEditor2.Properties.Resources.down_16;
            this.closeMapToolStripMenuItem.Name = "closeMapToolStripMenuItem";
            this.closeMapToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.closeMapToolStripMenuItem.Text = "Close Map";
            this.closeMapToolStripMenuItem.Click += new System.EventHandler(this.closeMapToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::cbMapEditor2.Properties.Resources.save_16;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save..";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // assetsToolStripMenuItem
            // 
            this.assetsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openTileSheetToolStripMenuItem});
            this.assetsToolStripMenuItem.Name = "assetsToolStripMenuItem";
            this.assetsToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.assetsToolStripMenuItem.Text = "Assets";
            // 
            // openTileSheetToolStripMenuItem
            // 
            this.openTileSheetToolStripMenuItem.Name = "openTileSheetToolStripMenuItem";
            this.openTileSheetToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.openTileSheetToolStripMenuItem.Text = "Open TileSheet";
            this.openTileSheetToolStripMenuItem.Click += new System.EventHandler(this.openTileSheetToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpMeToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // helpMeToolStripMenuItem
            // 
            this.helpMeToolStripMenuItem.Name = "helpMeToolStripMenuItem";
            this.helpMeToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.helpMeToolStripMenuItem.Text = "Help me!";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usmeToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "About..";
            // 
            // usmeToolStripMenuItem
            // 
            this.usmeToolStripMenuItem.Name = "usmeToolStripMenuItem";
            this.usmeToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.usmeToolStripMenuItem.Text = "Us.. ";
            this.usmeToolStripMenuItem.Click += new System.EventHandler(this.usmeToolStripMenuItem_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Text Files|*.txt";
            // 
            // openMapFileDialog
            // 
            this.openMapFileDialog.Filter = "Text Files|*.txt";
            // 
            // openTilesheetFileDialog
            // 
            this.openTilesheetFileDialog.FileName = "tilesheet";
            this.openTilesheetFileDialog.Filter = "PNG Files|*.png";
            // 
            // toolSelect
            // 
            this.toolSelect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolSelect.Image = ((System.Drawing.Image)(resources.GetObject("toolSelect.Image")));
            this.toolSelect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSelect.ImgOnPressed = null;
            this.toolSelect.ImgOnReleased = null;
            this.toolSelect.Name = "toolSelect";
            this.toolSelect.Size = new System.Drawing.Size(23, 22);
            this.toolSelect.Text = "toolSelect";
            // 
            // toolPaint
            // 
            this.toolPaint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolPaint.Image = global::cbMapEditor2.Properties.Resources.pencil_16;
            this.toolPaint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolPaint.ImgOnPressed = global::cbMapEditor2.Properties.Resources.pencil_onPressed;
            this.toolPaint.ImgOnReleased = global::cbMapEditor2.Properties.Resources.pencil_16;
            this.toolPaint.Name = "toolPaint";
            this.toolPaint.Size = new System.Drawing.Size(23, 22);
            this.toolPaint.Text = "Paint Tool";
            this.toolPaint.Click += new System.EventHandler(this.toggleButton2_Click);
            // 
            // toolFill
            // 
            this.toolFill.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolFill.Image = global::cbMapEditor2.Properties.Resources.construction_bucket_icon;
            this.toolFill.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolFill.ImgOnPressed = global::cbMapEditor2.Properties.Resources.construction_bucket_icon;
            this.toolFill.ImgOnReleased = global::cbMapEditor2.Properties.Resources.bucketonPressed;
            this.toolFill.Name = "toolFill";
            this.toolFill.Size = new System.Drawing.Size(23, 22);
            this.toolFill.Text = "Fill Tool";
            // 
            // recentMapsToolStripMenuItem
            // 
            this.recentMapsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.recentMapsToolStripMenuItem.Name = "recentMapsToolStripMenuItem";
            this.recentMapsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.recentMapsToolStripMenuItem.Text = "Recent Maps..";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem2.Text = "...";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 490);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mainContainer);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.Name = "MainForm";
            this.Text = "Cyber\'s Map Editor Games";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.mainContainer.Panel1.ResumeLayout(false);
            this.mainContainer.Panel1.PerformLayout();
            this.mainContainer.Panel2.ResumeLayout(false);
            this.mainContainer.Panel2.PerformLayout();
            this.mainContainer.ResumeLayout(false);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mpMap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mpSprites)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tl_width;
        private System.Windows.Forms.ToolStripTextBox cpWidth;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel tl_height;
        private System.Windows.Forms.ToolStripTextBox cpHeight;
        private System.Windows.Forms.ToolStripLabel tlgrid_Inform;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.SplitContainer mainContainer;
        private System.Windows.Forms.PictureBox mpSprites;
        private System.Windows.Forms.PictureBox mpMap;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btGrid32;
        private System.Windows.Forms.ToolStripButton btGrid16;
        private System.Windows.Forms.ToolStripButton btGrid8;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusTileNumber;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openMapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openTileSheetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usmeToolStripMenuItem;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
		private System.Windows.Forms.OpenFileDialog openMapFileDialog;
		private System.Windows.Forms.OpenFileDialog openTilesheetFileDialog;
		private System.Windows.Forms.ToolStripButton btnUndo;
        private System.Windows.Forms.ToolStripButton btnRedo;
        private System.Windows.Forms.ToolStripMenuItem closeMapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newMapToolStripMenuItem;
        private cbMapEditor2.Components.ToggleButton toolSelect;
        private cbMapEditor2.Components.ToggleButton toolPaint;
        private cbMapEditor2.Components.ToggleButton toolFill;
        public Components.ToggleButton bt_Draw;
        public Components.ToggleButton bt_fill;
        public Components.ToggleButton bt_zoom;
        public System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripMenuItem recentMapsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;

    }
}

