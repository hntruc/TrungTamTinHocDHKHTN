namespace UI
{
    partial class DANGKYHOCPHANHOCVIENCU
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
            this.backBtn = new System.Windows.Forms.Button();
            this.dangkyBtn = new System.Windows.Forms.Button();
            this.cmndText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.AutoSize = true;
            this.backBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.backBtn.BackColor = System.Drawing.SystemColors.Info;
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(67, 172);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(117, 101);
            this.backBtn.TabIndex = 18;
            this.backBtn.Text = "⬅";
            this.backBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // dangkyBtn
            // 
            this.dangkyBtn.Location = new System.Drawing.Point(770, 172);
            this.dangkyBtn.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.dangkyBtn.Name = "dangkyBtn";
            this.dangkyBtn.Size = new System.Drawing.Size(276, 101);
            this.dangkyBtn.TabIndex = 17;
            this.dangkyBtn.Text = "Đăng ký";
            this.dangkyBtn.UseVisualStyleBackColor = true;
            this.dangkyBtn.Click += new System.EventHandler(this.dangkyBtn_Click);
            // 
            // cmndText
            // 
            this.cmndText.Location = new System.Drawing.Point(320, 79);
            this.cmndText.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.cmndText.Name = "cmndText";
            this.cmndText.Size = new System.Drawing.Size(726, 44);
            this.cmndText.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 37);
            this.label3.TabIndex = 13;
            this.label3.Text = "CMND";
            // 
            // hvcInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 362);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.dangkyBtn);
            this.Controls.Add(this.cmndText);
            this.Controls.Add(this.label3);
            this.Name = "hvcInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NHẬP THÔNG TIN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button dangkyBtn;
        private System.Windows.Forms.TextBox cmndText;
        private System.Windows.Forms.Label label3;
    }
}