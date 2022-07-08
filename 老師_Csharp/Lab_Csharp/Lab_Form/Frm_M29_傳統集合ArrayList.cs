using System;
using System.Collections;
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
    public partial class Frm_M29_傳統集合ArrayList : Form
    {
        public Frm_M29_傳統集合ArrayList()
        {
            InitializeComponent();
        }

        void ShowEmployee()
        {
            labShow.Text = "員工\n";
            for (int i = 0; i < lsEmp.Count; i++)
            {
                labShow.Text += $"姓名：{ ((Employee)lsEmp[i]).Name}" +
                    $"，年齡：{((Employee)lsEmp[i]).Age}\n";
                // unboxing
            }
            labShow.Text += $"---------\n員工數量：{lsEmp.Count}";
        }

        ArrayList lsEmp = new ArrayList();
        private void button1_Click(object sender, EventArgs e)
        {
            Employee emp;
            emp.Name = txtEmployeeName.Text;
            emp.Age = int.Parse( txtEmployeeAge.Text);

            lsEmp.Add(emp); // object => boxing

            ShowEmployee();         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Employee emp;
            emp.Name = txtEmployeeName.Text;
            emp.Age = int.Parse(txtEmployeeAge.Text);

            lsEmp.Insert(0,emp);

            ShowEmployee();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lsEmp.Clear();

            ShowEmployee();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lsEmp.RemoveAt(0);

            ShowEmployee();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            lsEmp.Add(100);
            lsEmp.Add("string");

            ShowEmployee();
        }
    }
}
