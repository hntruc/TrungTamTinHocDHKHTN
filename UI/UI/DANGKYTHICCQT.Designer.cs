namespace UI
{
    partial class DANGKYTHICCQT
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
            this.hv_btn = new System.Windows.Forms.Button();
            this.dtk_btn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hv_btn
            // 
            this.hv_btn.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.hv_btn.Location = new System.Drawing.Point(296, 70);
            this.hv_btn.Name = "hv_btn";
            this.hv_btn.Size = new System.Drawing.Size(473, 226);
            this.hv_btn.TabIndex = 0;
            this.hv_btn.Text = "HỌC VIÊN";
            this.hv_btn.UseVisualStyleBackColor = true;
            this.hv_btn.Click += new System.EventHandler(this.hv_btn_Click);
            // 
            // dtk_btn
            // 
            this.dtk_btn.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.dtk_btn.Location = new System.Drawing.Point(296, 422);
            this.dtk_btn.Name = "dtk_btn";
            this.dtk_btn.Size = new System.Drawing.Size(473, 226);
            this.dtk_btn.TabIndex = 1;
            this.dtk_btn.Text = "ĐỐI TƯỢNG KHÁC";
            this.dtk_btn.UseVisualStyleBackColor = true;
            this.dtk_btn.Click += new System.EventHandler(this.dtk_btn_Click);
            // 
            // backBtn
            // 
            this.backBtn.AutoSize = true;
            this.backBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.backBtn.BackColor = System.Drawing.SystemColors.Info;
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(39, 758);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(84, 73);
            this.backBtn.TabIndex = 23;
            this.backBtn.Text = "⬅";
            this.backBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // registerInternationalOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1083, 939);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.dtk_btn);
            this.Controls.Add(this.hv_btn);
            this.Name = "registerInternationalOption";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐĂNG KÝ THI CHỨNG CHỈ QUỐC TẾ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hv_btn;
        private System.Windows.Forms.Button dtk_btn;
        private System.Windows.Forms.Button backBtn;
    }
}