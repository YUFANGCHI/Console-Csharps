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
    public partial class work8cs : Form
    {
        public work8cs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            work01 W1 = new work01();
            W1.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(W1);
            W1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            work02 W1 = new work02();
            W1.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(W1);
            W1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            work3 W1 = new work3();
            W1.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(W1);
            W1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            work4 W1 = new work4();
            W1.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(W1);
            W1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            work10 W1 = new work10();
            W1.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(W1);
            W1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            work6 W1 = new work6();
            W1.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(W1);
            W1.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            work7 W1 = new work7();
            W1.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(W1);
            W1.Show();
        }
    }
}
