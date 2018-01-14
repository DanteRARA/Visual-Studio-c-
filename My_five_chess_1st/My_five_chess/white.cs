using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_five_chess {
    class white : pieces{
        public white (int x, int y) : base(x, y) {
            this.Image = Properties.Resources.white;            
        }
    }
}
