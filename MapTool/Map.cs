using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapTool {
    class Map {

        private char[,] mapArray;

        public Map() {
            mapArray = new char[15, 15];

            for (int i = 0; i < 15; i++ ) {
                for (int j = 0; j < 15; j++ ) {
                    if (i == 0) {
                        mapArray[i, j] = (char)BlockTypes.SolidWall;
                    } else if (i > 0 && i < 14) {
                        if (j == 0 || j == 14) {
                            mapArray[i, j] = (char)BlockTypes.SolidWall;
                        } else {
                            mapArray[i, j] = (char)BlockTypes.Floor;
                        }
                    } else {
                        mapArray[i, j] = (char)BlockTypes.SolidWall;
                    }
                }
            }
        }

        public Map(string path) {
            string[] lines = System.IO.File.ReadAllLines(path);

            mapArray = new char[15, 15];

            for (int i = 0; i < 15; i++) {
                for (int j = 0; j < 15; j++) {
                    mapArray[i, j] = lines[i].ElementAt(j);
                }
            }
        }

        public char[,] getMapArray() {
            return mapArray;
        }

        public void outputCharMap() {
            for (int i = 0; i < 15; i++) {
                for (int j = 0; j < 15; j++) {
                    Console.Write(mapArray[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
