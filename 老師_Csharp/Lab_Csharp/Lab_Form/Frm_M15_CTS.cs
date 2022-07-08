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
    public partial class Frm_M15_CTS : Form
    {
        public Frm_M15_CTS()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int A = 100;

            MessageBox.Show(A.ToString());

            int B = A;

            MessageBox.Show("A: " + A + " , B: " + B);

            B = 200;

            MessageBox.Show("A: " + A + " , B: " + B);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TextBox tb = txtReferenceType;

            tb.Text = "Reference Type";
            tb.BackColor = Color.LightSlateGray;
            tb.ForeColor = Color.Orchid;

            tb.Location = new Point(150, 100);

            tb.Font = new Font(new FontFamily("Sylfaen"),14, FontStyle.Regular);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //string strA = "AAA";

            //string strB = "BBB";

            string strA = "AAA", strB = "BBB";

            MessageBox.Show("A: " + strA + " , B: " + strB);

            strB = strA;

            strB = "String BBBBB";

            MessageBox.Show("A: " + strA + " , B: " + strB);
        }
    }
}
