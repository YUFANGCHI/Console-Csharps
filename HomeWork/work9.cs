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
    public partial class work9 : Form
    {
        public work9()
        {
            InitializeComponent();
        }
        string name;
        int chin;
        int eng;
        int math;
        private void button1_Click(object sender, EventArgs e)
        {
            name = textBox1.Text;
            chin = int.Parse(textBox2.Text);
            eng = int.Parse(textBox3.Text);
            math = int.Parse(textBox4.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label5.Text = $"姓名：{name}\n國文：{chin}\n英文：{eng}\n數學：{math}";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (chin >= eng && eng >= math)
            {
                label6.Text = $"最高分：國文{chin}\n最低分：數學{math}";
            }
           else if (chin >= math && eng <= math)
            {
                label6.Text = $"最高分：國文{chin}\n最低分：英文{eng}";
            }
            else if (chin <= eng && eng <= math)
            {
                label6.Text = $"最高分：數學{math}\n最低分：國文{chin}";
            }
            else if (eng >= chin && chin >= math)
            {
                label6.Text = $"最高分：英文{eng}\n最低分：數學{math}";
            }
            else if (eng <= chin && chin <= math)
            {
                label6.Text = $"最高分：數學{math}\n最低分：英文{eng}";
            }
            else if (eng >= math && chin <= math)
            {
                label6.Text = $"最高分：英文{eng}\n最低分：國文{chin}";
            }
        
        }
    }
}
