namespace Data_Management_Project
{
    partial class FormMain
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
            this.pbMain = new System.Windows.Forms.PictureBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.rbSolid = new System.Windows.Forms.RadioButton();
            this.rbImage = new System.Windows.Forms.RadioButton();
            this.btnImage = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportLevelToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listViewImage = new System.Windows.Forms.ListView();
            this.cbTile = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cbGrid = new System.Windows.Forms.CheckBox();
            this.cbSpecial = new System.Windows.Forms.CheckBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.nudSpecial = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpecial)).BeginInit();
            this.SuspendLayout();
            // 
            // pbMain
            // 
            this.pbMain.BackColor = System.Drawing.Color.White;
            this.pbMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbMain.Location = new System.Drawing.Point(12, 56);
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(900, 554);
            this.pbMain.TabIndex = 0;
            this.pbMain.TabStop = false;
            this.pbMain.Click += new System.EventHandler(this.pbMain_Click);
            this.pbMain.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbMain_MouseClick);
            this.pbMain.MouseHover += new System.EventHandler(this.pbMain_MouseHover);
            this.pbMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbMain_MouseMove);
            this.pbMain.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.pbMain_PreviewKeyDown);
            // 
            // lblColor
            // 
            this.lblColor.BackColor = System.Drawing.Color.Black;
            this.lblColor.Location = new System.Drawing.Point(1095, 56);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(30, 28);
            this.lblColor.TabIndex = 1;
            this.lblColor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblColor_MouseClick);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(985, 589);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 21);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // rbSolid
            // 
            this.rbSolid.AutoSize = true;
            this.rbSolid.Checked = true;
            this.rbSolid.Location = new System.Drawing.Point(985, 56);
            this.rbSolid.Name = "rbSolid";
            this.rbSolid.Size = new System.Drawing.Size(89, 16);
            this.rbSolid.TabIndex = 3;
            this.rbSolid.TabStop = true;
            this.rbSolid.Text = "Solid Color";
            this.rbSolid.UseVisualStyleBackColor = true;
            this.rbSolid.CheckedChanged += new System.EventHandler(this.rbSolid_CheckedChanged);
            // 
            // rbImage
            // 
            this.rbImage.AutoSize = true;
            this.rbImage.Location = new System.Drawing.Point(985, 106);
            this.rbImage.Name = "rbImage";
            this.rbImage.Size = new System.Drawing.Size(53, 16);
            this.rbImage.TabIndex = 4;
            this.rbImage.Text = "Image";
            this.rbImage.UseVisualStyleBackColor = true;
            // 
            // btnImage
            // 
            this.btnImage.Location = new System.Drawing.Point(1075, 103);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(75, 21);
            this.btnImage.TabIndex = 5;
            this.btnImage.Text = "Load Image";
            this.btnImage.UseVisualStyleBackColor = true;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1284, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importLevelToolStripMenuItem,
            this.exportLevelToolStripMenuItem1,
            this.saveAsImageToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // importLevelToolStripMenuItem
            // 
            this.importLevelToolStripMenuItem.Name = "importLevelToolStripMenuItem";
            this.importLevelToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.importLevelToolStripMenuItem.Text = "Import Level";
            this.importLevelToolStripMenuItem.Click += new System.EventHandler(this.importLevelToolStripMenuItem_Click);
            // 
            // exportLevelToolStripMenuItem1
            // 
            this.exportLevelToolStripMenuItem1.Name = "exportLevelToolStripMenuItem1";
            this.exportLevelToolStripMenuItem1.Size = new System.Drawing.Size(150, 22);
            this.exportLevelToolStripMenuItem1.Text = "Export Level";
            this.exportLevelToolStripMenuItem1.Click += new System.EventHandler(this.exportLevelToolStripMenuItem1_Click);
            // 
            // saveAsImageToolStripMenuItem
            // 
            this.saveAsImageToolStripMenuItem.Name = "saveAsImageToolStripMenuItem";
            this.saveAsImageToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.saveAsImageToolStripMenuItem.Text = "Save As Image";
            this.saveAsImageToolStripMenuItem.Click += new System.EventHandler(this.saveAsImageToolStripMenuItem_Click);
            // 
            // listViewImage
            // 
            this.listViewImage.Location = new System.Drawing.Point(985, 148);
            this.listViewImage.Name = "listViewImage";
            this.listViewImage.Size = new System.Drawing.Size(216, 423);
            this.listViewImage.TabIndex = 7;
            this.listViewImage.UseCompatibleStateImageBehavior = false;
            this.listViewImage.SelectedIndexChanged += new System.EventHandler(this.listViewImage_SelectedIndexChanged);
            this.listViewImage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listViewImage_KeyDown);
            this.listViewImage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.listViewImage_KeyPress);
            // 
            // cbTile
            // 
            this.cbTile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTile.FormattingEnabled = true;
            this.cbTile.Items.AddRange(new object[] {
            "1x1",
            "2x2",
            "3x3",
            "4x4",
            "5x5",
            "Custom"});
            this.cbTile.Location = new System.Drawing.Point(1219, 177);
            this.cbTile.Name = "cbTile";
            this.cbTile.Size = new System.Drawing.Size(121, 20);
            this.cbTile.TabIndex = 8;
            this.cbTile.SelectedIndexChanged += new System.EventHandler(this.cbTile_SelectedIndexChanged);
            this.cbTile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbTile_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1219, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tile Size";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1236, 526);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 44);
            this.button1.TabIndex = 10;
            this.button1.Text = "Background Image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbGrid
            // 
            this.cbGrid.AutoSize = true;
            this.cbGrid.Checked = true;
            this.cbGrid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbGrid.Location = new System.Drawing.Point(1201, 57);
            this.cbGrid.Name = "cbGrid";
            this.cbGrid.Size = new System.Drawing.Size(78, 16);
            this.cbGrid.TabIndex = 11;
            this.cbGrid.Text = "Gridlines";
            this.cbGrid.UseVisualStyleBackColor = true;
            this.cbGrid.CheckedChanged += new System.EventHandler(this.cbGrid_CheckedChanged);
            // 
            // cbSpecial
            // 
            this.cbSpecial.AutoSize = true;
            this.cbSpecial.Location = new System.Drawing.Point(1201, 88);
            this.cbSpecial.Name = "cbSpecial";
            this.cbSpecial.Size = new System.Drawing.Size(96, 16);
            this.cbSpecial.TabIndex = 12;
            this.cbSpecial.Text = "Special Tile";
            this.cbSpecial.UseVisualStyleBackColor = true;
            this.cbSpecial.CheckedChanged += new System.EventHandler(this.cbSpecial_CheckedChanged);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(27, 626);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(11, 12);
            this.lblInfo.TabIndex = 13;
            this.lblInfo.Text = "0";
            // 
            // nudSpecial
            // 
            this.nudSpecial.Enabled = false;
            this.nudSpecial.Location = new System.Drawing.Point(1201, 109);
            this.nudSpecial.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudSpecial.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSpecial.Name = "nudSpecial";
            this.nudSpecial.Size = new System.Drawing.Size(120, 21);
            this.nudSpecial.TabIndex = 14;
            this.nudSpecial.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 685);
            this.Controls.Add(this.nudSpecial);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.cbSpecial);
            this.Controls.Add(this.cbGrid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTile);
            this.Controls.Add(this.listViewImage);
            this.Controls.Add(this.btnImage);
            this.Controls.Add(this.rbImage);
            this.Controls.Add(this.rbSolid);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.pbMain);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Level Designer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMain_KeyDown);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpecial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMain;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.RadioButton rbSolid;
        private System.Windows.Forms.RadioButton rbImage;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importLevelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportLevelToolStripMenuItem1;
        private System.Windows.Forms.ListView listViewImage;
        private System.Windows.Forms.ComboBox cbTile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem saveAsImageToolStripMenuItem;
        private System.Windows.Forms.CheckBox cbGrid;
        private System.Windows.Forms.CheckBox cbSpecial;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.NumericUpDown nudSpecial;
    }
}

