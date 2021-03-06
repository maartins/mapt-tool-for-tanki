﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace MapTool {
    public partial class MapButton : UserControl {
        private Block current = null;

        public Block Current {
            get {
                if (current != null)
                    return current;
                else
                    return new Block(0, 0, Properties.Resources.Floor01);
            }
        }

        public MapButton() {
            InitializeComponent();
        }

        public MapButton(Block block) {
            InitializeComponent();

            current = block;

            if (current != null) {
                BackgroundImage = current.Img;
                Location = current.Pos;
            }
        }

        private void MapButton_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                switch (MainForm.activeBlock) {
                    case BlockTypes.Floor:
                        current = new Floor(current.Pos.X, current.Pos.Y);
                        BackgroundImage = current.Img;
                        break;
                    case BlockTypes.Bird:
                        current = new Bird(current.Pos.X, current.Pos.Y);
                        BackgroundImage = current.Img;
                        break;
                    case BlockTypes.SuperBullet:
                        current = new SuperBullet(current.Pos.X, current.Pos.Y);
                        BackgroundImage = current.Img;
                        break;
                    case BlockTypes.SolidWall:
                        current = new SolidWall(current.Pos.X, current.Pos.Y);
                        BackgroundImage = current.Img;
                        break;
                    case BlockTypes.Spawn:
                        current = new Spawn(current.Pos.X, current.Pos.Y);
                        BackgroundImage = current.Img;
                        break;
                    case BlockTypes.Tank:
                        current = new Tank(current.Pos.X, current.Pos.Y);
                        BackgroundImage = current.Img;
                        break;
                    case BlockTypes.Wall:
                        current = new Wall(current.Pos.X, current.Pos.Y);
                        BackgroundImage = current.Img;
                        break;
                    default:
                        current = new Floor(current.Pos.X, current.Pos.Y);
                        BackgroundImage = current.Img;
                        break;
                }
            } else if (e.Button == MouseButtons.Right) {
                MainForm.activeBlock = current.ToBlockType();
            }
        }
    }
}
