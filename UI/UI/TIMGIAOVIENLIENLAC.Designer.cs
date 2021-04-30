namespace UI
{
    partial class TIMGIAOVIENLIENLAC
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
            this.MAGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TINHTRANG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.AutoSize = true;
            this.backBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.backBtn.BackColor = System.Drawing.SystemColors.Info;
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(0, 671);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(117, 101);
            this.backBtn.TabIndex = 14;
            this.backBtn.Text = "⬅";
            this.backBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAGV,
            this.TENGV,
            this.SDT,
            this.EMAIL,
            this.TINHTRANG});
            this.dataGridView1.Location = new System.Drawing.Point(48, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 123;
            this.dataGridView1.RowTemplate.Height = 46;
            this.dataGridView1.Size = new System.Drawing.Size(1627, 590);
            this.dataGridView1.TabIndex = 15;
            // 
            // MAGV
            // 
            this.MAGV.HeaderText = "MÃ GIÁO VIÊN";
            this.MAGV.MinimumWidth = 15;
            this.MAGV.Name = "MAGV";
            this.MAGV.Width = 300;
            // 
            // TENGV
            // 
            this.TENGV.HeaderText = "HỌ TÊN";
            this.TENGV.MinimumWidth = 15;
            this.TENGV.Name = "TENGV";
            this.TENGV.Width = 300;
            // 
            // SDT
            // 
            this.SDT.HeaderText = "SDT";
            this.SDT.MinimumWidth = 15;
            this.SDT.Name = "SDT";
            this.SDT.Width = 300;
            // 
            // EMAIL
            // 
            this.EMAIL.HeaderText = "EMAIL";
            this.EMAIL.MinimumWidth = 15;
            this.EMAIL.Name = "EMAIL";
            this.EMAIL.Width = 300;
            // 
            // TINHTRANG
            // 
            this.TINHTRANG.HeaderText = "TÌNH TRẠNG";
            this.TINHTRANG.MinimumWidth = 15;
            this.TINHTRANG.Name = "TINHTRANG";
            this.TINHTRANG.Width = 300;
            // 
            // TIMGIAOVIENLIENLAC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1733, 774);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.backBtn);
            this.Name = "TIMGIAOVIENLIENLAC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LIÊN HỆ GIÁO VIÊN";
            this.Load += new System.EventHandler(this.lhgvScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMAIL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TINHTRANG;
    }
}