
namespace Lab_Form
{
    partial class Frm_M12
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
            this.labCount = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.labInstance = new System.Windows.Forms.Label();
            this.labStatic = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(54, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 61);
            this.button1.TabIndex = 0;
            this.button1.Text = "+= , -=";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labCount
            // 
            this.labCount.AutoSize = true;
            this.labCount.Location = new System.Drawing.Point(51, 33);
            this.labCount.Name = "labCount";
            this.labCount.Size = new System.Drawing.Size(56, 15);
            this.labCount.TabIndex = 1;
            this.labCount.Text = "Count: 0";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(54, 170);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 61);
            this.button2.TabIndex = 2;
            this.button2.Text = "++count , --count";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(54, 254);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 61);
            this.button3.TabIndex = 3;
            this.button3.Text = "count++ , count--";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Location = new System.Drawing.Point(296, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 159);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Local Variable";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(75, 24);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(180, 37);
            this.button4.TabIndex = 0;
            this.button4.Text = "Local Var.";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(75, 85);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(180, 37);
            this.button5.TabIndex = 1;
            this.button5.Text = "Var.";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Location = new System.Drawing.Point(296, 216);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(279, 159);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "static";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(75, 85);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(180, 37);
            this.button6.TabIndex = 1;
            this.button6.Text = "static count";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(75, 24);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(180, 37);
            this.button7.TabIndex = 0;
            this.button7.Text = "instance count";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // labInstance
            // 
            this.labInstance.AutoSize = true;
            this.labInstance.Location = new System.Drawing.Point(581, 254);
            this.labInstance.Name = "labInstance";
            this.labInstance.Size = new System.Drawing.Size(106, 15);
            this.labInstance.TabIndex = 6;
            this.labInstance.Text = "Instance Count: 0";
            // 
            // labStatic
            // 
            this.labStatic.AutoSize = true;
            this.labStatic.Location = new System.Drawing.Point(581, 312);
            this.labStatic.Name = "labStatic";
            this.labStatic.Size = new System.Drawing.Size(92, 15);
            this.labStatic.TabIndex = 7;
            this.labStatic.Text = "Static Count: 0";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(371, 381);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(180, 37);
            this.button8.TabIndex = 2;
            this.button8.Text = "Open Hello Form";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Frm_M12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.labStatic);
            this.Controls.Add(this.labInstance);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.labCount);
            this.Controls.Add(this.button1);
            this.Name = "Frm_M12";
            this.Text = "Frm_M12";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labCount;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label labInstance;
        private System.Windows.Forms.Label labStatic;
        private System.Windows.Forms.Button button8;
    }
}