namespace UI
{
    partial class MENU_BOPHANVANPHONG
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
            this.xp_btn = new System.Windows.Forms.Button();
            this.lhgv_btn = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // xp_btn
            // 
            this.xp_btn.Location = new System.Drawing.Point(144, 109);
            this.xp_btn.Name = "xp_btn";
            this.xp_btn.Size = new System.Drawing.Size(418, 162);
            this.xp_btn.TabIndex = 0;
            this.xp_btn.Text = "XẾP PHÒNG";
            this.xp_btn.UseVisualStyleBackColor = true;
            this.xp_btn.Click += new System.EventHandler(this.xp_btn_Click);
            // 
            // lhgv_btn
            // 
            this.lhgv_btn.Location = new System.Drawing.Point(144, 346);
            this.lhgv_btn.Name = "lhgv_btn";
            this.lhgv_btn.Size = new System.Drawing.Size(418, 162);
            this.lhgv_btn.TabIndex = 1;
            this.lhgv_btn.Text = "DANH SÁCH GIÁO VIÊN";
            this.lhgv_btn.UseVisualStyleBackColor = true;
            this.lhgv_btn.Click += new System.EventHandler(this.lhgv_btn_Click);
            // 
            // back_btn
            // 
            this.back_btn.AutoSize = true;
            this.back_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.back_btn.BackColor = System.Drawing.SystemColors.Info;
            this.back_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn.Location = new System.Drawing.Point(3, 543);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(117, 101);
            this.back_btn.TabIndex = 19;
            this.back_btn.Text = "⬅";
            this.back_btn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // MENU_BOPHANVANPHONG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 643);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.lhgv_btn);
            this.Controls.Add(this.xp_btn);
            this.Name = "MENU_BOPHANVANPHONG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BỘ PHẬN VĂN PHÒNG";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button xp_btn;
        private System.Windows.Forms.Button lhgv_btn;
        private System.Windows.Forms.Button back_btn;
    }
}