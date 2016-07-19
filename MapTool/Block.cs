﻿using System;
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
    }
}
