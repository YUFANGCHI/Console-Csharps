using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static lab_Form.day2.product;

namespace lab_Form
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }
        ArrayList list = new ArrayList();
        
        private void button1_Click(object sender, EventArgs e)
        {       
            arraylist pro;
            pro.name = textBox1.Text;
            pro.age =int.Parse( textBox2.Text);

            list.Add(pro); // Ojbect=> boxing

            label2.Text = "員工\n";

            for (int i=0;i<list.Count;i++)
            {
                label2.Text += $"姓名：{((arraylist)list[i]).name}，" +
                    $"年紀：{((arraylist)list[i]).age}\n";
            }
            label2.Text += $"--------------------\n員工數量：{list.Count}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            arraylist pro;
            pro.name = textBox1.Text;
            pro.age = int.Parse(textBox2.Text);

            list.Insert(0,pro);

            label2.Text = "員工\n";

            for (int i = 0; i < list.Count; i++)
            {
                label2.Text += $"姓名：{((arraylist)list[i]).name}，" +
                    $"年紀：{((arraylist)list[i]).age}\n";
            }
            label2.Text += $"--------------------\n員工數量：{list.Count}";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            list.Clear();

            label2.Text = "員工\n";

            for (int i = 0; i < list.Count; i++)
            {
                label2.Text += $"姓名：{((arraylist)list[i]).name}，" +
                    $"年紀：{((arraylist)list[i]).age}\n";
            }
            label2.Text += $"--------------------\n員工數量：{list.Count}";
        }
    }
}
