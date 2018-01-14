using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace My_five_chess {
    abstract class pieces : PictureBox{
        public pieces(int x, int y) {
            this.BackColor = Color.Transparent;
            this.Location = new Point(x, y);
            this.Size = new Size(45, 45);
        }
    }
}
