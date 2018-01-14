using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "";
        }
        int cash, sum, change;

        private void button1_Click(object sender, EventArgs e)
        {
            cash = Convert.ToInt32(textBox1.Text);
            sum = Convert.ToInt32(textBox2.Text);
            change = cash - sum;
            textBox3.Text = change.ToString();
            if(change >= 1000) textBox4.Text = (change / 1000).ToString() + " 張";
            change %= 1000;            
            if(change >= 500) textBox5.Text = (change / 500).ToString() + " 張";
            change %= 500;
            if(change >= 100) textBox6.Text = (change / 100).ToString() + " 張";
            change %= 100;
            if (change >= 50) textBox7.Text = (change / 50).ToString() + " 張";
            change %= 50;
            if (change >= 10) textBox8.Text = (change / 10).ToString() + " 張";
            change %= 10;
            if (change >= 5) textBox9.Text = (change / 5).ToString() + " 張";
            change %= 5;
            if (change >= 1) textBox10.Text = (change / 1).ToString() + " 張";





        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "計算";
            label1.Text = "收現 : ";
            label2.Text = "消費 : ";
            label3.Text = "找零 : ";
            textBox3.Enabled = false;
            label4.Text = "1000元 ";
            label5.Text = "500 元 ";
            label6.Text = "100 元 ";
            label7.Text = " 50 元 ";
            label8.Text = " 10 元 ";
            label9.Text = "  5 元 ";
            label10.Text = "  1 元 ";

        }
    }
}
/*
*/