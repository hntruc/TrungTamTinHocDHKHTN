namespace UI
{
    partial class XEPPHONG
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tenphonghoc = new System.Windows.Forms.TextBox();
            this.namhoc = new System.Windows.Forms.TextBox();
            this.mahp = new System.Windows.Forms.TextBox();
            this.hocky = new System.Windows.Forms.TextBox();
            this.xn_btn = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.AutoSize = true;
            this.backBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.backBtn.BackColor = System.Drawing.SystemColors.Info;
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(1, 441);
            this.backBtn.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(64, 56);
            this.backBtn.TabIndex = 15;
            this.backBtn.Text = "⬅";
            this.backBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 54);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 123;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(229, 350);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(968, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "XẾP PHÒNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(845, 162);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nhập tên phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(845, 216);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Nhập năm học";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(845, 274);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Nhập học kỳ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(845, 329);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Mã học phần";
            // 
            // tenphonghoc
            // 
            this.tenphonghoc.Location = new System.Drawing.Point(972, 159);
            this.tenphonghoc.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.tenphonghoc.Name = "tenphonghoc";
            this.tenphonghoc.Size = new System.Drawing.Size(168, 26);
            this.tenphonghoc.TabIndex = 22;
            // 
            // namhoc
            // 
            this.namhoc.Location = new System.Drawing.Point(972, 213);
            this.namhoc.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.namhoc.Name = "namhoc";
            this.namhoc.Size = new System.Drawing.Size(168, 26);
            this.namhoc.TabIndex = 23;
            // 
            // mahp
            // 
            this.mahp.Location = new System.Drawing.Point(972, 325);
            this.mahp.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.mahp.Name = "mahp";
            this.mahp.Size = new System.Drawing.Size(168, 26);
            this.mahp.TabIndex = 24;
            // 
            // hocky
            // 
            this.hocky.Location = new System.Drawing.Point(972, 272);
            this.hocky.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.hocky.Name = "hocky";
            this.hocky.Size = new System.Drawing.Size(168, 26);
            this.hocky.TabIndex = 24;
            // 
            // xn_btn
            // 
            this.xn_btn.Location = new System.Drawing.Point(1017, 427);
            this.xn_btn.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.xn_btn.Name = "xn_btn";
            this.xn_btn.Size = new System.Drawing.Size(121, 52);
            this.xn_btn.TabIndex = 25;
            this.xn_btn.Text = "Xác nhận";
            this.xn_btn.UseVisualStyleBackColor = true;
            this.xn_btn.Click += new System.EventHandler(this.xn_btn_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(291, 54);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 123;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(529, 350);
            this.dataGridView2.TabIndex = 26;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // XEPPHONG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1214, 495);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.xn_btn);
            this.Controls.Add(this.hocky);
            this.Controls.Add(this.mahp);
            this.Controls.Add(this.namhoc);
            this.Controls.Add(this.tenphonghoc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.backBtn);
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Name = "XEPPHONG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XẾP PHÒNG";
            this.Load += new System.EventHandler(this.xpScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tenphonghoc;
        private System.Windows.Forms.TextBox namhoc;
        private System.Windows.Forms.TextBox mahp;
        private System.Windows.Forms.TextBox hocky;
        private System.Windows.Forms.Button xn_btn;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}