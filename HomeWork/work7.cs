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
    public partial class work7 : Form
    {
        public work7()
        {
            InitializeComponent();
        }
        bool OX = true;

        void 空值復原()
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
        }

        void O贏()
        {

            if (button1.Text == button2.Text && button2.Text == button3.Text &&
               button1.Text != "" && button2.Text != "" && button3.Text != "")
            {
                MessageBox.Show("O方獲勝！");
                空值復原();
            }
            if (button4.Text == button5.Text && button5.Text == button6.Text &&
               button4.Text != "" && button5.Text != "" && button6.Text != "")
            {
                MessageBox.Show("O方獲勝！");
                空值復原();
            }
            if (button7.Text == button8.Text && button8.Text == button9.Text &&
               button7.Text != "" && button8.Text != "" && button9.Text != "")
            {
                MessageBox.Show("O方獲勝！");
                空值復原();
            }
            if (button1.Text == button4.Text && button4.Text == button7.Text &&
               button1.Text != "" && button4.Text != "" && button7.Text != "")
            {
                MessageBox.Show("O方獲勝！");
                空值復原();
            }
            if (button2.Text == button5.Text && button5.Text == button8.Text &&
               button2.Text != "" && button5.Text != "" && button8.Text != "")
            {
                MessageBox.Show("O方獲勝！");
                空值復原();
            }
            if (button3.Text == button6.Text && button6.Text == button9.Text &&
               button3.Text != "" && button6.Text != "" && button9.Text != "")
            {
                MessageBox.Show("O方獲勝！");
                空值復原();
            }
            if (button3.Text == button5.Text && button5.Text == button7.Text &&
               button3.Text != "" && button5.Text != "" && button7.Text != "")
            {
                MessageBox.Show("O方獲勝！");
                空值復原();
            }
            if (button1.Text == button5.Text && button5.Text == button9.Text &&
               button1.Text != "" && button5.Text != "" && button9.Text != "")
            {
                MessageBox.Show("O方獲勝！");
                空值復原();
            }


        }
        void X贏()
        {
            if (button1.Text == button2.Text && button2.Text == button3.Text &&
                      button1.Text != "" && button2.Text != "" && button3.Text != "")
            {
                MessageBox.Show("X方獲勝！");
                空值復原();
            }
            if (button4.Text == button5.Text && button5.Text == button6.Text &&
               button4.Text != "" && button5.Text != "" && button6.Text != "")
            {
                MessageBox.Show("X方獲勝！");
                空值復原();
            }
            if (button7.Text == button8.Text && button8.Text == button9.Text &&
               button7.Text != "" && button8.Text != "" && button9.Text != "")
            {
                MessageBox.Show("X方獲勝！");
                空值復原();
            }
            if (button1.Text == button4.Text && button4.Text == button7.Text &&
               button1.Text != "" && button4.Text != "" && button7.Text != "")
            {
                MessageBox.Show("X方獲勝！");
                空值復原();
            }
            if (button2.Text == button5.Text && button5.Text == button8.Text &&
               button2.Text != "" && button5.Text != "" && button8.Text != "")
            {
                MessageBox.Show("X方獲勝！");
                空值復原();
            }
            if (button3.Text == button6.Text && button6.Text == button9.Text &&
               button3.Text != "" && button6.Text != "" && button9.Text != "")
            {
                MessageBox.Show("X方獲勝！");
                空值復原();
            }
            if (button3.Text == button5.Text && button5.Text == button7.Text &&
               button3.Text != "" && button5.Text != "" && button7.Text != "")
            {
                MessageBox.Show("X方獲勝！");
                空值復原();
            }
            if (button1.Text == button5.Text && button5.Text == button9.Text &&
               button1.Text != "" && button5.Text != "" && button9.Text != "")
            {
                MessageBox.Show("X方獲勝！");
                空值復原();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (OX == true)
            {
                button1.Text = "O";
                OX = false;
                button1.Enabled = false;
                O贏();
            }
            else
            {
                button1.Text = "X";
                OX = true;
                button1.Enabled = false;
                X贏();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (OX == true)
            {
                button2.Text = "O";
                OX = false;
                button2.Enabled = false;
                O贏();
            }
            else
            {
                button2.Text = "X";
                OX = true;
                button2.Enabled = false;
                X贏();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (OX == true)
            {
                button3.Text = "O";
                OX = false;
                button3.Enabled = false;
                O贏();
            }
            else
            {
                button3.Text = "X";
                OX = true;
                button3.Enabled = false;
                X贏();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (OX == true)
            {
                button4.Text = "O";
                OX = false;
                button4.Enabled = false;
                O贏();
            }
            else
            {
                button4.Text = "X";
                OX = true;
                button4.Enabled = false;
                X贏();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (OX == true)
            {
                button5.Text = "O";
                OX = false;
                button5.Enabled = false;
                O贏();
            }
            else
            {
                button5.Text = "X";
                OX = true;
                button5.Enabled = false;
                X贏();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (OX == true)
            {
                button6.Text = "O";
                OX = false;
                button6.Enabled = false;
                O贏();
            }
            else
            {
                button6.Text = "X";
                OX = true;
                button6.Enabled = false;
                X贏();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (OX == true)
            {
                button7.Text = "O";
                OX = false;
                button7.Enabled = false;
                O贏();
            }
            else
            {
                button7.Text = "X";
                OX = true;
                button7.Enabled = false;
                X贏();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (OX == true)
            {
                button8.Text = "O";
                OX = false;
                button8.Enabled = false;
                O贏();
            }
            else
            {
                button8.Text = "X";
                OX = true;
                button8.Enabled = false;
                X贏();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (OX == true)
            {
                button9.Text = "O";
                OX = false;
                button9.Enabled = false;
                O贏();
            }
            else
            {
                button9.Text = "X";
                OX = true;
                button9.Enabled = false;
                X贏();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            空值復原();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    }

