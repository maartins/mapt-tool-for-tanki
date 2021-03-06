﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapTool {
    public partial class MainForm : Form {
        public static bool isMouseDown = false;

        private MapTab myTabPage;

        public static BlockTypes activeBlock = BlockTypes.Floor;     

        public MainForm() {
            InitializeComponent();
            this.SetStyle(ControlStyles.UserPaint | 
                ControlStyles.OptimizedDoubleBuffer | 
                ControlStyles.AllPaintingInWmPaint | 
                ControlStyles.SupportsTransparentBackColor, true);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e) {
            string name = Prompt.ShowDialog("Map name:", "Input");

            if (name.Equals(""))
                name = "New map";

            myTabPage = new MapTab(name);
            mainPanel.TabPages.Add(myTabPage);
        }

        protected override CreateParams CreateParams {
            get {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        protected override void OnResizeBegin(EventArgs e) {
            SuspendLayout();
            base.OnResizeBegin(e);
        }
        protected override void OnResizeEnd(EventArgs e) {
            ResumeLayout();
            base.OnResizeEnd(e);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e) {
            openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            openFileDialog.Filter = "txt files|*.txt";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            DialogResult dr = openFileDialog.ShowDialog();

            if(dr == DialogResult.OK){
                myTabPage = new MapTab(Path.GetFileNameWithoutExtension(openFileDialog.FileName), openFileDialog.FileName);
                mainPanel.TabPages.Add(myTabPage);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
            if (mainPanel.TabCount != 0) {
                MapTab mt = mainPanel.SelectedTab as MapTab;
                mt.Save();
            }
        }

        private void wallButton_Click(object sender, EventArgs e) {
            activeBlock = BlockTypes.Wall;
        }

        private void solidWallButton_Click(object sender, EventArgs e) {
            activeBlock = BlockTypes.SolidWall;
        }

        private void tankButton_Click(object sender, EventArgs e) {
            activeBlock = BlockTypes.Tank;
        }

        private void superBulletButton_Click(object sender, EventArgs e) {
            activeBlock = BlockTypes.SuperBullet;
        }

        private void floorButton_Click(object sender, EventArgs e) {
            activeBlock = BlockTypes.Floor;
        }

        private void enemyButton_Click(object sender, EventArgs e) {
            activeBlock = BlockTypes.Spawn;
        }

        private void birdButton_Click(object sender, EventArgs e) {
            activeBlock = BlockTypes.Bird;
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e) {
            isMouseDown = true;
        }

        private void MainForm_MouseUp(object sender, MouseEventArgs e) {
            isMouseDown = false;
        }

        private void closeTabToolStripMenuItem_Click(object sender, EventArgs e) {
            if (mainPanel.TabCount > 0) {
                mainPanel.SelectedTab.Dispose();
                mainPanel.Refresh();
            }
        }
    }
}
