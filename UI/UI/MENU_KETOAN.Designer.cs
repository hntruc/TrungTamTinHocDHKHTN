namespace UI
{
    partial class MENU_KETOAN
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
            this.back_btn = new System.Windows.Forms.Button();
            this.dktccqtBtn = new System.Windows.Forms.Button();
            this.dkhpBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // back_btn
            // 
            this.back_btn.AutoSize = true;
            this.back_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.back_btn.BackColor = System.Drawing.SystemColors.Info;
            this.back_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn.Location = new System.Drawing.Point(-3, 342);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(117, 101);
            this.back_btn.TabIndex = 19;
            this.back_btn.Text = "⬅";
            this.back_btn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // dktccqtBtn
            // 
            this.dktccqtBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dktccqtBtn.ForeColor = System.Drawing.Color.DarkOrange;
            this.dktccqtBtn.Location = new System.Drawing.Point(664, 98);
            this.dktccqtBtn.Name = "dktccqtBtn";
            this.dktccqtBtn.Size = new System.Drawing.Size(345, 179);
            this.dktccqtBtn.TabIndex = 16;
            this.dktccqtBtn.TabStop = false;
            this.dktccqtBtn.Text = "Thanh toán đăng ký thi chứng chỉ quốc tế";
            this.dktccqtBtn.UseVisualStyleBackColor = true;
            this.dktccqtBtn.Click += new System.EventHandler(this.dktccqtBtn_Click);
            // 
            // dkhpBtn
            // 
            this.dkhpBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dkhpBtn.ForeColor = System.Drawing.Color.DarkOrange;
            this.dkhpBtn.Location = new System.Drawing.Point(125, 98);
            this.dkhpBtn.Name = "dkhpBtn";
            this.dkhpBtn.Size = new System.Drawing.Size(345, 179);
            this.dkhpBtn.TabIndex = 15;
            this.dkhpBtn.TabStop = false;
            this.dkhpBtn.Text = "Thanh toán đăng ký học phần";
            this.dkhpBtn.UseVisualStyleBackColor = true;
            this.dkhpBtn.Click += new System.EventHandler(this.dkhpBtn_Click);
            // 
            // MENU_KETOAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 449);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.dktccqtBtn);
            this.Controls.Add(this.dkhpBtn);
            this.Name = "MENU_KETOAN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NHÂN VIÊN KẾ TOÁN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button dktccqtBtn;
        private System.Windows.Forms.Button dkhpBtn;
    }
}