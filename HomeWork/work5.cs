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
    public partial class work5 : Form
    {
        public work5()
        {
            InitializeComponent();
        }
        
        public struct suject
        {
            public string 姓名;
            public int 國文, 數學, 英文;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            suject 科目;

            科目.姓名 = textBox1.Text;
            科目.國文 = int.Parse(textBox2.Text);
            科目.英文 = int.Parse(textBox3.Text);
            科目.數學 = int.Parse(textBox4.Text);
            totalchinese += 科目.國文;
            totalenglish += 科目.英文;
            totalmath += 科目.數學;

            double 總分 = 科目.國文 + 科目.英文 + 科目.數學;
            double 平均 = Math.Round(總分 / 3, 1);

            string 前項 = $"\r\n{科目.姓名}    {科目.國文}   {科目.英文}   {科目.數學}   {總分}   {平均}";

            if (科目.國文 >= 科目.數學 && 科目.數學 >= 科目.英文)
            {
                textBox5.Text += $"{前項}  最低{科目.英文}   最高{科目.國文}   ";
            }
            else if (科目.國文 >= 科目.英文 && 科目.英文 >= 科目.數學)
            {
                textBox5.Text += $"{前項}  最低{科目.數學}   最高{科目.國文}   ";
            }
            else if (科目.數學 >= 科目.英文 && 科目.英文 >= 科目.國文)
            {
                textBox5.Text += $"{前項}  最低{科目.國文}   最高{科目.數學}   ";
            }
            else if (科目.數學 >= 科目.國文 && 科目.國文 >= 科目.英文)
            {
                textBox5.Text += $"{前項}  最低{科目.英文}   最高{科目.數學}   ";
            }
            else if (科目.英文 >= 科目.國文 && 科目.國文 >= 科目.數學)
            {
                textBox5.Text += $"{前項}  最低{科目.數學}   最高{科目.英文}   ";
            }
            else if (科目.英文 >= 科目.數學 && 科目.數學 >= 科目.國文)
            {
                textBox5.Text += $"{前項}  最低{科目.國文}   最高{科目.英文}   ";
            }
            else if (科目.英文 == 科目.國文 && 科目.國文 == 科目.數學)
            {
                textBox5.Text += $"{前項}  最低{科目.國文}   最高{科目.英文}   ";
            }


        }


        int i = 1;
        private void button2_Click(object sender, EventArgs e)
        {
            Random numger = new Random();
            int 隨機資料 = numger.Next(0, 100);
            int 隨機資料2 = numger.Next(0, 100);
            int 隨機資料3 = numger.Next(0, 100);

            double 總分 = 隨機資料 + 隨機資料2 + 隨機資料3;
            double 平均 = Math.Round(總分 / 3, 1);
            int 姓名 = i++;
            totalchinese += 隨機資料;
            totalenglish += 隨機資料2;
            totalmath += 隨機資料3;
            string 前項 = $"\r\n{姓名}    {隨機資料}   {隨機資料2}   {隨機資料3}   {總分}   {平均}";

            if (隨機資料 >= 隨機資料3 && 隨機資料3 >= 隨機資料2)
            {
                this.textBox5.Text += $"{前項}  英文{隨機資料2}   國文{隨機資料}   ";
            }
            else if (隨機資料 >= 隨機資料2 && 隨機資料2 >= 隨機資料3)
            {
                this.textBox5.Text += $"{前項}  數學{隨機資料3}   國文{隨機資料}   ";
            }
            else if (隨機資料3 >= 隨機資料2 && 隨機資料2 >= 隨機資料)
            {
                this.textBox5.Text += $"{前項}  國文{隨機資料}   數學{隨機資料3}   ";
            }
            else if (隨機資料3 >= 隨機資料 && 隨機資料 >= 隨機資料2)
            {
                this.textBox5.Text += $"{前項}  英文{隨機資料2}   數學{隨機資料3}   ";
            }
            else if (隨機資料3 >= 隨機資料 && 隨機資料 >= 隨機資料3)
            {
                this.textBox5.Text += $"{前項}  數學{隨機資料3}   英文{隨機資料2}   ";
            }
            else if (隨機資料2 >= 隨機資料3 && 隨機資料3 >= 隨機資料)
            {
                this.textBox5.Text += $"{前項}  國文{隨機資料}   英文{隨機資料2}   ";
            }
            else if (隨機資料2 == 隨機資料 && 隨機資料 == 隨機資料3)
            {
                this.textBox5.Text += $"{前項}  國文{隨機資料}   英文{隨機資料2}   ";
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Random number = new Random();
            string result = "";

            for (int i = 0; i <= 20; i++)
            {   
                int 隨機資料 = number.Next(0, 100);
                int 隨機資料2 = number.Next(0, 100);
                int 隨機資料3 = number.Next(0, 100);
                int 姓名 = i;
                double 總分 = 隨機資料 + 隨機資料2 + 隨機資料3;
                double 平均 = Math.Round(總分 / 3,1);
                totalchinese += 隨機資料;
                totalenglish += 隨機資料2;
                totalmath += 隨機資料3;
                

                string 前項 = $"\r\n{姓名}    {隨機資料}   {隨機資料2}   {隨機資料3}   {總分}   {平均}";


                if (隨機資料 >= 隨機資料3 && 隨機資料3 >= 隨機資料2)
                {
                    this.textBox5.Text += $"{前項}  英文{隨機資料2}   國文{隨機資料}   ";
                }
                else if (隨機資料 >= 隨機資料2 && 隨機資料2 >= 隨機資料3)
                {
                    this.textBox5.Text += $"{前項}  數學{隨機資料3}   國文{隨機資料}   ";
                }
                else if (隨機資料3 >= 隨機資料2 && 隨機資料2 >= 隨機資料)
                {
                    this.textBox5.Text += $"{前項}  國文{隨機資料}   數學{隨機資料3}   ";
                }
                else if (隨機資料3 >= 隨機資料 && 隨機資料 >= 隨機資料2)
                {
                    this.textBox5.Text += $"{前項}  英文{隨機資料2}   數學{隨機資料3}   ";
                }
                else if (隨機資料3 >= 隨機資料 && 隨機資料 >= 隨機資料3)
                {
                    this.textBox5.Text += $"{前項}  數學{隨機資料3}   英文{隨機資料2}   ";
                }
                else if (隨機資料2 >= 隨機資料3 && 隨機資料3 >= 隨機資料)
                {
                    this.textBox5.Text += $"{前項}  國文{隨機資料}   英文{隨機資料2}   ";
                }
                else if (隨機資料2 == 隨機資料 && 隨機資料 == 隨機資料3)
                {
                    this.textBox5.Text += $"{前項}  國文{隨機資料}   英文{隨機資料2}   ";
                }

            }
            textBox5.Text += result;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox5.Text = "姓名    國文   英文   數學   總分   平均   最低   最高   ";
            textBox6.Text = "";
            button1.Enabled = true;
            button2.Enabled = true;
            button5.Enabled = true;
        }
         int totalchinese;
         int totalmath;
         int totalenglish;
        int totaltotal;
        


        private void button3_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button5.Enabled = false;
            
            textBox6.Text = $"{totalchinese}   {totalenglish}   {totalmath}\r\n" +
                            $" ";

        }
    }
}
