
namespace HomeWork
{
    partial class work3
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
            this.btn_beer = new System.Windows.Forms.Button();
            this.btn_tequila = new System.Windows.Forms.Button();
            this.btn_whisky = new System.Windows.Forms.Button();
            this.btn_wine = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_beer
            // 
            this.btn_beer.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_beer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_beer.Location = new System.Drawing.Point(12, 72);
            this.btn_beer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_beer.Name = "btn_beer";
            this.btn_beer.Size = new System.Drawing.Size(107, 137);
            this.btn_beer.TabIndex = 0;
            this.btn_beer.Text = "啤酒 beer";
            this.btn_beer.UseVisualStyleBackColor = false;
            this.btn_beer.Click += new System.EventHandler(this.btn_beer_Click);
            // 
            // btn_tequila
            // 
            this.btn_tequila.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_tequila.Location = new System.Drawing.Point(126, 72);
            this.btn_tequila.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_tequila.Name = "btn_tequila";
            this.btn_tequila.Size = new System.Drawing.Size(109, 137);
            this.btn_tequila.TabIndex = 1;
            this.btn_tequila.Text = "龍舌蘭 tequila";
            this.btn_tequila.UseVisualStyleBackColor = false;
            this.btn_tequila.Click += new System.EventHandler(this.btn_tequila_Click);
            // 
            // btn_whisky
            // 
            this.btn_whisky.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_whisky.Location = new System.Drawing.Point(12, 216);
            this.btn_whisky.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_whisky.Name = "btn_whisky";
            this.btn_whisky.Size = new System.Drawing.Size(107, 150);
            this.btn_whisky.TabIndex = 2;
            this.btn_whisky.Text = "威士忌 whisky";
            this.btn_whisky.UseVisualStyleBackColor = false;
            this.btn_whisky.Click += new System.EventHandler(this.btn_whisky_Click);
            // 
            // btn_wine
            // 
            this.btn_wine.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_wine.Location = new System.Drawing.Point(126, 216);
            this.btn_wine.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_wine.Name = "btn_wine";
            this.btn_wine.Size = new System.Drawing.Size(109, 150);
            this.btn_wine.TabIndex = 3;
            this.btn_wine.Text = "紅酒 wine";
            this.btn_wine.UseVisualStyleBackColor = false;
            this.btn_wine.Click += new System.EventHandler(this.btn_wine_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(17, 53);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(110, 53);
            this.button5.TabIndex = 4;
            this.button5.Text = "現金";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(150, 53);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(110, 53);
            this.button6.TabIndex = 5;
            this.button6.Text = "信用卡";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(168, 362);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(110, 53);
            this.button7.TabIndex = 6;
            this.button7.Text = "清除清單";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_tequila);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_beer);
            this.panel1.Controls.Add(this.btn_whisky);
            this.panel1.Controls.Add(this.btn_wine);
            this.panel1.Location = new System.Drawing.Point(56, 62);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 421);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 15F);
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "菜單menu";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Location = new System.Drawing.Point(317, 226);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(279, 148);
            this.panel2.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 11F);
            this.label4.Location = new System.Drawing.Point(17, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "付款方式";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("新細明體", 10F);
            this.label3.Location = new System.Drawing.Point(136, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "信用卡享九折!!";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.button7);
            this.panel3.Location = new System.Drawing.Point(603, 62);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(283, 421);
            this.panel3.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 43);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(273, 310);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "尚未購物";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F);
            this.label2.Location = new System.Drawing.Point(19, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "購物清單List";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.textBox2);
            this.panel4.Location = new System.Drawing.Point(317, 62);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(279, 156);
            this.panel4.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "總金額";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox2.Font = new System.Drawing.Font("新細明體", 15F);
            this.textBox2.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox2.Location = new System.Drawing.Point(35, 59);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox2.Size = new System.Drawing.Size(238, 53);
            this.textBox2.TabIndex = 0;
            this.textBox2.Tag = "";
            this.textBox2.Text = "NT$0";
            // 
            // work3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 540);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "work3";
            this.Text = "Bar";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_beer;
        private System.Windows.Forms.Button btn_tequila;
        private System.Windows.Forms.Button btn_whisky;
        private System.Windows.Forms.Button btn_wine;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
    }
}