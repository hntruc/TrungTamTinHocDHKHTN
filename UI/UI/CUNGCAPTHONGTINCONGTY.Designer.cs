﻿namespace UI
{
    partial class CUNGCAPTHONGTINCONGTY
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.xn_btn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(25, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "Tên công ty";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(209, 65);
            this.textBox1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(232, 20);
            this.textBox1.TabIndex = 51;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(209, 28);
            this.textBox3.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(232, 20);
            this.textBox3.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(25, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 54;
            this.label3.Text = "Mã học viên";
            // 
            // xn_btn
            // 
            this.xn_btn.ForeColor = System.Drawing.Color.Maroon;
            this.xn_btn.Location = new System.Drawing.Point(340, 147);
            this.xn_btn.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.xn_btn.Name = "xn_btn";
            this.xn_btn.Size = new System.Drawing.Size(99, 35);
            this.xn_btn.TabIndex = 56;
            this.xn_btn.Text = "Xác nhận";
            this.xn_btn.UseVisualStyleBackColor = true;
            this.xn_btn.Click += new System.EventHandler(this.luu_btn_Click);
            // 
            // backBtn
            // 
            this.backBtn.AutoSize = true;
            this.backBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.backBtn.BackColor = System.Drawing.SystemColors.Info;
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(27, 147);
            this.backBtn.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(47, 41);
            this.backBtn.TabIndex = 57;
            this.backBtn.Text = "⬅";
            this.backBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(209, 104);
            this.textBox4.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(232, 20);
            this.textBox4.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(25, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 58;
            this.label4.Text = "Mã số thuế";
            // 
            // CUNGCAPTHONGTINCONGTY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 208);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.xn_btn);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "CUNGCAPTHONGTINCONGTY";
            this.Text = "THÔNG TIN CÔNG TY";
            this.Load += new System.EventHandler(this.CUNGCAPTHONGTINCONGTY_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button xn_btn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
    }
}