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
    public partial class work10 : Form
    {
        public work10()
        {
            InitializeComponent();
        }
        int 點擊次數 = 1;
    

        private void button1_Click(object sender, EventArgs e)
        {
            button3.Enabled = true;
            點擊次數++;
            string 姓名 = textBox1.Text;
            double 國文 = double.Parse(textBox2.Text);
            double 英文 = double.Parse(textBox3.Text);
            double 數學 = double.Parse(textBox4.Text);
            double 總分 = 國文 + 英文 + 數學;
            double 平均 = Math.Round(總分 / 3);
            double[] 比較 = new double[3] { 國文, 數學, 英文 };
            double 最大;
            double 最小;
            最大 = 比較[0];
            最小 = 比較[0];
            國文總和 += 國文;
             國文平均 = Math.Round(國文總和 / 點擊次數);
            數學總和 += 數學;
             數學平均 = Math.Round(數學總和 / 點擊次數);
            英文總和 += 英文;
             英文平均 = Math.Round(英文總和 / 點擊次數);
            if (國文最高 <= 國文) { 國文最高 = 國文; }
            if (國文最低 >= 國文) { 國文最低 = 國文; }
            if (數學最高 <= 數學) { 數學最高 = 數學; }
            if (數學最高 >= 數學) { 數學最低 = 數學; }
            if (英文最高 <= 英文) { 英文最高 = 英文; }
            if (英文最高 >= 英文) { 英文最低 = 英文; }

            for (int i = 0; i < 3; i++)
            {
                if (比較[i] >= 最大)
                {
                    最大 = 比較[i];
                }
            }
            for (int i = 0; i < 3; i++)
            {
                if (比較[i] <= 最小)
                {
                    最小 = 比較[i];
                }
            }
            label5.Text += $"{姓名}  {國文}  " +
                $"{英文}  {數學}  {總分}  {平均}  最高：{最大} 最低：{最小}\n";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button3.Enabled = true;
            Random number = new Random();
            double 國文 = number.Next(0, 100);
            double 英文 = number.Next(0, 100);
            double 數學 = number.Next(0, 100);
            double 總分 = 國文 + 英文 + 數學;
            double 平均 = Math.Round(總分 / 3);
            double[] 比較 = new double[3] { 國文, 英文, 數學 };
            string[] 中文科目 = new string[3] { "國文", "英文", "數學" };
            double 最大 = 比較[0];
            double 最小 = 比較[0];
            string 大科目 = 中文科目[0];
            string 小科目 = 中文科目[0];
            國文總和 += 國文;
            國文平均 = Math.Round(國文總和 / 點擊次數);
            數學總和 += 數學;
            數學平均 = Math.Round(數學總和 / 點擊次數);
            英文總和 += 英文;
            英文平均 = Math.Round(英文總和 / 點擊次數);
            if (國文最高 <= 國文) { 國文最高 = 國文; }
            if (國文最低 >= 國文) { 國文最低 = 國文; }
            if (數學最高 <= 數學) { 數學最高 = 數學; }
            if (數學最高 >= 數學) { 數學最低 = 數學; }
            if (英文最高 <= 英文) { 英文最高 = 英文; }
            if (英文最高 >= 英文) { 英文最低 = 英文; }
            for (int i = 0; i < 3; i++)
            {
                if (比較[i] >= 最大)
                {
                    最大 = 比較[i];
                    大科目 = 中文科目[i];
                }
            }
            for (int i = 0; i < 3; i++)
            {
                if (比較[i] <= 最小)
                {
                    最小 = 比較[i];
                    小科目 = 中文科目[i];
                }
            }
            label5.Text += $"{點擊次數++}  {國文}  " +
                $"{英文}  {數學}  {總分}  {平均}  {大科目}{最大}{小科目}{最小}\n";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button3.Enabled = true;
            Random number = new Random();

            for (int a = 0; a < 20; a++)
            {
                double 國文 = number.Next(0, 100);
                double 英文 = number.Next(0, 100);
                double 數學 = number.Next(0, 100);
                double 總分 = 國文 + 英文 + 數學;
                double 平均 = Math.Round(總分 / 3);
                double[] 比較 = new double[3] { 國文, 英文, 數學 };
                string[] 中文科目 = new string[3] { "國文", "英文", "數學" };
                double 最大= 比較[0];
                double 最小= 比較[0];
                string 大科目 = 中文科目[0];
                string 小科目 = 中文科目[0];
                國文總和 += 國文;
                國文平均 = Math.Round(國文總和 / 點擊次數);
                數學總和 += 數學;
                數學平均 = Math.Round(數學總和 / 點擊次數);
                英文總和 += 英文;
                英文平均 = Math.Round(英文總和 / 點擊次數);
                if (國文最高 <= 國文) { 國文最高 = 國文; }
                if (國文最低 >= 國文) { 國文最低 = 國文; }
                if (數學最高 <= 數學) { 數學最高 = 數學; }
                if (數學最高 >= 數學) { 數學最低 = 數學; }
                if (英文最高 <= 英文) { 英文最高 = 英文; }
                if (英文最高 >= 英文) { 英文最低 = 英文; }

                for (int i = 0; i < 3; i++)
                {
                    if (比較[i] >= 最大)
                    {
                        最大 = 比較[i];
                        大科目 = 中文科目[i];
                    }
                }
                for (int i = 0; i < 3; i++)
                {
                    if (比較[i] <= 最小)
                    {
                        最小 = 比較[i];
                        小科目 = 中文科目[i];
                    }
                }
                label5.Text += $"{點擊次數++}  {國文}  " +
                    $"{英文}  {數學}  {總分}  {平均}  {大科目}{最大}{小科目}{最小}\n";
            }

        }
        double 國文總和 = 0;
        double 英文總和 = 0;
        double 數學總和 = 0;
        double 國文平均 = 0;
        double 英文平均 = 0;
        double 數學平均 = 0;
        double 國文最高 = 0;
        double 國文最低 = 100;
        double 數學最高 = 0;
        double 英文最低 = 100;
        double 英文最高 = 0;
        double 數學最低 = 100;
        private void button3_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button5.Enabled = false;
            textBox6.Text = $"總分  {國文總和}  {英文總和}  {數學總和}\r\n" +
                $"平均  {國文平均}  {英文平均}  {數學總和}\r\n" +
                $"最高分  {國文最高}  {數學最高}  {英文最高}\r\n" +
                $"最低分  {國文最低}  {英文最低}  {數學最低}";


        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button5.Enabled = true;
            label5.Text = "";
            textBox6.Text = "";
            點擊次數 = 1;
            國文總和 = 0;
            英文總和 = 0;
            數學總和 = 0;
            國文平均 = 0;
            英文平均 = 0;
            數學平均 = 0;
            國文最高 = 0;
            國文最低 = 100;
            數學最高 = 0;
            英文最低 = 100;
            英文最高 = 0;
            數學最低 = 100;



        }
    }
}

