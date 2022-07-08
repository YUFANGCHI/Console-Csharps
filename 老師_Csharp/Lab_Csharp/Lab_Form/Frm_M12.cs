using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Form
{
    public partial class Frm_M12 : Form
    {
        public Frm_M12()
        {
            InitializeComponent();            
        }

        int count = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            //count = count + 1;

            count += 1;

            labCount.Text = "Count: " + count;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = ++count;

            //count += 1;
            //int i = count;

            labCount.Text = "Count: " + count;

            MessageBox.Show(i.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i = count++;

            //int i = count; 
            //count += 1;

            labCount.Text = "Count: " + count;

            MessageBox.Show(i.ToString());

            const double Pi = 3.14;
            //Pi = 3.5;
        }

        private void button4_Click(object sender, EventArgs e)
        {           
            int a = 0;

            if (true)
            {
                int x = 100;
                x = 101;
                a = x;

                count += 2;
            }

            //x = 100;

            count += 1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //a
            count += 1;

            MessageBox.Show(Member.StaticGlobal);
        }

        UseStatic us = new UseStatic();

        private void button7_Click(object sender, EventArgs e)
        {          
            us.InstanceCount++;

            labInstance.Text = "Instance Count: " + us.InstanceCount;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            UseStatic.StaticCount++;

            labStatic.Text = "Static Count: " + UseStatic.StaticCount;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Frm_M02_HelloForm frm = new Frm_M02_HelloForm();
            frm.Show();
        }
    }
}
