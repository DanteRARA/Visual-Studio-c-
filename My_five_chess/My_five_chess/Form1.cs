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

        private borad borad = new borad();
        private bool whoseTurn = true;    //if it's black's turn , "true"

        private void Form1_Load(object sender, EventArgs e) {
            label1.Text = "";
            label2.Text = "";
        }

        bool placeORnot = false;
        static int[,] table = new int[15, 15];
        private void Form1_MouseDown(object sender, MouseEventArgs e) {
            //把棋盤陣列化，並給予編號
            
            int x = borad.FindTheClosetNode(e.X, e.Y).X;
            int y = borad.FindTheClosetNode(e.X, e.Y).Y;
            label3.Text = x.ToString() + "," + y.ToString();
            //判斷是否可以放棋子
            int black = 1, white = 2;
            if(placeORnot) {
                //判斷該誰下棋
                if (whoseTurn == true) {
                    this.Controls.Add(new black((x * 55) + 65 - 20, (y * 55) + 65 - 20));
                    whoseTurn = false;
                    table[x, y] = black;
                    ccheck(black);
                } else if (whoseTurn == false) {
                    this.Controls.Add(new white((x * 55) + 65 - 20, (y * 55) + 65 - 20));
                    whoseTurn = true;
                    table[x, y] = white;
                    ccheck(white);
                }
               
            }
            
        }
        private void ccheck(int who) {
            int black = 1, white = 2;
            whoseWin hW = new whoseWin();
            if (hW.winCheck(who, table) == black)
                MessageBox.Show("Black WIN!!!");
            else if (hW.winCheck(who, table) == white)
                MessageBox.Show("White WIN!!!!");
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e) {
            if(placeORnot = borad.CanBePlaced(e.X, e.Y)){
                this.Cursor = Cursors.Hand;
            }else{
                this.Cursor = Cursors.Default;
            }
            label1.Text = "X : " + e.X.ToString();
            label2.Text = "Y : " + e.Y.ToString(); 
        }
        
        /*
        private void Form1_Paint(object sender, PaintEventArgs e) {
            Form1 form = new Form1();
            form.Width += 100;
            Pen pen = new Pen(Color.Black, 1);
            //X軸畫線
            for(int i = 0; i < this.Width; i++) {
                Point pointX1 = new Point(i, OFFSET);
                Point pointX2 = new Point(i, this.Height - OFFSET);
                e.Graphics.DrawLine(pen, pointX1, pointX2);
            }
            //Y軸畫線
            for(int j = 0; j < this.Width; j++) {
                Point pointY1 = new Point(OFFSET, j);
                Point pointY2 = new Point(this.Height, j);
                e.Graphics.DrawLine(pen, pointY1, pointY2);
            }

        }
        */
    }
}
