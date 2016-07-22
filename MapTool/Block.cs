using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace MapTool {
    public class Block {
        private Image img;

        public Image Img { get { return img; } }

        public Point Pos { get; set; }

        public Block(int x, int y, string imagePath) {
            img = Image.FromFile(imagePath);
            Pos = new Point(x, y);
        }

        public Block(int x, int y, Image image) {
            img = image;
            Pos = new Point(x, y);
        }

        public BlockTypes ToBlockType() {
            BlockTypes value = BlockTypes.Floor;

            if (this is SolidWall) {
                value = BlockTypes.SolidWall;
            } else if (this is Floor) {
                value = BlockTypes.Floor;
            } else if (this is Wall) {
                value = BlockTypes.Wall;
            } else if (this is Tank) {
                value = BlockTypes.Tank;
            } else if (this is Spawn) {
                value = BlockTypes.Spawn;
            } else if (this is SuperBullet) {
                value = BlockTypes.SuperBullet;
            } else if (this is Bird) {
                value = BlockTypes.Bird;
            }

            return value;
        }
    }
}
