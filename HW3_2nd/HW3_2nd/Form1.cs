using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW3_2nd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Input data
        string[] name = new string[6] { "Tim", "Jack", "john", "Alex", "Hermes", "Emily" };
        int[] height = new int[6] { 165, 166, 180, 179, 157, 161 };
        int[] weight = new int[6] { 68, 70, 92, 78, 49, 53 };

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Name";
            label2.Text = "Height";
            label3.Text = "Weight";
            label4.Text = "BMI";
            label5.Text = "average";
            BmiArrys(name, height, weight);
        }
        
        private void BmiArrys(string[] name, int[] height, int[] weight) {
            Label[] labelN = new Label[6];
            Label[] labelH = new Label[6];
            Label[] labelW = new Label[6];
            Label[] labelBMI = new Label[6];
            float[] avg = new float[3];
            for (int i = 0; i < 6; i++) {
                //This labelN is name list
                labelN[i] = new Label();
                labelN[i].Text = name[i];
                labelN[i].Location = new System.Drawing.Point(60, 100 + (40 * i));
                this.Controls.Add(labelN[i]);
                //This labeH is Height
                labelH[i] = new Label();
                labelH[i].Text = height[i].ToString();
                labelH[i].Location = new System.Drawing.Point(180, 100 + (40 * i));
                this.Controls.Add(labelH[i]);
                //This labelW is Weight
                labelW[i] = new Label();
                labelW[i].Text = weight[i].ToString();
                labelW[i].Location = new System.Drawing.Point(300, 100 + (40 * i));
                this.Controls.Add(labelW[i]);
                //This is BMI
                float hei = (float)height[i] / 100;
                float BMI = (weight[i] / (hei * hei));

                labelBMI[i] = new Label();
                labelBMI[i].Text = string.Format("{0:0.00}", BMI);
                labelBMI[i].Location = new System.Drawing.Point(420, 100 + (40 * i));
                this.Controls.Add(labelBMI[i]);
                //avg
                avg[0] += height[i];
                avg[1] += weight[i];
                avg[2] += BMI;
            }
            Label[] labelAvg = new Label[3];
            labelAvg[0] = new Label();
            labelAvg[0].Text = string.Format("{0:0.00}", avg[0] / 6);
            labelAvg[0].Location = new System.Drawing.Point(180, 100 + (40 * 7));
            this.Controls.Add(labelAvg[0]);
            labelAvg[1] = new Label();
            labelAvg[1].Text = string.Format("{0:0.00}", avg[1] / 6);
            labelAvg[1].Location = new System.Drawing.Point(300, 100 + (40 * 7));
            this.Controls.Add(labelAvg[1]);
            labelAvg[2] = new Label();
            labelAvg[2].Text = string.Format("{0:0.00}", avg[2] / 6);
            labelAvg[2].Location = new System.Drawing.Point(420, 100 + (40 * 7));
            this.Controls.Add(labelAvg[2]);
            

        }

    }
}
