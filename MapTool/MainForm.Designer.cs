namespace MapTool
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.mainPanel = new System.Windows.Forms.TabControl();
            this.toolPanel = new System.Windows.Forms.Panel();
            this.birdButton = new System.Windows.Forms.Button();
            this.enemyButton = new System.Windows.Forms.Button();
            this.floorButton = new System.Windows.Forms.Button();
            this.superBulletButton = new System.Windows.Forms.Button();
            this.tankButton = new System.Windows.Forms.Button();
            this.solidWallButton = new System.Windows.Forms.Button();
            this.wallButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.toolPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(705, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.Location = new System.Drawing.Point(72, 27);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.SelectedIndex = 0;
            this.mainPanel.Size = new System.Drawing.Size(621, 569);
            this.mainPanel.TabIndex = 2;
            // 
            // toolPanel
            // 
            this.toolPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.toolPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolPanel.Controls.Add(this.birdButton);
            this.toolPanel.Controls.Add(this.enemyButton);
            this.toolPanel.Controls.Add(this.floorButton);
            this.toolPanel.Controls.Add(this.superBulletButton);
            this.toolPanel.Controls.Add(this.tankButton);
            this.toolPanel.Controls.Add(this.solidWallButton);
            this.toolPanel.Controls.Add(this.wallButton);
            this.toolPanel.Location = new System.Drawing.Point(12, 27);
            this.toolPanel.Name = "toolPanel";
            this.toolPanel.Size = new System.Drawing.Size(54, 569);
            this.toolPanel.TabIndex = 4;
            // 
            // birdButton
            // 
            this.birdButton.Image = global::MapTool.Properties.Resources.Bird01;
            this.birdButton.Location = new System.Drawing.Point(3, 309);
            this.birdButton.Name = "birdButton";
            this.birdButton.Size = new System.Drawing.Size(46, 45);
            this.birdButton.TabIndex = 10;
            this.birdButton.UseVisualStyleBackColor = true;
            this.birdButton.Click += new System.EventHandler(this.birdButton_Click);
            // 
            // enemyButton
            // 
            this.enemyButton.Image = global::MapTool.Properties.Resources.Enemy01;
            this.enemyButton.Location = new System.Drawing.Point(3, 258);
            this.enemyButton.Name = "enemyButton";
            this.enemyButton.Size = new System.Drawing.Size(46, 45);
            this.enemyButton.TabIndex = 9;
            this.enemyButton.UseVisualStyleBackColor = true;
            this.enemyButton.Click += new System.EventHandler(this.enemyButton_Click);
            // 
            // floorButton
            // 
            this.floorButton.Image = global::MapTool.Properties.Resources.Floor01;
            this.floorButton.Location = new System.Drawing.Point(3, 207);
            this.floorButton.Name = "floorButton";
            this.floorButton.Size = new System.Drawing.Size(46, 45);
            this.floorButton.TabIndex = 8;
            this.floorButton.UseVisualStyleBackColor = true;
            this.floorButton.Click += new System.EventHandler(this.floorButton_Click);
            // 
            // superBulletButton
            // 
            this.superBulletButton.Image = global::MapTool.Properties.Resources.PwrUpSuperBullet01;
            this.superBulletButton.Location = new System.Drawing.Point(3, 156);
            this.superBulletButton.Name = "superBulletButton";
            this.superBulletButton.Size = new System.Drawing.Size(46, 45);
            this.superBulletButton.TabIndex = 7;
            this.superBulletButton.UseVisualStyleBackColor = true;
            this.superBulletButton.Click += new System.EventHandler(this.superBulletButton_Click);
            // 
            // tankButton
            // 
            this.tankButton.Image = global::MapTool.Properties.Resources.Tank01;
            this.tankButton.Location = new System.Drawing.Point(3, 105);
            this.tankButton.Name = "tankButton";
            this.tankButton.Size = new System.Drawing.Size(46, 45);
            this.tankButton.TabIndex = 6;
            this.tankButton.UseVisualStyleBackColor = true;
            this.tankButton.Click += new System.EventHandler(this.tankButton_Click);
            // 
            // solidWallButton
            // 
            this.solidWallButton.Image = global::MapTool.Properties.Resources.Wall02;
            this.solidWallButton.Location = new System.Drawing.Point(3, 54);
            this.solidWallButton.Name = "solidWallButton";
            this.solidWallButton.Size = new System.Drawing.Size(46, 45);
            this.solidWallButton.TabIndex = 5;
            this.solidWallButton.UseVisualStyleBackColor = true;
            this.solidWallButton.Click += new System.EventHandler(this.solidWallButton_Click);
            // 
            // wallButton
            // 
            this.wallButton.Image = global::MapTool.Properties.Resources.Wall01;
            this.wallButton.Location = new System.Drawing.Point(3, 3);
            this.wallButton.Name = "wallButton";
            this.wallButton.Size = new System.Drawing.Size(46, 45);
            this.wallButton.TabIndex = 4;
            this.wallButton.UseVisualStyleBackColor = true;
            this.wallButton.Click += new System.EventHandler(this.wallButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 604);
            this.Controls.Add(this.toolPanel);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.mainPanel);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(670, 465);
            this.Name = "MainForm";
            this.Text = "MapTool";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TabControl mainPanel;
        private System.Windows.Forms.Panel toolPanel;
        private System.Windows.Forms.Button wallButton;
        private System.Windows.Forms.Button birdButton;
        private System.Windows.Forms.Button enemyButton;
        private System.Windows.Forms.Button floorButton;
        private System.Windows.Forms.Button superBulletButton;
        private System.Windows.Forms.Button tankButton;
        private System.Windows.Forms.Button solidWallButton;
    }
}

