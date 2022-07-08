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
    public partial class work3 : Form
    {
        public work3()
        {
            InitializeComponent();
        }

        private int beer;
        private int tequila;
        private int whisky;
        private int wine;

        private int beertotal;
        private int tequilatota;
        private int whiskytotal;
        private int winetotal;
        int AA;

        void total()
        {
            AA = beer * 120 + tequila * 180 + whisky * 120 + wine * 150;
            textBox2.Text = "NT$" + AA;
        }
        void list()
        {
            //string 安安 = "啤酒x" + beer + "共NT$" + beer * 120 + "元" +
            //    "\r\n龍舌蘭x" + tequila + "共NT$" + tequila * 180 + "元" +
            //    "\r\n威士忌x" + whisky + "共NT$" + whisky * 120 + "元" +
            //    "\r\n紅酒x" + wine + "共NT$" + wine * 150 + "元";
            //textBox1.Text = 安安;

            beertotal = beer * 120;
            tequilatota = tequila * 180;
            whiskytotal = whisky * 120;
            winetotal = wine * 150;

            textBox1.Text = "";

            if (beer > 0)
            {
                textBox1.Text += $"啤酒x{beer}共NT${beertotal}\r\n";
            }
            if (tequila > 0)
            {
                textBox1.Text += $"龍舌蘭x{tequila}共NT${tequilatota}\r\n";
            }
            if (whisky > 0)
            {
                textBox1.Text += $"威士忌x{whisky}共NT${whiskytotal}\r\n";
            }
            if (wine>0)
            {
                textBox1.Text += $"紅酒x{wine}共NT${winetotal}\r\n";
            }


        }

        private void btn_beer_Click(object sender, EventArgs e)
        {
            beer ++;
            total();  //int AA = beer * 120 + tequila * 180 + whisky * 120 + wine * 150;
                      //textBox2.Text = "NT$" + AA;
            list();


        }

        private void btn_tequila_Click(object sender, EventArgs e)
        {
            tequila ++;
            total();  //int AA = beer * 120 + tequila * 180 + whisky * 120 + wine * 150;
                      //textBox2.Text = "NT$" + AA;
            list();
        }

        private void btn_whisky_Click(object sender, EventArgs e)
        {
            whisky++;
            total();  //int AA = beer * 120 + tequila * 180 + whisky * 120 + wine * 150;
                      //textBox2.Text = "NT$" + AA;
            list();
        }

        private void btn_wine_Click(object sender, EventArgs e)
        {
            wine++;
            total();  //int AA = beer * 120 + tequila * 180 + whisky * 120 + wine * 150;
                      //textBox2.Text = "NT$" + AA;
            list();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (AA==0)
            {
               DialogResult result =MessageBox.Show("尚未點餐","確認付款",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("總金額:" +AA.ToString()+"元",
                    "確認付款",MessageBoxButtons.OKCancel);
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (AA == 0)
            {
                DialogResult result = MessageBox.Show("尚未點餐", "確認付款",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
               DialogResult result= MessageBox.Show("總金額:"+AA+"元"+
                   "\n折扣金額:"+(AA*0.9).ToString(), "確認付款",MessageBoxButtons.OKCancel);
            }
        }
        
        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Text = "尚未購物";
            textBox2.Text = "NT$ 0";
            beer = 0;
            tequila = 0;
            whisky = 0;
            wine = 0;

        }
    }
}
