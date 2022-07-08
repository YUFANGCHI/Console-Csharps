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
    public partial class work02_2 : Form
    {
        public work02_2()
        {
            InitializeComponent();
        }
        public void aa(string a, string b, string c, double e, double f)
        {
            label6.Text =a;
            label7.Text =b;
            label8.Text =c;
            label9.Text =e.ToString();
            label10.Text =f.ToString();


            
        }

    }
}
