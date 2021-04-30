namespace UI
{
    partial class PHIEUDUTHI
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
            this.ikq_btn = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MAHOCVIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENHV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KETQUA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ikq_btn
            // 
            this.ikq_btn.ForeColor = System.Drawing.Color.Maroon;
            this.ikq_btn.Location = new System.Drawing.Point(1747, 292);
            this.ikq_btn.Name = "ikq_btn";
            this.ikq_btn.Size = new System.Drawing.Size(314, 91);
            this.ikq_btn.TabIndex = 32;
            this.ikq_btn.Text = "In phiếu đăng ký";
            this.ikq_btn.UseVisualStyleBackColor = true;
            this.ikq_btn.Click += new System.EventHandler(this.ikq_btn_Click);
            // 
            // back_btn
            // 
            this.back_btn.AutoSize = true;
            this.back_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.back_btn.BackColor = System.Drawing.SystemColors.Info;
            this.back_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn.Location = new System.Drawing.Point(-1, 380);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(117, 101);
            this.back_btn.TabIndex = 36;
            this.back_btn.Text = "⬅";
            this.back_btn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAHOCVIEN,
            this.TENHV,
            this.MAHP,
            this.TENHP,
            this.KETQUA});
            this.dataGridView1.Location = new System.Drawing.Point(114, 83);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 123;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1947, 164);
            this.dataGridView1.TabIndex = 37;
            // 
            // MAHOCVIEN
            // 
            this.MAHOCVIEN.HeaderText = "Họ tên";
            this.MAHOCVIEN.MinimumWidth = 15;
            this.MAHOCVIEN.Name = "MAHOCVIEN";
            this.MAHOCVIEN.ReadOnly = true;
            // 
            // TENHV
            // 
            this.TENHV.HeaderText = "Ngày sinh";
            this.TENHV.MinimumWidth = 15;
            this.TENHV.Name = "TENHV";
            this.TENHV.ReadOnly = true;
            // 
            // MAHP
            // 
            this.MAHP.HeaderText = "CMND";
            this.MAHP.MinimumWidth = 15;
            this.MAHP.Name = "MAHP";
            this.MAHP.ReadOnly = true;
            // 
            // TENHP
            // 
            this.TENHP.HeaderText = "Chứng chỉ thi";
            this.TENHP.MinimumWidth = 15;
            this.TENHP.Name = "TENHP";
            this.TENHP.ReadOnly = true;
            // 
            // KETQUA
            // 
            this.KETQUA.HeaderText = "Đợt thi";
            this.KETQUA.MinimumWidth = 15;
            this.KETQUA.Name = "KETQUA";
            this.KETQUA.ReadOnly = true;
            // 
            // irhvConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2158, 483);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.ikq_btn);
            this.Name = "irhvConfirm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PHIẾU ĐĂNG KÝ DỰ THI CHỨNG CHỈ QUỐC TẾ";
            this.Load += new System.EventHandler(this.irhvConfirm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ikq_btn;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAHOCVIEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENHV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn KETQUA;
    }
}