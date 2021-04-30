namespace UI
{
    partial class TRACUUKETQUA_KQ
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
            this.inketqua = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MAHOCPHAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAHV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENHV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAMHOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOCKY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIEMHOCPHAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // inketqua
            // 
            this.inketqua.ForeColor = System.Drawing.Color.Maroon;
            this.inketqua.Location = new System.Drawing.Point(1766, 450);
            this.inketqua.Name = "inketqua";
            this.inketqua.Size = new System.Drawing.Size(314, 91);
            this.inketqua.TabIndex = 17;
            this.inketqua.Text = "In kết quả";
            this.inketqua.UseVisualStyleBackColor = true;
            this.inketqua.Click += new System.EventHandler(this.inketqua_Click);
            // 
            // back_btn
            // 
            this.back_btn.AutoSize = true;
            this.back_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.back_btn.BackColor = System.Drawing.SystemColors.Info;
            this.back_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn.Location = new System.Drawing.Point(133, 450);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(117, 101);
            this.back_btn.TabIndex = 18;
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
            this.MAHOCPHAN,
            this.TENHP,
            this.MAHV,
            this.TENHV,
            this.NAMHOC,
            this.HOCKY,
            this.DIEMHOCPHAN,
            this.NGAY});
            this.dataGridView1.Location = new System.Drawing.Point(133, 56);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 123;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1947, 351);
            this.dataGridView1.TabIndex = 19;
            // 
            // MAHOCPHAN
            // 
            this.MAHOCPHAN.HeaderText = "Mã học phần";
            this.MAHOCPHAN.MinimumWidth = 15;
            this.MAHOCPHAN.Name = "MAHOCPHAN";
            this.MAHOCPHAN.ReadOnly = true;
            // 
            // TENHP
            // 
            this.TENHP.HeaderText = "Tên học phần";
            this.TENHP.MinimumWidth = 15;
            this.TENHP.Name = "TENHP";
            this.TENHP.ReadOnly = true;
            // 
            // MAHV
            // 
            this.MAHV.HeaderText = "Mã học viên";
            this.MAHV.MinimumWidth = 15;
            this.MAHV.Name = "MAHV";
            this.MAHV.ReadOnly = true;
            // 
            // TENHV
            // 
            this.TENHV.HeaderText = "Tên học viên";
            this.TENHV.MinimumWidth = 15;
            this.TENHV.Name = "TENHV";
            this.TENHV.ReadOnly = true;
            // 
            // NAMHOC
            // 
            this.NAMHOC.HeaderText = "Năm học";
            this.NAMHOC.MinimumWidth = 15;
            this.NAMHOC.Name = "NAMHOC";
            this.NAMHOC.ReadOnly = true;
            // 
            // HOCKY
            // 
            this.HOCKY.HeaderText = "Học kỳ";
            this.HOCKY.MinimumWidth = 15;
            this.HOCKY.Name = "HOCKY";
            this.HOCKY.ReadOnly = true;
            // 
            // DIEMHOCPHAN
            // 
            this.DIEMHOCPHAN.HeaderText = "Điểm học phần";
            this.DIEMHOCPHAN.MinimumWidth = 15;
            this.DIEMHOCPHAN.Name = "DIEMHOCPHAN";
            this.DIEMHOCPHAN.ReadOnly = true;
            // 
            // NGAY
            // 
            this.NGAY.HeaderText = "Ngày thi lại";
            this.NGAY.MinimumWidth = 15;
            this.NGAY.Name = "NGAY";
            this.NGAY.ReadOnly = true;
            // 
            // TRACUUKETQUA_KQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2251, 615);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.inketqua);
            this.Name = "TRACUUKETQUA_KQ";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KẾT QUẢ HỌC PHẦN";
            this.Load += new System.EventHandler(this.searchResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button inketqua;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAHOCPHAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAHV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENHV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAMHOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOCKY;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIEMHOCPHAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAY;
    }
}