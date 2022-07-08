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
    public partial class Frm_M16 : Form
    {
        public Frm_M16()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal Dec = 10;

            MessageBox.Show(Dec.ToString());

            ByValueType(Dec);

            MessageBox.Show(Dec.ToString());
        }

        void ByValueType(decimal d)
        {
            d = 1000;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Member mem1 = new Member();
            mem1.Name = "aaa";
            mem1.Age = 20;

            ByReferenceType(mem1);

            MessageBox.Show(mem1.Name + " , " + mem1.Age);

        }

        void ByReferenceType(Member member)
        {
            member.Age = 30;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            decimal Dec = 10;

            MessageBox.Show(Dec.ToString());

            Byref(ref Dec);

            MessageBox.Show(Dec.ToString());
        }

        void Byref(ref decimal d)
        {
            d = 1000;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a;

            Byout(out a);

            MessageBox.Show(a.ToString());
        }

        void Byout(out int Age )
        {
            Age = 10;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string chi = MyParams("國文", 80, 90, 70);
            MessageBox.Show(chi);

            string math = MyParams("數學", 60, 70, 80, 90);
            MessageBox.Show(math);

            string eng = MyParams("英文" , new int[3] { 60,50,90 });
            MessageBox.Show(eng);
        }

        string MyParams (string Course , params int[] Scores)
        {
            int Total = 0;

            for(int i = 0; i< Scores.Length;i++)
            {
                //Total = Total + Scores[i];
                Total += Scores[i];
            }

            return Course + " 得總成績: " + Total;
        }

    }
}
