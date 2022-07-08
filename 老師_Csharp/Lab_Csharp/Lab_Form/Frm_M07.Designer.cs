
namespace Lab_Form
{
    partial class Frm_M07
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnRegister01 = new System.Windows.Forms.Button();
            this.btnRegister02 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.cmbDiscount = new System.Windows.Forms.ComboBox();
            this.btnDiscount = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(475, 29);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "物件初始化";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(56, 37);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 43);
            this.button2.TabIndex = 1;
            this.button2.Text = "註冊事件";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnRegister01
            // 
            this.btnRegister01.Location = new System.Drawing.Point(56, 102);
            this.btnRegister01.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegister01.Name = "btnRegister01";
            this.btnRegister01.Size = new System.Drawing.Size(147, 43);
            this.btnRegister01.TabIndex = 2;
            this.btnRegister01.Text = "Register01";
            this.btnRegister01.UseVisualStyleBackColor = true;
            // 
            // btnRegister02
            // 
            this.btnRegister02.Location = new System.Drawing.Point(56, 166);
            this.btnRegister02.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegister02.Name = "btnRegister02";
            this.btnRegister02.Size = new System.Drawing.Size(147, 43);
            this.btnRegister02.TabIndex = 3;
            this.btnRegister02.Text = "Register02";
            this.btnRegister02.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(56, 232);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 43);
            this.button3.TabIndex = 4;
            this.button3.Text = "解除註冊";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(266, 166);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(147, 25);
            this.txtPrice.TabIndex = 5;
            // 
            // cmbDiscount
            // 
            this.cmbDiscount.FormattingEnabled = true;
            this.cmbDiscount.Items.AddRange(new object[] {
            "50%off",
            "20%off"});
            this.cmbDiscount.Location = new System.Drawing.Point(266, 216);
            this.cmbDiscount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDiscount.Name = "cmbDiscount";
            this.cmbDiscount.Size = new System.Drawing.Size(152, 23);
            this.cmbDiscount.TabIndex = 6;
            // 
            // btnDiscount
            // 
            this.btnDiscount.Location = new System.Drawing.Point(260, 257);
            this.btnDiscount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(156, 39);
            this.btnDiscount.TabIndex = 7;
            this.btnDiscount.Text = "計算價格";
            this.btnDiscount.UseVisualStyleBackColor = true;
            this.btnDiscount.Click += new System.EventHandler(this.btnDiscount_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(475, 98);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(175, 51);
            this.button4.TabIndex = 8;
            this.button4.Text = "set property";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(475, 162);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(175, 51);
            this.button5.TabIndex = 9;
            this.button5.Text = "call Method";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(475, 228);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(175, 51);
            this.button6.TabIndex = 10;
            this.button6.Text = "MessageBox";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(260, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 76);
            this.label1.TabIndex = 11;
            this.label1.Text = "label";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(27, 289);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '@';
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(212, 74);
            this.textBox1.TabIndex = 12;
            this.textBox1.WordWrap = false;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(475, 299);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(175, 51);
            this.button7.TabIndex = 13;
            this.button7.Text = "Dialog Result";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Frm_M07
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 375);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnDiscount);
            this.Controls.Add(this.cmbDiscount);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnRegister02);
            this.Controls.Add(this.btnRegister01);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_M07";
            this.Text = "Frm_M07";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnRegister01;
        private System.Windows.Forms.Button btnRegister02;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ComboBox cmbDiscount;
        private System.Windows.Forms.Button btnDiscount;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button7;
    }
}