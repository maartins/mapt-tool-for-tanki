﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapTool {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e) {
            MapTab myTabPage = new MapTab("New map");
            tabControl.TabPages.Add(myTabPage);
            
        }
    }
}
