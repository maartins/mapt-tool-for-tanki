using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapTool {
    class Tank : Block{

        public Tank(int x, int y)
            : base(x, y, Properties.Resources.Tank01)  {

        }
    }
}
