using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapTool {
    public class MapTab : TabPage {

        public string FilePath {
            get;
            set;
        }

        List<MapButton> mapButtonList = new List<MapButton>();

        public MapTab(string title) {
            this.Text = title;
            this.Name = title;
            FilePath = Directory.GetCurrentDirectory();

            Map newMap = new Map();
            //newMap.outputCharMap();

            char[,] map = newMap.getMapArray();

            for (int i = 0; i < 15; i++) {
                for (int j = 0; j < 15; j++) {
                    if (map[i, j] == (char)BlockTypes.Wall) {
                        mapButtonList.Add(new MapButton(new Wall(j * 32, i * 32)));
                    } else if (map[i, j] == (char)BlockTypes.Floor) {
                        mapButtonList.Add(new MapButton(new Floor(j * 32, i * 32)));
                    } else if (map[i, j] == (char)BlockTypes.Tank) {
                        mapButtonList.Add(new MapButton(new Tank(j * 32, i * 32)));
                    } else if (map[i, j] == (char)BlockTypes.SolidWall) {
                        mapButtonList.Add(new MapButton(new SolidWall(j * 32, i * 32)));
                    } else if (map[i, j] == (char)BlockTypes.Bird) {
                        mapButtonList.Add(new MapButton(new Bird(j * 32, i * 32)));
                    } else if (map[i, j] == (char)BlockTypes.Spawn) {
                        mapButtonList.Add(new MapButton(new Spawn(j * 32, i * 32)));
                    } else if (map[i, j] == (char)BlockTypes.SuperBullet) {
                        mapButtonList.Add(new MapButton(new SuperBullet(j * 32, i * 32)));
                    }
                }
            }

            foreach (var mb in mapButtonList) {
                Controls.Add(mb);
            }
        }

        public MapTab(string title, string path) {
            this.Text = title;
            this.Name = title;

            FilePath = path;

            Map newMap = new Map(FilePath);
            //newMap.outputCharMap();

            char[,] map = newMap.getMapArray();

            for (int i = 0; i < 15; i++) {
                for (int j = 0; j < 15; j++) {
                    if (map[i, j] == (char)BlockTypes.Wall) {
                        mapButtonList.Add(new MapButton(new Wall(j * 32, i * 32)));
                    } else if (map[i, j] == (char)BlockTypes.Floor) {
                        mapButtonList.Add(new MapButton(new Floor(j * 32, i * 32)));
                    } else if (map[i, j] == (char)BlockTypes.Tank) {
                        mapButtonList.Add(new MapButton(new Tank(j * 32, i * 32)));
                    } else if (map[i, j] == (char)BlockTypes.SolidWall) {
                        mapButtonList.Add(new MapButton(new SolidWall(j * 32, i * 32)));
                    } else if (map[i, j] == (char)BlockTypes.Bird) {
                        mapButtonList.Add(new MapButton(new Bird(j * 32, i * 32)));
                    } else if (map[i, j] == (char)BlockTypes.Spawn) {
                        mapButtonList.Add(new MapButton(new Spawn(j * 32, i * 32)));
                    } else if (map[i, j] == (char)BlockTypes.SuperBullet) {
                        mapButtonList.Add(new MapButton(new SuperBullet(j * 32, i * 32)));
                    }
                }
            }

            foreach (var mb in mapButtonList) {
                Controls.Add(mb);
            }
        }

        public void Save() {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = this.Text;
            saveFileDialog.Filter = "txt files (*.txt)|*.txt|all files (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName)) {
                    int i = 0;
                    bool done = false;

                    int[] linesEnds = new int[15];

                    for (int j = 1; j < 16; j++) {
                        linesEnds[j - 1] = j * 15;
                    }

                    while (!done) {
                        if (linesEnds.Contains(i))
                            sw.WriteLine();

                        if (mapButtonList[i].Current is Wall) {
                            sw.Write((char)BlockTypes.Wall);
                        } else if (mapButtonList[i].Current is Floor) {
                            sw.Write((char)BlockTypes.Floor);
                            Console.Write((char)BlockTypes.Floor);
                        } else if (mapButtonList[i].Current is Tank) {
                            sw.Write((char)BlockTypes.Tank);
                        } else if (mapButtonList[i].Current is SolidWall) {
                            sw.Write((char)BlockTypes.SolidWall);
                        } else if (mapButtonList[i].Current is Bird) {
                            sw.Write((char)BlockTypes.Bird);
                        } else if (mapButtonList[i].Current is Spawn) {
                            sw.Write((char)BlockTypes.Spawn);
                        } else if (mapButtonList[i].Current is SuperBullet) {
                            sw.Write((char)BlockTypes.SuperBullet);
                        }

                        if(i == mapButtonList.Count - 1)
                            done = true;
                        else
                            i++;
                    }
                }
            }

        }

        private void InitializeComponent() {
            this.SuspendLayout();
            this.ResumeLayout(false);

        }
    }
}
