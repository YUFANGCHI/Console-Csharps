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

namespace Lab_Form
{
    public partial class Frm_M34_ReadWrite : Form
    {
        public Frm_M34_ReadWrite()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("../Read.txt" , Encoding.UTF8);
            txtReadWrite.Text= sr.ReadToEnd();
            sr.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("Write.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs, Encoding.Default);
            sw.Write(txtReadWrite.Text);
            sw.Close();
            fs.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            int[] nums = { 1, 2, 3, 4, 5 };


            string result = "";
            for(int i = 0; i < nums.Length; i++)
            {
                result += nums[i] + "\n";

                MyMethod();

            }

            MessageBox.Show(result);
        }

        void MyMethod()
        {
            int i = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int[] nums = { 1, 2, 3, 4, 5 };

            try
            {
                string result = "";
                for (int i = 0; i <= nums.Length; i++)
                {
                    result += nums[i] + "\n";

                    MyMethod();

                    if(i > 1)
                    {
                        //throw new AccessViolationException("自訂Message");
                        throw new AggregateException();
                    }

                }
            }           
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(AccessViolationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
