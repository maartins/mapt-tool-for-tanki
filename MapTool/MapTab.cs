using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapTool {
    public class MapTab : TabPage{

        public string FilePath {
            get;
            set;
        }

        List<MapButton> mapButtonList = new List<MapButton>();

        public MapTab(string title) {
            this.Text = title;
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
                    }
                }
            }

            foreach (var mb in mapButtonList) {
                Controls.Add(mb);
            }
        }

        public MapTab(string title, string path) {
            this.Text = title;

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
                    }
                }
            }

            foreach (var mb in mapButtonList) {
                Controls.Add(mb);
            }
        }

        public void Save() {

            MessageBox.Show(Text + " saved.");
        }
    }
}
