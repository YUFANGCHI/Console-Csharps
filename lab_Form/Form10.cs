using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static lab_Form.day2;

namespace lab_Form
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int[] math = new int[4];  //先建立一個陣列
            //math[0] = 1;
            //math[1] = 2;
            //math[2] = 3;
            //math[3] = 4;

            //int[] math = new int[4] { 1, 2,3, 4 };

            int[] math ={ 1, 2, 3, 4 };
            string result = "";  // for迴圈需要一個值
            
            for(int i=0; i<math.Length; i++) //  for ( 設定起始值開始跑 ; 何時停止 ; 增加的幅度 ) 
            {
                result += math[i]+"\n"; 
            }

            MessageBox.Show(result);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[,] arr = new int[3, 2];  //建立多維振烈
            string result = "";  //迴圈需要值

            arr[0, 0] = 1;
            arr[0, 1] = 2;
            arr[1, 0] = 3;
            arr[1, 1] = 4;
            arr[2, 0] = 5;
            arr[2, 1] = 6;

            for (int i = 0;i<arr.GetLength(0);i++)  //第一個陣列
            {
                for (int a=0;a<arr.GetLength(1);a++) //第二個陣列
                {
                    result += $"arr[{i},{a}]->{arr[i, a]}\n";
                }
              
            }
            MessageBox.Show(result);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            int[] intarr = Crry(20);
            string result = "";
            //for (int i = 0; i < intarr.Length; i++) //  for ( 設定起始值開始跑 ; 何時停止 ; 增加的幅度 ) 
            //{
            //    result += int arr[i] + "\n";
            //}
            foreach(int 變數 in intarr)
            {
                result += 變數 + "\n";
            }
            MessageBox.Show(result);
        }

        int[] Crry(int Loog)  
        {
            int[] arr = new int[Loog];

            for (int i=0;i<arr.Length;i++)
            {
                arr[i] = i + 1;
            }
            return arr;


        }

        private void button4_Click(object sender, EventArgs e)
        {
            member[] arrmember = new member[2];
            arrmember[0] = new member();
            arrmember[0].name = "iu";
            arrmember[0].age = 29;
            arrmember[1] = new member();
            arrmember[1].name = "裡之恩";
            arrmember[1].age = 28;

            string result= "";

            //for (int i = 0; i < arrmember.Length; i++)
            //{
            //    result += $"name:{ arrmember[i].name},age: { arrmember[i].age}\n";
            //}

            foreach (member 變數 in arrmember)
            {
                result += $"name:{ 變數.name},age: { 變數.age}\n";
            }

            MessageBox.Show(result);
        }
    }
}
