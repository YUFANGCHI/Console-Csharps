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
    public partial class Frm_M20 : Form
    {
        public Frm_M20()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double d = 3.4;

            //int i = (int)d;

            int i = Convert.ToInt32(d);

            MessageBox.Show(i.ToString());
        }

        bool flag = true;

        private void button2_Click(object sender, EventArgs e)
        {          
            if (flag)
            {
                btnReverse.BackColor = Color.Ivory;
                //flag = false;
            }
            else
            {
                btnReverse.BackColor = Color.LemonChiffon;
                //flag = true;
            }

            flag = !flag;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            btnReverse.BackColor = flag ? Color.Ivory : Color.LemonChiffon;
            flag = !flag;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // 90 ~ 100 A
            // 80 ~ 89 B
            // 70 ~ 79 C
            // 60 ~ 69 D
            // ~59 E

            //int score = int.Parse(txtScore.Text);
            int score = 0;
            
            if(int.TryParse(txtScore.Text , out score))
            {
                if (score >= 90 && score <= 100)
                    labGrade.Text = "A級";
                else if (score >= 80)
                    labGrade.Text = "B級";
                else if (score >= 70)
                    labGrade.Text = "C級";
                else if (score >= 60)
                    labGrade.Text = "D級";
                else
                    labGrade.Text = "E級";

                //switch (score)
                //{
                //    case 100:
                //        labGrade.Text = "A級";
                //        break;
                //    case 99:
                //        labGrade.Text = "A級";
                //        break;
                //    case 98:
                //        labGrade.Text = "A級";
                //        break;
                //}
            }
            else
            {
                MessageBox.Show("請輸入正確的數字格式!!!!!");
                txtScore.Text = "";
                //txtScore.Clear();
                txtScore.Focus();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
           DialogResult result = MessageBox.Show("今天是星期二?", "問?"
                , MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            switch (result)
            {
                case DialogResult.Yes:
                    MessageBox.Show("Yes");
                    break;
                case DialogResult.No:
                    MessageBox.Show("No");
                    break;
                default:
                    MessageBox.Show("default");
                    break;
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int i = 0;
            string result = "";

            while (i <= 9)
            {
                result += i + "\n";
                i++;

                if(i % 5 == 0)
                {
                    break;
                }
            }

            MessageBox.Show(result);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int i = 10;
            string result = "";

            do
            {
                result += i + "\n";
                i++;
            } while (i <= 9);

            MessageBox.Show(result);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string result = "";

            //for (int i = 0; i <= 9; i++)
            //{
            //    result += i + "\n";
            //}

            //for(int i = 0 , j = 10 , k =5; i<= j+k; i+=2, k++)
            //{
            //    result += $"i = {i} , j = {j} , k = {k}\n";
            //}

            //for(; ; )
            //{
            //    result += "";
            //}

            //for (int i = 0; i <= 9; )
            //{
            //    result += i++ + "\n";
            //}

            int i = 0;

            for(;i<=9;)
            {
                result += i + "\n";
                i++;
            }

            MessageBox.Show(result);
        }

        private void button8_Click(object sender, EventArgs e)
        {

            foreach(Control item in this.Controls)
            {
                //if(item.GetType()!= typeof( Button))
                //{
                //    continue;
                //}

                if(!(item is Button))
                {
                    continue;
                }

                item.Left -= 10;
                item.Top -= 10;
                item.BackColor = Color.HotPink;
                item.ForeColor = Color.PeachPuff;
            }

            //Control btn = new Button();

        }
    }
}
