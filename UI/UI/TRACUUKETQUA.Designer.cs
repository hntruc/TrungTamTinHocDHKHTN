namespace UI
{
    partial class TRACUUKETQUA
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
            this.mahv_text = new System.Windows.Forms.TextBox();
            this.mahp_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.xemketqua = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(64, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã học viên";
            // 
            // mahv_text
            // 
            this.mahv_text.Location = new System.Drawing.Point(426, 51);
            this.mahv_text.Name = "mahv_text";
            this.mahv_text.Size = new System.Drawing.Size(425, 44);
            this.mahv_text.TabIndex = 1;
            // 
            // mahp_text
            // 
            this.mahp_text.Location = new System.Drawing.Point(426, 160);
            this.mahp_text.Name = "mahp_text";
            this.mahp_text.Size = new System.Drawing.Size(425, 44);
            this.mahp_text.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(64, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã học phần";
            // 
            // xemketqua
            // 
            this.xemketqua.ForeColor = System.Drawing.Color.Maroon;
            this.xemketqua.Location = new System.Drawing.Point(581, 269);
            this.xemketqua.Name = "xemketqua";
            this.xemketqua.Size = new System.Drawing.Size(270, 102);
            this.xemketqua.TabIndex = 8;
            this.xemketqua.Text = "Tra cứu kết quả";
            this.xemketqua.UseVisualStyleBackColor = true;
            this.xemketqua.Click += new System.EventHandler(this.xemketqua_Click);
            // 
            // back_btn
            // 
            this.back_btn.AutoSize = true;
            this.back_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.back_btn.BackColor = System.Drawing.SystemColors.Info;
            this.back_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn.Location = new System.Drawing.Point(71, 270);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(117, 101);
            this.back_btn.TabIndex = 10;
            this.back_btn.Text = "⬅";
            this.back_btn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // TRACUUKETQUA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(938, 466);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.xemketqua);
            this.Controls.Add(this.mahp_text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mahv_text);
            this.Controls.Add(this.label1);
            this.Name = "TRACUUKETQUA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TRA CỨU KẾT QUẢ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox mahv_text;
        private System.Windows.Forms.TextBox mahp_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button xemketqua;
        private System.Windows.Forms.Button back_btn;
    }
}

