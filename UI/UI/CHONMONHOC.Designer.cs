namespace UI
{
    partial class CHONMONHOC
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
            this.inphieudangkyBtn = new System.Windows.Forms.Button();
            this.hotenLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.danhSachHocPhanChon = new System.Windows.Forms.DataGridView();
            this.TENMHS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SISO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAMHOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOCKY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIET = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LOAIHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAHPCB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENHPCB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.danhSachHocPhan = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.danhSachHocPhanChon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhSachHocPhan)).BeginInit();
            this.SuspendLayout();
            // 
            // inphieudangkyBtn
            // 
            this.inphieudangkyBtn.ForeColor = System.Drawing.Color.Maroon;
            this.inphieudangkyBtn.Location = new System.Drawing.Point(2017, 1540);
            this.inphieudangkyBtn.Name = "inphieudangkyBtn";
            this.inphieudangkyBtn.Size = new System.Drawing.Size(326, 131);
            this.inphieudangkyBtn.TabIndex = 1;
            this.inphieudangkyBtn.Text = "In phiếu đăng ký";
            this.inphieudangkyBtn.UseVisualStyleBackColor = true;
            this.inphieudangkyBtn.Click += new System.EventHandler(this.inphieudangkyBtn_Click);
            // 
            // hotenLabel
            // 
            this.hotenLabel.AutoSize = true;
            this.hotenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotenLabel.ForeColor = System.Drawing.Color.Maroon;
            this.hotenLabel.Location = new System.Drawing.Point(250, 26);
            this.hotenLabel.Name = "hotenLabel";
            this.hotenLabel.Size = new System.Drawing.Size(140, 44);
            this.hotenLabel.TabIndex = 2;
            this.hotenLabel.Text = "HV001";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 44);
            this.label1.TabIndex = 3;
            this.label1.Text = "Học viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(41, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(467, 55);
            this.label2.TabIndex = 4;
            this.label2.Text = "Danh sách học phần";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(25, 817);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(649, 55);
            this.label3.TabIndex = 5;
            this.label3.Text = "Danh sách học phần đăng ký";
            // 
            // backBtn
            // 
            this.backBtn.AutoSize = true;
            this.backBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.backBtn.BackColor = System.Drawing.SystemColors.Info;
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(38, 1554);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(117, 101);
            this.backBtn.TabIndex = 12;
            this.backBtn.Text = "⬅";
            this.backBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // danhSachHocPhanChon
            // 
            this.danhSachHocPhanChon.AllowUserToAddRows = false;
            this.danhSachHocPhanChon.AllowUserToDeleteRows = false;
            this.danhSachHocPhanChon.AllowUserToResizeRows = false;
            this.danhSachHocPhanChon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.danhSachHocPhanChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.danhSachHocPhanChon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TENMHS,
            this.TENGV,
            this.SISO,
            this.GIA,
            this.NAMHOC,
            this.HOCKY,
            this.TIET,
            this.NGAY,
            this.LOAIHP,
            this.MAHP,
            this.MAHPCB,
            this.TENHPCB});
            this.danhSachHocPhanChon.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.danhSachHocPhanChon.Location = new System.Drawing.Point(38, 911);
            this.danhSachHocPhanChon.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.danhSachHocPhanChon.Name = "danhSachHocPhanChon";
            this.danhSachHocPhanChon.ReadOnly = true;
            this.danhSachHocPhanChon.RowHeadersWidth = 123;
            this.danhSachHocPhanChon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.danhSachHocPhanChon.Size = new System.Drawing.Size(2305, 549);
            this.danhSachHocPhanChon.TabIndex = 13;
            this.danhSachHocPhanChon.DoubleClick += new System.EventHandler(this.danhSachHocPhanChon_DoubleClick);
            // 
            // TENMHS
            // 
            this.TENMHS.HeaderText = "Tên môn học";
            this.TENMHS.MinimumWidth = 15;
            this.TENMHS.Name = "TENMHS";
            this.TENMHS.ReadOnly = true;
            // 
            // TENGV
            // 
            this.TENGV.HeaderText = "Tên giáo viên";
            this.TENGV.MinimumWidth = 15;
            this.TENGV.Name = "TENGV";
            this.TENGV.ReadOnly = true;
            // 
            // SISO
            // 
            this.SISO.HeaderText = "Sỉ số";
            this.SISO.MinimumWidth = 15;
            this.SISO.Name = "SISO";
            this.SISO.ReadOnly = true;
            // 
            // GIA
            // 
            this.GIA.HeaderText = "Giá";
            this.GIA.MinimumWidth = 15;
            this.GIA.Name = "GIA";
            this.GIA.ReadOnly = true;
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
            // TIET
            // 
            this.TIET.HeaderText = "Tiết";
            this.TIET.MinimumWidth = 15;
            this.TIET.Name = "TIET";
            this.TIET.ReadOnly = true;
            // 
            // NGAY
            // 
            this.NGAY.HeaderText = "Ngày học";
            this.NGAY.MinimumWidth = 15;
            this.NGAY.Name = "NGAY";
            this.NGAY.ReadOnly = true;
            // 
            // LOAIHP
            // 
            this.LOAIHP.HeaderText = "Loại học phần";
            this.LOAIHP.MinimumWidth = 15;
            this.LOAIHP.Name = "LOAIHP";
            this.LOAIHP.ReadOnly = true;
            // 
            // MAHP
            // 
            this.MAHP.HeaderText = "Mã học phần";
            this.MAHP.MinimumWidth = 15;
            this.MAHP.Name = "MAHP";
            this.MAHP.ReadOnly = true;
            this.MAHP.Visible = false;
            // 
            // MAHPCB
            // 
            this.MAHPCB.HeaderText = "Mã học phần cơ bản";
            this.MAHPCB.MinimumWidth = 15;
            this.MAHPCB.Name = "MAHPCB";
            this.MAHPCB.ReadOnly = true;
            this.MAHPCB.Visible = false;
            // 
            // TENHPCB
            // 
            this.TENHPCB.HeaderText = "Tên học phần cơ bản";
            this.TENHPCB.MinimumWidth = 15;
            this.TENHPCB.Name = "TENHPCB";
            this.TENHPCB.ReadOnly = true;
            // 
            // danhSachHocPhan
            // 
            this.danhSachHocPhan.AllowUserToAddRows = false;
            this.danhSachHocPhan.AllowUserToDeleteRows = false;
            this.danhSachHocPhan.AllowUserToResizeRows = false;
            this.danhSachHocPhan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.danhSachHocPhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.danhSachHocPhan.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.danhSachHocPhan.Location = new System.Drawing.Point(38, 211);
            this.danhSachHocPhan.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.danhSachHocPhan.Name = "danhSachHocPhan";
            this.danhSachHocPhan.ReadOnly = true;
            this.danhSachHocPhan.RowHeadersWidth = 123;
            this.danhSachHocPhan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.danhSachHocPhan.Size = new System.Drawing.Size(2305, 549);
            this.danhSachHocPhan.TabIndex = 0;
            this.danhSachHocPhan.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.danhSachHocPhan_CellDoubleClick);
            // 
            // CHONMONHOC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2394, 1722);
            this.Controls.Add(this.danhSachHocPhanChon);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hotenLabel);
            this.Controls.Add(this.inphieudangkyBtn);
            this.Controls.Add(this.danhSachHocPhan);
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "CHONMONHOC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐĂNG KÝ HỌC PHẦN";
            this.Load += new System.EventHandler(this.subjectOption_Load);
            ((System.ComponentModel.ISupportInitialize)(this.danhSachHocPhanChon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhSachHocPhan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button inphieudangkyBtn;
        private System.Windows.Forms.Label hotenLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.DataGridView danhSachHocPhanChon;
        private System.Windows.Forms.DataGridView danhSachHocPhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENMHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SISO;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAMHOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOCKY;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIET;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAY;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOAIHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAHPCB;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENHPCB;
    }
}