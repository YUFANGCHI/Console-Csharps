using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_Form
{
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = "string";
            string b = a;
            b = "200";

            MessageBox.Show("a:"+a+",b:"+b);
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder strb = new StringBuilder(); 
            //  StringBuilder(記憶體較小，需要new) = string(記憶體較大)

            strb.Append ( "StringBuilder");

            StringBuilder strb2 = new StringBuilder();

            strb2 = strb;

            strb2.Append("\nStringBuilder2");

            MessageBox.Show(strb.ToString());


        }

        private void button3_Click(object sender, EventArgs e)
        {
            //string drr = "C:\\Users\\Student\\Desktop\\0621 - master"; \\ 讓反斜線可以當字串
            string drr= @"C:\Users\Student\Desktop\0621 - master"; //  @  讓反斜線可以當字串

            string result = "";

            result = Path.GetDirectoryName(drr) + "\n"+
                Path.GetFileName(drr)+"\n"+
                Path.GetExtension(drr);

            MessageBox.Show(result);

            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string str = "123456";
            char c = str[5];

            MessageBox.Show(c.ToString(), str.Length.ToString());

            string result = "";
            for (int i = 0;i<str.Length;i++)
            {
                result += str[i]+"\n";
            }
            MessageBox.Show(result);
        }
    }
}
