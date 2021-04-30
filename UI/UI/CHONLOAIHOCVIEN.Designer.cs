namespace UI
{
    partial class CHONLOAIHOCVIEN
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
            this.hvmBtn = new System.Windows.Forms.Button();
            this.hvcBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hvmBtn
            // 
            this.hvmBtn.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.hvmBtn.Location = new System.Drawing.Point(253, 77);
            this.hvmBtn.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.hvmBtn.Name = "hvmBtn";
            this.hvmBtn.Size = new System.Drawing.Size(339, 176);
            this.hvmBtn.TabIndex = 0;
            this.hvmBtn.Text = "Học viên mới";
            this.hvmBtn.UseVisualStyleBackColor = true;
            this.hvmBtn.Click += new System.EventHandler(this.hvmBtn_Click);
            // 
            // hvcBtn
            // 
            this.hvcBtn.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.hvcBtn.Location = new System.Drawing.Point(253, 313);
            this.hvcBtn.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.hvcBtn.Name = "hvcBtn";
            this.hvcBtn.Size = new System.Drawing.Size(339, 176);
            this.hvcBtn.TabIndex = 1;
            this.hvcBtn.Text = "Học viên cũ";
            this.hvcBtn.UseVisualStyleBackColor = true;
            this.hvcBtn.Click += new System.EventHandler(this.hvcBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.AutoSize = true;
            this.backBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.backBtn.BackColor = System.Drawing.SystemColors.Info;
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(60, 518);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(117, 101);
            this.backBtn.TabIndex = 11;
            this.backBtn.Text = "⬅";
            this.backBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // registerSubjectOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 694);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.hvcBtn);
            this.Controls.Add(this.hvmBtn);
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "registerSubjectOption";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CHỌN LOẠI HỌC VIÊN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hvmBtn;
        private System.Windows.Forms.Button hvcBtn;
        private System.Windows.Forms.Button backBtn;
    }
}