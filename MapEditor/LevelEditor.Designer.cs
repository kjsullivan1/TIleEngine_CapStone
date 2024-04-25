
namespace MapEditor
{
    partial class LevelEditor
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadTextureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pctSurface = new System.Windows.Forms.PictureBox();
            this.colTxt = new System.Windows.Forms.TextBox();
            this.rowTxt = new System.Windows.Forms.TextBox();
            this.ZoomInBtn = new System.Windows.Forms.Button();
            this.ZoomOutBtn = new System.Windows.Forms.Button();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TopTiles = new System.Windows.Forms.ListView();
            this.imageListTopDown = new System.Windows.Forms.ImageList(this.components);
            this.imgListSideScroll = new System.Windows.Forms.ImageList(this.components);
            this.SideTiles = new System.Windows.Forms.ListView();
            this.isSideScroll = new System.Windows.Forms.CheckBox();
            this.isTopDown = new System.Windows.Forms.CheckBox();
            this.mapLevel = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctSurface)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadTextureToolStripMenuItem,
            this.loadMapToolStripMenuItem,
            this.saveMapToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // loadTextureToolStripMenuItem
            // 
            this.loadTextureToolStripMenuItem.Name = "loadTextureToolStripMenuItem";
            this.loadTextureToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.loadTextureToolStripMenuItem.Text = "&Load Texture";
            // 
            // loadMapToolStripMenuItem
            // 
            this.loadMapToolStripMenuItem.Name = "loadMapToolStripMenuItem";
            this.loadMapToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.loadMapToolStripMenuItem.Text = "&Load Map";
            this.loadMapToolStripMenuItem.Click += new System.EventHandler(this.loadMapToolStripMenuItem_Click);
            // 
            // saveMapToolStripMenuItem
            // 
            this.saveMapToolStripMenuItem.Name = "saveMapToolStripMenuItem";
            this.saveMapToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.saveMapToolStripMenuItem.Text = "&Save Map";
            this.saveMapToolStripMenuItem.Click += new System.EventHandler(this.saveMapToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(138, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearMapToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // clearMapToolStripMenuItem
            // 
            this.clearMapToolStripMenuItem.Name = "clearMapToolStripMenuItem";
            this.clearMapToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clearMapToolStripMenuItem.Text = "&Clear Map";
            this.clearMapToolStripMenuItem.Click += new System.EventHandler(this.clearMapToolStripMenuItem_Click);
            // 
            // pctSurface
            // 
            this.pctSurface.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pctSurface.Location = new System.Drawing.Point(402, 27);
            this.pctSurface.Name = "pctSurface";
            this.pctSurface.Size = new System.Drawing.Size(253, 576);
            this.pctSurface.TabIndex = 1;
            this.pctSurface.TabStop = false;
            // 
            // colTxt
            // 
            this.colTxt.Location = new System.Drawing.Point(181, 513);
            this.colTxt.Name = "colTxt";
            this.colTxt.Size = new System.Drawing.Size(100, 20);
            this.colTxt.TabIndex = 6;
            this.colTxt.Text = "25";
            this.colTxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            this.colTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.colTxt_KeyPress);
            this.colTxt.Leave += new System.EventHandler(this.colTxt_Leave);
            // 
            // rowTxt
            // 
            this.rowTxt.Location = new System.Drawing.Point(181, 539);
            this.rowTxt.Name = "rowTxt";
            this.rowTxt.Size = new System.Drawing.Size(100, 20);
            this.rowTxt.TabIndex = 7;
            this.rowTxt.Text = "15";
            this.rowTxt.TextChanged += new System.EventHandler(this.rowTxt_TextChanged);
            this.rowTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rowTxt_KeyDown);
            this.rowTxt.Leave += new System.EventHandler(this.rowTxt_Leave);
            // 
            // ZoomInBtn
            // 
            this.ZoomInBtn.Location = new System.Drawing.Point(483, -2);
            this.ZoomInBtn.Name = "ZoomInBtn";
            this.ZoomInBtn.Size = new System.Drawing.Size(75, 23);
            this.ZoomInBtn.TabIndex = 8;
            this.ZoomInBtn.Text = "Zoom In";
            this.ZoomInBtn.UseVisualStyleBackColor = true;
            this.ZoomInBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // ZoomOutBtn
            // 
            this.ZoomOutBtn.Location = new System.Drawing.Point(564, -2);
            this.ZoomOutBtn.Name = "ZoomOutBtn";
            this.ZoomOutBtn.Size = new System.Drawing.Size(75, 23);
            this.ZoomOutBtn.TabIndex = 9;
            this.ZoomOutBtn.Text = "Zoom Out";
            this.ZoomOutBtn.UseVisualStyleBackColor = true;
            this.ZoomOutBtn.Click += new System.EventHandler(this.ZoomOutBtn_Click);
            // 
            // ResetBtn
            // 
            this.ResetBtn.Location = new System.Drawing.Point(402, -2);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(75, 23);
            this.ResetBtn.TabIndex = 10;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 513);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 539);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Height";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Side-Scroll";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(278, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Top-Down";
            // 
            // TopTiles
            // 
            this.TopTiles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TopTiles.HideSelection = false;
            this.TopTiles.LargeImageList = this.imageListTopDown;
            this.TopTiles.Location = new System.Drawing.Point(214, 44);
            this.TopTiles.MultiSelect = false;
            this.TopTiles.Name = "TopTiles";
            this.TopTiles.Size = new System.Drawing.Size(182, 419);
            this.TopTiles.TabIndex = 15;
            this.TopTiles.TileSize = new System.Drawing.Size(64, 64);
            this.TopTiles.UseCompatibleStateImageBehavior = false;
            this.TopTiles.View = System.Windows.Forms.View.Tile;
            this.TopTiles.SelectedIndexChanged += new System.EventHandler(this.TopTiles_SelectedIndexChanged);
            // 
            // imageListTopDown
            // 
            this.imageListTopDown.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageListTopDown.ImageSize = new System.Drawing.Size(64, 64);
            this.imageListTopDown.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imgListSideScroll
            // 
            this.imgListSideScroll.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imgListSideScroll.ImageSize = new System.Drawing.Size(64, 64);
            this.imgListSideScroll.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // SideTiles
            // 
            this.SideTiles.HideSelection = false;
            this.SideTiles.LargeImageList = this.imgListSideScroll;
            this.SideTiles.Location = new System.Drawing.Point(12, 44);
            this.SideTiles.MultiSelect = false;
            this.SideTiles.Name = "SideTiles";
            this.SideTiles.Size = new System.Drawing.Size(182, 419);
            this.SideTiles.TabIndex = 2;
            this.SideTiles.TileSize = new System.Drawing.Size(64, 64);
            this.SideTiles.UseCompatibleStateImageBehavior = false;
            this.SideTiles.View = System.Windows.Forms.View.Tile;
            this.SideTiles.SelectedIndexChanged += new System.EventHandler(this.SideTiles_SelectedIndexChanged);
            // 
            // isSideScroll
            // 
            this.isSideScroll.AutoSize = true;
            this.isSideScroll.Checked = true;
            this.isSideScroll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.isSideScroll.Location = new System.Drawing.Point(184, 2);
            this.isSideScroll.Name = "isSideScroll";
            this.isSideScroll.Size = new System.Drawing.Size(100, 17);
            this.isSideScroll.TabIndex = 18;
            this.isSideScroll.Text = "Side Scroll Map";
            this.isSideScroll.UseVisualStyleBackColor = true;
            this.isSideScroll.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // isTopDown
            // 
            this.isTopDown.AutoSize = true;
            this.isTopDown.Location = new System.Drawing.Point(290, 2);
            this.isTopDown.Name = "isTopDown";
            this.isTopDown.Size = new System.Drawing.Size(100, 17);
            this.isTopDown.TabIndex = 19;
            this.isTopDown.Text = "Top Down Map";
            this.isTopDown.UseVisualStyleBackColor = true;
            this.isTopDown.CheckedChanged += new System.EventHandler(this.isTopDown_CheckedChanged);
            // 
            // mapLevel
            // 
            this.mapLevel.Location = new System.Drawing.Point(214, 489);
            this.mapLevel.Name = "mapLevel";
            this.mapLevel.Size = new System.Drawing.Size(37, 20);
            this.mapLevel.TabIndex = 20;
            this.mapLevel.ValueChanged += new System.EventHandler(this.mapLevel_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(140, 491);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Map Number";
            // 
            // LevelEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 631);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mapLevel);
            this.Controls.Add(this.isTopDown);
            this.Controls.Add(this.isSideScroll);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TopTiles);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.ZoomOutBtn);
            this.Controls.Add(this.ZoomInBtn);
            this.Controls.Add(this.rowTxt);
            this.Controls.Add(this.colTxt);
            this.Controls.Add(this.SideTiles);
            this.Controls.Add(this.pctSurface);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "LevelEditor";
            this.Text = "LevelEditor";
            this.Load += new System.EventHandler(this.LevelEditor_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctSurface)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapLevel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.PictureBox pctSurface;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadMapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveMapToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearMapToolStripMenuItem;
        private System.Windows.Forms.TextBox colTxt;
        private System.Windows.Forms.TextBox rowTxt;
        private System.Windows.Forms.ToolStripMenuItem loadTextureToolStripMenuItem;
        private System.Windows.Forms.Button ZoomInBtn;
        private System.Windows.Forms.Button ZoomOutBtn;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView TopTiles;
        private System.Windows.Forms.ImageList imgListSideScroll;
        private System.Windows.Forms.ListView SideTiles;
        private System.Windows.Forms.ImageList imageListTopDown;
        private System.Windows.Forms.CheckBox isSideScroll;
        private System.Windows.Forms.CheckBox isTopDown;
        private System.Windows.Forms.NumericUpDown mapLevel;
        private System.Windows.Forms.Label label5;
    }
}