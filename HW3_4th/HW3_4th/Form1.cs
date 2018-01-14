using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW3_4th {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        string[] listCom = new string[] { "汽水", "黑松沙士", "麵包" };
        int[] cost = new int[50];
        int[] price = new int[50];
        int count = 0;
       
        private void Form1_Load(object sender, EventArgs e) {
            label1.Text = "商店進貨管理系統";
            label2.Text = "商品";
            label3.Text = "成本";
            label4.Text = "售價";
            button1.Text = "確定";
            comboBox1.Items.AddRange(listCom);
            cost[count] = 20;
            price[count] = 36;
            count++;
            cost[count] = 22;
            price[count] = 40;
            count++;
            cost[count] = 12;
            price[count] = 24;
            count++;
            
        }

        private void button1_Click(object sender, EventArgs e) {
            int tmp = comboBox1.FindStringExact(comboBox1.Text);
            try {
                if(tmp ==  -1) {
                    if(comboBox1.Text == "") {
                        MessageBox.Show("商品請不要空白");
                    } else {
                        cost[count] = Convert.ToInt16(textBox1.Text);
                        price[count] = Convert.ToInt16(textBox2.Text);
                        comboBox1.Items.Add(comboBox1.Text);
                        count++;
                    }
                } else {
                    cost[tmp] = Convert.ToInt16(textBox1.Text);
                    price[tmp] = Convert.ToInt16(textBox2.Text);
                }
            }catch{
                MessageBox.Show("請輸入價錢");
            }
          
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            int tmp = 0;
            tmp = comboBox1.SelectedIndex;
            textBox1.Text = cost[tmp].ToString();
            textBox2.Text = price[tmp].ToString();
        }

    }
}
