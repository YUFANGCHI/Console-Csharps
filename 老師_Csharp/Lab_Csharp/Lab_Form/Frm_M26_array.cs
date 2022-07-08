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
    public partial class Frm_M26_array : Form
    {
        public Frm_M26_array()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int[] arr = new int[3];
            //arr[0] = 1;
            //arr[1] = 2;
            //arr[2] = 3;
            ////arr[3] = 4;

            //int[] arr = new int[3] { 1, 2, 3 };

            int[] arr = { 1, 2, 3 };

            //MessageBox.Show(arr[2].ToString());

            string result = "";
            for(int i = 0; i < arr.Length; i++)
            {
                result += arr[i] + "\n";
            }

            MessageBox.Show(result);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //int[,] arr = new int[3, 2];
            //arr[0, 0] = 1;
            //arr[0, 1] = 2;
            //arr[1, 0] = 3;
            //arr[1, 1] = 4;
            //arr[2, 0] = 5;
            //arr[2, 1] = 6;

            //int[,] arr = new int[3, 2]
            //{
            //    { 1 , 2 },
            //    { 3 , 4 },
            //    { 5 , 6 }
            //};

            int[,] arr =
            {
                { 1 , 2 },
                { 3 , 4 },
                { 5 , 6 }
            };

            string result = "";

            for (int i = 0; i < arr.GetLength(0); i++) //第一個維度
            {
                for (int j = 0; j < arr.GetLength(1); j++)  //第二個維度
                {
                    result += $"arr[{i}, {j}] -> {arr[i, j]}\n";
                }
            }

            //foreach(int item in arr)
            //{
            //    result += item+" ";
            //}


            MessageBox.Show(result);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[] intArr =  CreateIntArray(20);

            string result = "";

            //for(int i = 0; i < intArr.Length; i++)
            //{
            //    result += intArr[i] + "\n";
            //}

            foreach(int item in intArr)
            {
                result += item + "\n";
            }

            MessageBox.Show(result);
        }

        int[] CreateIntArray(int Length)
        {
            int[] arr = new int[Length];

            for(int i =0; i<arr.Length; /*i++*/)
            {
                //arr[i] = i+1;
                arr[i] = ++i;
            }

            return arr;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Member[] arrMember = new Member[2];
            arrMember[0] = new Member();
            arrMember[0].Name = "IU";
            arrMember[0].Age = 29;
            arrMember[1] = new Member();
            arrMember[1].Name = "裡之恩";
            arrMember[1].Age = 28;

            string result = "";

            //for(int i = 0; i <arrMember.Length; i++)
            //{
            //    result += $"Name: {arrMember[i].Name} , Age: {arrMember[i].Age}\n";
            //}

            foreach(Member item in arrMember)
            {
                result += $"Name: {item.Name} , Age: {item.Age}\n";
            }

            MessageBox.Show(result);

            //Member mem1 = new Member() { Name = "IU", Age = 29 };
            //Member mem2 = new Member() { Name = "裡之恩", Age = 28 };

            //Member[] arrMember = new Member[2] { mem1, mem2 };

            //Member[] arrMember =
            //{
            //    new Member(){Name = "IU", Age = 29},
            //    new Member(){ Name = "裡之恩", Age = 28 }
            //};

            //MessageBox.Show($"Name: {arrMember[0].Name} , Age: {arrMember[0].Age}");
        }
    }
}
