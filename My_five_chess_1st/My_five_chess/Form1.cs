using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_five_chess {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        bool whoseTurn = true;    //if it's black's turn , "true"
        private void Form1_Load(object sender, EventArgs e) {

            Button[,] button = new Button[15, 15];
            for(int i = 0; i < 15; i++) {
                for(int j = 0; j < 15; j++) {
                    button[i, j] = new Button();
                    button[i, j].Controls.Add(new Button());

                }
            }

            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(91, 885);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e) {
            if(whoseTurn == true) {
                this.Controls.Add(new black(e.X - 20, e.Y - 20));
                whoseTurn = false;
            }else if (whoseTurn == false) {
                this.Controls.Add(new white(e.X - 20, e.Y - 20));
                whoseTurn = true;
            }
        }
    }
}
