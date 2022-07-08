
namespace Lab_Form
{
    partial class Frm_M20
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
            this.btnReverse = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.labGrade = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReverse
            // 
            this.btnReverse.Location = new System.Drawing.Point(74, 53);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(128, 42);
            this.btnReverse.TabIndex = 0;
            this.btnReverse.Text = "轉型";
            this.btnReverse.UseVisualStyleBackColor = true;
            this.btnReverse.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(74, 142);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 42);
            this.button2.TabIndex = 1;
            this.button2.Text = "!";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(74, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "三元運算式";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(265, 64);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(155, 25);
            this.txtScore.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(265, 117);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(157, 40);
            this.button3.TabIndex = 4;
            this.button3.Text = "分級";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // labGrade
            // 
            this.labGrade.AutoSize = true;
            this.labGrade.Location = new System.Drawing.Point(434, 66);
            this.labGrade.Name = "labGrade";
            this.labGrade.Size = new System.Drawing.Size(37, 15);
            this.labGrade.TabIndex = 5;
            this.labGrade.Text = "級分";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(263, 219);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(157, 40);
            this.button4.TabIndex = 6;
            this.button4.Text = "switch";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(530, 49);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(157, 40);
            this.button5.TabIndex = 7;
            this.button5.Text = "while";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(530, 117);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(157, 40);
            this.button6.TabIndex = 8;
            this.button6.Text = "do";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(530, 191);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(157, 40);
            this.button7.TabIndex = 9;
            this.button7.Text = "for";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(530, 258);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(157, 40);
            this.button8.TabIndex = 10;
            this.button8.Text = "foreach";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Frm_M20
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.labGrade);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnReverse);
            this.Name = "Frm_M20";
            this.Text = "Frm_M20";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReverse;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label labGrade;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}