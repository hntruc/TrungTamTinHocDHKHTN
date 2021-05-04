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
            this.HOCVIENMOI = new System.Windows.Forms.Button();
            this.HOCVIENCU = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HOCVIENMOI
            // 
            this.HOCVIENMOI.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.HOCVIENMOI.Location = new System.Drawing.Point(253, 77);
            this.HOCVIENMOI.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.HOCVIENMOI.Name = "HOCVIENMOI";
            this.HOCVIENMOI.Size = new System.Drawing.Size(339, 176);
            this.HOCVIENMOI.TabIndex = 0;
            this.HOCVIENMOI.Text = "Học viên mới";
            this.HOCVIENMOI.UseVisualStyleBackColor = true;
            this.HOCVIENMOI.Click += new System.EventHandler(this.HOCVIENMOI_Click);
            // 
            // HOCVIENCU
            // 
            this.HOCVIENCU.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.HOCVIENCU.Location = new System.Drawing.Point(253, 313);
            this.HOCVIENCU.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.HOCVIENCU.Name = "HOCVIENCU";
            this.HOCVIENCU.Size = new System.Drawing.Size(339, 176);
            this.HOCVIENCU.TabIndex = 1;
            this.HOCVIENCU.Text = "Học viên cũ";
            this.HOCVIENCU.UseVisualStyleBackColor = true;
            this.HOCVIENCU.Click += new System.EventHandler(this.HOCVIENCU_Click);
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
            // CHONLOAIHOCVIEN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 694);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.HOCVIENCU);
            this.Controls.Add(this.HOCVIENMOI);
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "CHONLOAIHOCVIEN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CHỌN LOẠI HỌC VIÊN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button HOCVIENMOI;
        private System.Windows.Forms.Button HOCVIENCU;
        private System.Windows.Forms.Button backBtn;
    }
}