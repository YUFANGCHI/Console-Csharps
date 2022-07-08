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
    public partial class work02 : Form
    {
        public work02()
        {
            InitializeComponent();
        }

        private  void button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            double c = double.Parse(textBox3.Text);
            double d = double.Parse(textBox4.Text);
            double z = (c * 0.01) / 12;
            double y = Math.Pow(1 + z, (b * 12));
            double x = y - 1;
            double w = y * z / x;
            double v = a - d;
            double u = v * w;
            double t = Math.Round(u);

            MessageBox.Show("月付額:"+Math.Round(u));
        }

        private  void button2_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            double c = double.Parse(textBox3.Text);
            double d = double.Parse(textBox4.Text);
            double z = (c * 0.01) / 12;
            double y = Math.Pow(1 + z, (b * 12));
            double x = y - 1;
            double w = y * z / x;
            double v = a - d;
            double u = v * w;

            MessageBox.Show("總付額:" + Math.Round(u)*12*b);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            double c = double.Parse(textBox3.Text);
            double d = double.Parse(textBox4.Text);
            double z = (c * 0.01) / 12;
            double y = Math.Pow(1 + z, (b * 12));
            double x = y - 1;
            double w = y * z / x;
            double v = a - d;
            double u = v * w;

            //呼叫work2-2帶入值
            work02_2 aa = new work02_2();
            aa.aa(textBox1.Text, textBox2.Text, textBox3.Text,
                   Math.Round(u), Math.Round(u) * 12 * b);
            aa.Show();
            





        }
    }
}
