using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapTool {
    public class MapTab : TabPage{
        List<Button> buttonList = new List<Button>();

        public MapTab(String title) {
            this.Text = title;

            Map newMap = new Map(@"C:\Users\Martins\Desktop\JAVA\TANK\Maps\map1.txt");
            newMap.outputCharMap();

            char[,] map = newMap.getMapArray();

            for (int i = 0; i < 15; i++ ) {
                for (int j = 0; j < 15; j++) {
                    buttonList.Add(new Button());
                    buttonList.ElementAt(buttonList.Count - 1).Text = map[i, j].ToString();
                    buttonList.ElementAt(buttonList.Count - 1).SetBounds(j * 32, i * 32, 32, 32);
                    buttonList.ElementAt(buttonList.Count - 1).Show();
                    this.Controls.Add(buttonList.ElementAt(buttonList.Count - 1));
                }
            }
        }
    }
}
