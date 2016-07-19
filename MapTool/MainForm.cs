using System;
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

        private MapTab myTabPage;

        public static BlockTypes activeBlock;

        public MainForm() {
            InitializeComponent();
            this.SetStyle(ControlStyles.UserPaint | 
                ControlStyles.OptimizedDoubleBuffer | 
                ControlStyles.AllPaintingInWmPaint | 
                ControlStyles.SupportsTransparentBackColor, true);

            activeBlock = BlockTypes.Floor;
        }

        private void MainForm_Load(object sender, EventArgs e) {
            
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e) {
            string name = Prompt.ShowDialog("Map name:", "Input");

            if (name.Equals(""))
                name = "New map";

            myTabPage = new MapTab(name);
            myTabPage.Paint += new PaintEventHandler(MainForm_Paint);
            mainPanel.TabPages.Add(myTabPage);
        }


        private void MainForm_Paint(object sender, PaintEventArgs e) {

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

        private void wallButton_Click(object sender, EventArgs e) {
            activeBlock = BlockTypes.Wall;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e) {
            openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            openFileDialog.Filter = "TXT files|*.txt";
            openFileDialog.FilterIndex = 1;

            DialogResult dr = openFileDialog.ShowDialog();

            if(dr == DialogResult.OK){
                myTabPage = new MapTab(Path.GetFileNameWithoutExtension(openFileDialog.FileName), openFileDialog.FileName);
                myTabPage.Paint += new PaintEventHandler(MainForm_Paint);
                mainPanel.TabPages.Add(myTabPage);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
            MapTab mt = mainPanel.SelectedTab as MapTab;
            mt.Save();
        }
    }
}
