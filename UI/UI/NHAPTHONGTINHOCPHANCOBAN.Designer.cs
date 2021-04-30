namespace UI
{
    partial class NHAPTHONGTINHOCPHANCOBAN
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
            this.yes = new System.Windows.Forms.RadioButton();
            this.no = new System.Windows.Forms.RadioButton();
            this.xacnhan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Có chứng chỉ cơ bản:";
            // 
            // yes
            // 
            this.yes.AutoSize = true;
            this.yes.Location = new System.Drawing.Point(425, 41);
            this.yes.Name = "yes";
            this.yes.Size = new System.Drawing.Size(102, 41);
            this.yes.TabIndex = 1;
            this.yes.TabStop = true;
            this.yes.Text = "Có";
            this.yes.UseVisualStyleBackColor = true;
            // 
            // no
            // 
            this.no.AutoSize = true;
            this.no.Location = new System.Drawing.Point(717, 41);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(149, 41);
            this.no.TabIndex = 2;
            this.no.TabStop = true;
            this.no.Text = "không";
            this.no.UseVisualStyleBackColor = true;
            // 
            // xacnhan
            // 
            this.xacnhan.Location = new System.Drawing.Point(611, 128);
            this.xacnhan.Name = "xacnhan";
            this.xacnhan.Size = new System.Drawing.Size(255, 86);
            this.xacnhan.TabIndex = 3;
            this.xacnhan.Text = "Xác nhận";
            this.xacnhan.UseVisualStyleBackColor = true;
            this.xacnhan.Click += new System.EventHandler(this.xacnhan_Click);
            // 
            // NHAPTHONGTINHOCPHANCOBAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 257);
            this.Controls.Add(this.xacnhan);
            this.Controls.Add(this.no);
            this.Controls.Add(this.yes);
            this.Controls.Add(this.label1);
            this.Name = "NHAPTHONGTINHOCPHANCOBAN";
            this.Text = "XÁC NHẬN HỌC PHẦN CƠ BẢN TRƯỚC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton yes;
        private System.Windows.Forms.RadioButton no;
        private System.Windows.Forms.Button xacnhan;
    }
}