using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Form
{
    public partial class Frm_M32_string : Form
    {
        public Frm_M32_string()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string A = "String";

            string B = A;

            B = "BBB";

            MessageBox.Show("A: " + A + " , B:" + B);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb1 = new StringBuilder();

            sb1.Append("StringBuilder 1");

            StringBuilder sb2 = new StringBuilder();

            sb2 = sb1;

            sb2.Append("\nStringBuilder 2");

            MessageBox.Show(sb1.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //string dir = "C:\\Users\\Student\\Desktop\\Lab_Csharp\\Image\\IU.jpg";

            string dir = @"C:\Users\Student\Desktop\Lab_Csharp\Image\IU.jpg";

            string result = "";

            result += Path.GetDirectoryName(dir)+"\n" +
                 Path.GetExtension(dir) +"\n"+
                 Path.GetFileName(dir) + "\n"+
                 Path.GetFullPath(dir);

            MessageBox.Show(result);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            labPassword.Text = IsStrongPassword(txtPassword.Text)? "密碼強度高": "密碼強度低";
            labID.Text = IsIDCorrect(txtID.Text) ? "身份證字號格式正確" : "身份證字號格式錯誤";
        }

        bool IsStrongPassword(string Password)
        {
            return Regex.IsMatch(Password, @"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{8,16}$");
        }

        bool IsIDCorrect(string ID)
        {
            return Regex.IsMatch(ID, @"^[A-Z]{1}[1-2]{1}[0-9]{8}$");
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            //labPassword.Text = IsStrongPassword(txtPassword.Text) ? "密碼強度高" : "密碼強度低";

            if (IsStrongPassword(txtPassword.Text))
            {
                labPassword.Text = "密碼強度高";
                timePassword.Enabled = false;
                labPassword.BackColor = Color.Transparent;
                labPassword.ForeColor = Color.Black;
            }
            else
            {
                labPassword.Text = "密碼強度低";
                timePassword.Enabled = true;
            }
        }


        bool flag = true;
        private void timePassword_Tick(object sender, EventArgs e)
        {
            if (flag)
            {
                labPassword.BackColor = Color.Yellow;
                labPassword.ForeColor = Color.Red;
            }
            else
            {
                labPassword.BackColor = Color.Red;
                labPassword.ForeColor = Color.Yellow;
            }
            flag = !flag;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string str = "除了無奈還剩下了什麼呢";

            char c = str[2];

            MessageBox.Show(c.ToString() + ", Length: " + str.Length);

            string result = "";

            //for(int i = 0; i<str.Length; i++)
            //{
            //    result += str[i] + "\n";
            //}

            foreach(char item in str)
            {
                result += item + "\n";
            }

            MessageBox.Show(result);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string[] lyrics =
            {
                "我想和你一起",
                "趕走天上的烏雲",
                "從那沙灘上驚醒",
                "說說這心情",
                "就像海浪捲在風裡",
                "撐了傘也措手不及"
            };

            string result = "";
            foreach(string str in lyrics)
            {
                result += str + "\n";
            }

            MessageBox.Show(result);
        }
    }
}
