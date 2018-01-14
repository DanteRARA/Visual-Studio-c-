using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_crap {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();            
        }

        private void Form1_Load(object sender, EventArgs e) {
            button1.Text = "START";
            button2.Text = "Stop";
            label1.Text = "";
            timer1.Interval = 50;
            pictureBox1.Image = imageList1.Images[0];
        }
        //Start
        private void button1_Click(object sender, EventArgs e) {
            timer1.Enabled = true;
        }

        //Stop
        private void button2_Click(object sender, EventArgs e) {
            timer1.Enabled = false;
            label1.Text = (ranNum + 1).ToString();
        }
        int ranNum;
        private void timer1_Tick(object sender, EventArgs e) {
            Random ran = new Random();
            ranNum = ran.Next(0, 6);
            pictureBox1.Image = imageList1.Images[ranNum];
        }

        private void pictureBox1_Click(object sender, EventArgs e) {

        }

    }
}
