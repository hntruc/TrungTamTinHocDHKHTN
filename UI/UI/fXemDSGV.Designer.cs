
namespace UI
{
    partial class fXemDSGV
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
            this.GridXemDSGV = new System.Windows.Forms.DataGridView();
            this.QuaylaiButton = new System.Windows.Forms.Button();
            this.Danhsachgv = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridXemDSGV)).BeginInit();
            this.SuspendLayout();
            // 
            // GridXemDSGV
            // 
            this.GridXemDSGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridXemDSGV.Location = new System.Drawing.Point(12, 85);
            this.GridXemDSGV.Name = "GridXemDSGV";
            this.GridXemDSGV.RowHeadersWidth = 62;
            this.GridXemDSGV.RowTemplate.Height = 28;
            this.GridXemDSGV.Size = new System.Drawing.Size(776, 378);
            this.GridXemDSGV.TabIndex = 0;
            this.GridXemDSGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridXemDSGV_CellContentClick);
            // 
            // QuaylaiButton
            // 
            this.QuaylaiButton.Location = new System.Drawing.Point(12, 491);
            this.QuaylaiButton.Name = "QuaylaiButton";
            this.QuaylaiButton.Size = new System.Drawing.Size(120, 41);
            this.QuaylaiButton.TabIndex = 1;
            this.QuaylaiButton.Text = "Quay lại";
            this.QuaylaiButton.UseVisualStyleBackColor = true;
            this.QuaylaiButton.Click += new System.EventHandler(this.QuaylaiButton_Click);
            // 
            // Danhsachgv
            // 
            this.Danhsachgv.AutoSize = true;
            this.Danhsachgv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Danhsachgv.Location = new System.Drawing.Point(12, 24);
            this.Danhsachgv.Name = "Danhsachgv";
            this.Danhsachgv.Size = new System.Drawing.Size(247, 29);
            this.Danhsachgv.TabIndex = 2;
            this.Danhsachgv.Text = "Danh sách giáo viên";
            // 
            // fXemDSGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 544);
            this.Controls.Add(this.Danhsachgv);
            this.Controls.Add(this.QuaylaiButton);
            this.Controls.Add(this.GridXemDSGV);
            this.Name = "fXemDSGV";
            this.Text = "Xem danh sách giáo viên";
            ((System.ComponentModel.ISupportInitialize)(this.GridXemDSGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridXemDSGV;
        private System.Windows.Forms.Button QuaylaiButton;
        private System.Windows.Forms.Label Danhsachgv;
    }
}