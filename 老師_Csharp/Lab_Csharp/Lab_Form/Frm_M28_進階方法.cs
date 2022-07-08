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
    public partial class Frm_M28_進階方法 : Form
    {
        public Frm_M28_進階方法()
        {
            InitializeComponent();
        }

        void Swap(ref int A ,ref int B)
        {
            int T = A;
            A = B;
            B = T;
        }
        void Swap(ref string A , ref string B)
        {
            string T = A;
            A = B;
            B = T;
        }
        void Swap(ref Point A , ref Point B)
        {
            Point T = A;
            A = B;
            B = T;
        }
        void Swap(ref Member A , ref Member B)
        {
            Member T = A;
            A = B;
            B = T;
        }
        void Swap(ref Product A, ref Product B)
        {
            Product T = A;
            A = B;
            B = T;
        }

        void GenericSwap<Tt>(ref Tt A , ref Tt B)
        {
            Tt T = A;
            A = B;
            B = T;
        }

        void GenericSwap<Tt,Yy>(ref Tt A, ref Tt B)
        {
            Tt T = A;
            A = B;
            B = T;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 100, b = 200;

            MessageBox.Show($"a: {a} , b:{b}");

            Swap(ref a, ref b);

            MessageBox.Show($"a: {a} , b:{b}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string a = "AAA", b = "BBB";

            MessageBox.Show($"a: {a} , b:{b}");

            Swap(ref a, ref b);

            MessageBox.Show($"a: {a} , b:{b}");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Point a = new Point(100, 100), b = new Point(200, 200);

            MessageBox.Show($"a: {a} , b:{b}");

            Swap(ref a, ref b);

            MessageBox.Show($"a: {a} , b:{b}");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Member a = new Member() { Name = "IU", Age = 29 },
            b = new Member() { Name = "裡之恩", Age = 28 };

            MessageBox.Show($"a: {a.Name} , b:{b.Name}");

            Swap(ref a, ref b);

            MessageBox.Show($"a: {a.Name} , b:{b.Name}");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Product a = new Product("AAA", 1000), b = new Product("BBB", 2000);

            MessageBox.Show($"a: {a.ProductName} , b:{b.ProductName}");

            Swap(ref a, ref b);

            MessageBox.Show($"a: {a.ProductName} , b:{b.ProductName}");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int a = 100, b = 200;
            GenericSwap<int>(ref a, ref b);
            MessageBox.Show($"a: {a} , b:{b}");

            string s1 = "AAA", s2 = "BBB";
            GenericSwap<string>(ref s1, ref s2);
            MessageBox.Show($"a: {s1} , b:{s2}");
        }
    }
}
