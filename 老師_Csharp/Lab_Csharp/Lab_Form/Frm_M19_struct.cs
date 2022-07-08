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
    public partial class Frm_M19_struct : Form
    {
        public Frm_M19_struct()
        {
            InitializeComponent();
        }

        string result="產品";
        int count = 0;
        decimal totalPrice = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            //Product pro;
            //pro.ProductName = txtProductName.Text;
            //pro.ProductPrice = decimal.Parse(txtProductPrice.Text);

            //Product pro = new Product();
            //pro.ProductName = txtProductName.Text;
            //pro.ProductPrice = decimal.Parse(txtProductPrice.Text);

            //Product pro = new Product(txtProductName.Text, decimal.Parse(txtProductPrice.Text));

            //result += "\n名稱：" + pro.ProductName + "，單價：" + pro.ProductPrice;

            decimal price = 0;
            bool isNum = decimal.TryParse(txtProductPrice.Text, out price);

            if (isNum)
            {
                Product pro = new Product(txtProductName.Text, price);
                result += $"\n名稱：{pro.ProductName}，單價：{pro.ProductPrice:c0}";
                count++;
                totalPrice += pro.ProductPrice;
            }
            else
            {
                MessageBox.Show("請輸入正確的數字格式!!!!!");
                //txtProductPrice.Text = "";
                txtProductPrice.Clear();
                txtProductPrice.Focus();
            }            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //labShow.Text = result + "\n------------\n產品總數：" + count
            //    + "\n總價："+totalPrice
            //    +"\n平均單價："+ totalPrice/count;

            labShow.Text = $"{result}\n------------\n產品總數：{count}\n總價：" +
                $"{totalPrice:c0}\n平均單價：{totalPrice / count:c0}";
        }
    }
}
