﻿using System;
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
    public partial class Frm_M07 : Form
    {
        public Frm_M07()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Member mem1 = new Member();
            mem1.Name = "梁延睿";
            mem1.Age = 24;

            //string name = mem1.Name;
            //int age = mem1.Age;

            //MessageBox.Show("姓名: " + name + ", 年齡: " + age);

            MessageBox.Show("姓名: " + mem1.Name + ", 年齡: " + mem1.Age);

            Member mem2 = new Member()
            {
                Name = "李知恩",
                Age = 29
            };

            MessageBox.Show("姓名: " + mem2.Name + ", 年齡: " + mem2.Age);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.button1.Click += new System.EventHandler(this.button1_Click);

            btnRegister01.Click += new EventHandler(btnRegister01Click);

            btnRegister02.Click += BtnRegister02_Click_1;
            
            int i = 1;
            //i += 2;
            //i = i + 2;

            i -= 2;
            i = i - 2;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            btnRegister01.Click -= btnRegister01Click;
            
        }

        private void BtnRegister02_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Register02");
        }

        private void btnRegister01Click(object sender, EventArgs e)
        {
            MessageBox.Show("Register01");
        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {
            Payment pay;

            if(cmbDiscount.Text == "50%off")
            {
                pay = Discount50off;
            }
            else
            {
                pay = Discount20off;
            }

            double price = double.Parse(txtPrice.Text);

            double result = pay(price);

            MessageBox.Show(result.ToString());
        }

        delegate double Payment(double Price);

        double Discount50off(double Price)
        {
            return Price * 0.5;
        }

        double Discount20off(double Price)
        {
            return Price * 0.8;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Frm_M07 frm_M = new Frm_M07();
            //frm_M.Text = "new";

            //Text = "Set Property";
            this.Text = "Set Property";

            button1.BackColor = Color.CadetBlue;

            this.button2.ForeColor = Color.Fuchsia;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.button1.SetBounds(200, 200, 100, 100);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult result =  MessageBox.Show("請問今天是星期二嗎?", "問你喔"
                , MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if(result == DialogResult.Yes)
            {
                MessageBox.Show("今天不是喔");
            }
            else
            {
                MessageBox.Show("no or cancel");
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Frm_M02_HelloForm frmHello = new Frm_M02_HelloForm();
            //frmHello.Show();
            DialogResult result = frmHello.ShowDialog();

            if(result == DialogResult.OK)
            {
                MessageBox.Show("OK");
            }

            Frm_M02_HelloForm frm哈囉表單 = new Frm_M02_HelloForm();
            frm哈囉表單.Show();

            float f = 3.14F;

            double d = 3.14;

            decimal dm = 1000M;

        }
    }
}
