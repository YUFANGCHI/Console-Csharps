
namespace Lab_Form
{
    partial class Frm_M29_泛用集合List
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
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labShow = new System.Windows.Forms.Label();
            this.txtEmployeeAge = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(32, 287);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(221, 52);
            this.button5.TabIndex = 19;
            this.button5.Text = "加入不同的資料型態";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(291, 287);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(122, 52);
            this.button4.TabIndex = 18;
            this.button4.Text = "RemoveAt";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(291, 218);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 52);
            this.button3.TabIndex = 17;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(291, 142);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 52);
            this.button2.TabIndex = 16;
            this.button2.Text = "Insert";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(291, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 52);
            this.button1.TabIndex = 15;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labShow
            // 
            this.labShow.AutoSize = true;
            this.labShow.BackColor = System.Drawing.Color.LightSeaGreen;
            this.labShow.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labShow.ForeColor = System.Drawing.Color.MistyRose;
            this.labShow.Location = new System.Drawing.Point(430, 14);
            this.labShow.Name = "labShow";
            this.labShow.Size = new System.Drawing.Size(52, 25);
            this.labShow.TabIndex = 14;
            this.labShow.Text = "員工";
            // 
            // txtEmployeeAge
            // 
            this.txtEmployeeAge.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEmployeeAge.Location = new System.Drawing.Point(110, 160);
            this.txtEmployeeAge.Name = "txtEmployeeAge";
            this.txtEmployeeAge.Size = new System.Drawing.Size(158, 34);
            this.txtEmployeeAge.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(12, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "員工年齡";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEmployeeName.Location = new System.Drawing.Point(110, 93);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(158, 34);
            this.txtEmployeeName.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "員工姓名";
            // 
            // Frm_M29_泛用集合List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labShow);
            this.Controls.Add(this.txtEmployeeAge);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmployeeName);
            this.Controls.Add(this.label1);
            this.Name = "Frm_M29_泛用集合List";
            this.Text = "Frm_M29_泛用集合List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labShow;
        private System.Windows.Forms.TextBox txtEmployeeAge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Label label1;
    }
}