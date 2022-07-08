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
    public partial class Frm_M18_enum : Form
    {
        public Frm_M18_enum()
        {
            InitializeComponent();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Product");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Admin => 0
            // User => 2

            int Role = 0;

            //if(Role == 0)
            //{
            //    btnProduct.Enabled = true;
            //}
            //else
            //{
            //    btnProduct.Enabled = false;
            //}

            int Admin = 0, User = 2;

            Admin = 0;

            //if(Role == Admin)
            //{
            //    btnProduct.Enabled = true;
            //}
            //else
            //{
            //    btnProduct.Enabled = false;
            //}

            btnProduct.Enabled = Role == Admin ;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Admin => 0
            // User => 2

            int Role = 0;

            const int Admin = 0, User = 2;

            //Admin = 1;

            if (Role == Admin)
            {
                btnProduct.Enabled = true;
            }
            else
            {
                btnProduct.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Admin => 0
            // User => 2

            //int Role = 0;

            //if(Role == (int)UserRole.Admin)
            //{
            //    btnProduct.Enabled = true;
            //}
            //else
            //{
            //    btnProduct.Enabled = false;
            //}

            UserRole Role = UserRole.User;

            //if (Role == UserRole.Admin)
            //{
            //    btnProduct.Enabled = true;
            //}
            //else
            //{
            //    btnProduct.Enabled = false;
            //}

            switch (Role)
            {
                case UserRole.Admin:
                    btnProduct.Enabled = true;
                    break;
                case UserRole.User:
                    btnProduct.Enabled = false;
                    break;
            }

        }
    }
}
