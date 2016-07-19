using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapTool {
    class Spawn : Block{

        public Spawn(int x, int y)
            : base(x, y, Properties.Resources.Enemy01)  {

        }
    }
}
