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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   //資廖路徑只能放在開啟位置的路徑
            StreamReader str = new StreamReader("新文字文件.txt",Encoding.UTF8);
            textBox1.Text = str.ReadToEnd();
            str.Close();  // 先關最後開啟的檔案

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileStream FS = new FileStream("WRITE",FileMode.Create);
            StreamWriter SW = new StreamWriter(FS, Encoding.Default);
            SW.Write(textBox1.Text);
            SW.Close();  // 先關最後開啟的檔案
            FS.Close();  //在關最先開啟的檔案

        }
    }
}
