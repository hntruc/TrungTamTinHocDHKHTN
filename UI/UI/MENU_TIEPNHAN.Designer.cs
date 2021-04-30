namespace UI
{
    partial class MENU_TIEPNHAN
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
            this.dkhpBtn = new System.Windows.Forms.Button();
            this.dktccqtBtn = new System.Windows.Forms.Button();
            this.tckqBtn = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dkhpBtn
            // 
            this.dkhpBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dkhpBtn.ForeColor = System.Drawing.Color.DarkOrange;
            this.dkhpBtn.Location = new System.Drawing.Point(114, 71);
            this.dkhpBtn.Name = "dkhpBtn";
            this.dkhpBtn.Size = new System.Drawing.Size(345, 179);
            this.dkhpBtn.TabIndex = 0;
            this.dkhpBtn.TabStop = false;
            this.dkhpBtn.Text = "Đăng ký học phần";
            this.dkhpBtn.UseVisualStyleBackColor = true;
            this.dkhpBtn.Click += new System.EventHandler(this.dkhpBtn_Click);
            // 
            // dktccqtBtn
            // 
            this.dktccqtBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dktccqtBtn.ForeColor = System.Drawing.Color.DarkOrange;
            this.dktccqtBtn.Location = new System.Drawing.Point(1127, 71);
            this.dktccqtBtn.Name = "dktccqtBtn";
            this.dktccqtBtn.Size = new System.Drawing.Size(345, 179);
            this.dktccqtBtn.TabIndex = 2;
            this.dktccqtBtn.TabStop = false;
            this.dktccqtBtn.Text = "Đăng ký thi chứng chỉ quốc tế";
            this.dktccqtBtn.UseVisualStyleBackColor = true;
            this.dktccqtBtn.Click += new System.EventHandler(this.dktccqtBtn_Click);
            // 
            // tckqBtn
            // 
            this.tckqBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tckqBtn.ForeColor = System.Drawing.Color.DarkOrange;
            this.tckqBtn.Location = new System.Drawing.Point(624, 71);
            this.tckqBtn.Name = "tckqBtn";
            this.tckqBtn.Size = new System.Drawing.Size(345, 179);
            this.tckqBtn.TabIndex = 3;
            this.tckqBtn.TabStop = false;
            this.tckqBtn.Text = "Tra cứu kết quả";
            this.tckqBtn.UseVisualStyleBackColor = true;
            this.tckqBtn.Click += new System.EventHandler(this.tckqBtn_Click);
            // 
            // back_btn
            // 
            this.back_btn.AutoSize = true;
            this.back_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.back_btn.BackColor = System.Drawing.SystemColors.Info;
            this.back_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn.Location = new System.Drawing.Point(2, 322);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(117, 101);
            this.back_btn.TabIndex = 14;
            this.back_btn.Text = "⬅";
            this.back_btn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // MENU_TIEPNHAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1596, 425);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.tckqBtn);
            this.Controls.Add(this.dktccqtBtn);
            this.Controls.Add(this.dkhpBtn);
            this.Name = "MENU_TIEPNHAN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NHÂN VIÊN TIẾP NHẬN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dkhpBtn;
        private System.Windows.Forms.Button dktccqtBtn;
        private System.Windows.Forms.Button tckqBtn;
        private System.Windows.Forms.Button back_btn;
    }
}