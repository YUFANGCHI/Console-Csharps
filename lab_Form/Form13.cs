using System;
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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }
        List<arraylist> list = new List<arraylist>();
        private void button1_Click(object sender, EventArgs e)
        {
            arraylist pro;
            pro.name = textBox1.Text;
            pro.age = int.Parse(textBox2.Text);

            list.Add(pro);
            label2.Text = "員工\n";
            //for (int i = 0; i < list.Count; i++)
            //{
            //    label2.Text += $"姓名：{(list[i]).name}，" +
            //        $"年紀：{(list[i]).age}\n";
            //}
            label2.Text += $"--------------------\n員工數量：{list.Count}";

            foreach (arraylist pro2 in list)
            {
                label2.Text += $"姓名：{pro.name}，" + $"年紀：{(pro.age)}\n";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            arraylist pro;
            pro.name = textBox1.Text;
            pro.age = int.Parse(textBox2.Text);

            list.Insert(0,pro);
            label2.Text = "員工\n";
            //for (int i = 0; i < list.Count; i++)
            //{
            //    label2.Text += $"姓名：{(list[i]).name}，" +
            //        $"年紀：{(list[i]).age}\n";
            //}
            label2.Text += $"--------------------\n員工數量：{list.Count}";

            foreach (arraylist pro2 in list)
            {
                label2.Text += $"姓名：{pro.name}，" + $"年紀：{(pro.age)}\n";
            }
        }
    }
}

            

   



      
    

   
        

    

