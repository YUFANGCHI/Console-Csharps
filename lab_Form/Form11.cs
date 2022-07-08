using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_Form
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }
        void Swap(ref int a,ref int b)
        {
            int s = a;
            a = b;
            b = s;
        }
        void Swap(ref string a, ref string b)
        {
            string s = a;
            a = b;
            b = s;
        }

        void 泛型Swap<Tt>(ref Tt a,ref Tt b)
        {
            Tt s = a;
            a = b;
            b = s;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int a = 100, b = 200;

            MessageBox.Show($"{a},{ b}");

            Swap(ref a, ref b);

            MessageBox.Show($"{a},{ b}");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string a = "100", b = "200";

            MessageBox.Show($"{a},{ b}");

            Swap(ref a, ref b);

            MessageBox.Show($"{a},{ b}");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = 100, b = 200;

            泛型Swap<int>(ref a, ref b);

            MessageBox.Show($"{a},{ b}");

            string c = "100", d = "200";

            泛型Swap<string>(ref c, ref d);

            MessageBox.Show($"{a},{ b}");

        }
    }
}
