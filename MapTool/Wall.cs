using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapTool {
    class Wall : Block{

        public Wall(int x, int y)
            : base(x, y, Properties.Resources.Wall01) {

        }
    }
}
