using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_five_chess {
    class black : pieces{
        public black (int x, int y) : base(x, y){
            this.Image = Properties.Resources.black;
        }
    }
}
