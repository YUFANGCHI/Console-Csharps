using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork
{
    public partial class work6 : Form
    {
        public work6()
        {
            InitializeComponent();
        }
        int 檢查輸入值;

        private void button1_Click(object sender, EventArgs e)
        {
            if(int.TryParse(textBox1.Text,out 檢查輸入值))
            {
                if (int.TryParse(textBox2.Text, out 檢查輸入值))
                {
                    decimal 上格 = decimal.Parse(textBox1.Text);
                    decimal 下格 = decimal.Parse(textBox2.Text);
                    label5.Text = $"{上格 + 下格}";
                }
                else
                {
                    MessageBox.Show("請輸入數字", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }
            else
            {
                MessageBox.Show("請輸入數字","錯誤", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out 檢查輸入值))
            {
                if (int.TryParse(textBox2.Text, out 檢查輸入值))
                {
                    decimal 上格 = decimal.Parse(textBox1.Text);
                    decimal 下格 = decimal.Parse(textBox2.Text);
                    label5.Text = $"{上格 - 下格}";
                }
                else
                {
                    MessageBox.Show("請輸入數字", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("請輸入數字", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out 檢查輸入值))
            {
                if (int.TryParse(textBox2.Text, out 檢查輸入值))
                {
                    decimal 上格 = decimal.Parse(textBox1.Text);
                    decimal 下格 = decimal.Parse(textBox2.Text);
                    label5.Text = $"{上格 * 下格}";
                }
                else
                {
                    MessageBox.Show("請輸入數字", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("請輸入數字", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out 檢查輸入值))
            {
                if (int.TryParse(textBox2.Text, out 檢查輸入值))
                {
                    decimal 上格 = decimal.Parse(textBox1.Text);
                    decimal 下格 = decimal.Parse(textBox2.Text);
                    label5.Text = $"{上格 / 下格}";
                }
                else
                {
                    MessageBox.Show("請輸入數字", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("請輸入數字", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
