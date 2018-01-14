using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW3_3rd {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        string[] listS = new string[] { "青菜", "山羊", "野狼", "農夫" };
        private void Form1_Load(object sender, EventArgs e) {
            label1.Text = "農夫過河";
            button3.Text = "說明";
            listBox1.Items.AddRange(listS);
            button2.Text = "-->";
            button1.Text = "<--";
          
        }

        private void check() {
            if (listBox1.FindString(listS[3]) < 0) {
                for (int i = 0; i < 2; i++) {
                    if (listBox1.FindString(listS[i]) >= 0 && listBox1.FindString(listS[i + 1]) >= 0) {
                        MessageBox.Show(listS[i + 1] + "eat" + listS[i]);
                    }
                }
            } else {
                for (int i = 0; i < 2; i++) {
                    if (listBox2.FindString(listS[i]) >= 0 && listBox2.FindString(listS[i + 1]) >= 0) {
                        MessageBox.Show(listS[i + 1] + "eat" + listS[i]);
                    }
                }
            }
            int count = 0;
            for (int i = 0; i < listBox2.Items.Count; i++) {
                if (listBox2.FindString(listS[i]) < 0) {
                    break;
                } else {
                    count++;
                }
            }
            if (count == listS.Length) {
                MessageBox.Show("END");
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            if ((string)(listBox2.SelectedItem) != listS[3]) {
                if (listBox1.FindString(listS[3]) < 0) {
                    listBox1.Items.Add(listS[3]);
                    listBox2.Items.Remove(listS[3]);
                }
                listBox1.Items.Add(listBox2.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
            check();
        }

        private void button2_Click_1(object sender, EventArgs e) {
            if ((string)(listBox1.SelectedItem) != listS[3]) {
                if (listBox2.FindString(listS[3]) < 0) {
                    listBox2.Items.Add(listS[3]);
                    listBox1.Items.Remove(listS[3]);
                }
                listBox2.Items.Add(listBox1.SelectedItem);
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
            check();
        }

        private void button3_Click_1(object sender, EventArgs e) {
            MessageBox.Show("1,農夫一次只能帶一件物品或空手過河");
            MessageBox.Show("2.若單獨留山羊和青菜或野狼和山羊在岸上，山羊會吃青菜,野狼也會吃山羊，遊戲就結束並重新開始");
            MessageBox.Show("3.將三件都帶到對岸就完成任務");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {
            button1.Enabled = false;
            button2.Enabled = true;
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e) {
            button1.Enabled = true;
            button2.Enabled = false;
        }
    }
}
