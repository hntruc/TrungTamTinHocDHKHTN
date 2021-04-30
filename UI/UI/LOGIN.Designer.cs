namespace UI
{
    partial class LOGIN
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
            this.usernameText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dangnhapBtn = new System.Windows.Forms.Button();
            this.usernameError = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.errLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // usernameText
            // 
            this.usernameText.Location = new System.Drawing.Point(419, 105);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(652, 44);
            this.usernameText.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // dangnhapBtn
            // 
            this.dangnhapBtn.Location = new System.Drawing.Point(850, 348);
            this.dangnhapBtn.Name = "dangnhapBtn";
            this.dangnhapBtn.Size = new System.Drawing.Size(221, 101);
            this.dangnhapBtn.TabIndex = 6;
            this.dangnhapBtn.Text = "Đăng nhập";
            this.dangnhapBtn.UseVisualStyleBackColor = true;
            this.dangnhapBtn.Click += new System.EventHandler(this.dangnhapBtn_Click);
            // 
            // usernameError
            // 
            this.usernameError.AutoSize = true;
            this.usernameError.ForeColor = System.Drawing.Color.Red;
            this.usernameError.Location = new System.Drawing.Point(412, 183);
            this.usernameError.Name = "usernameError";
            this.usernameError.Size = new System.Drawing.Size(0, 37);
            this.usernameError.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(63, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 101);
            this.button1.TabIndex = 8;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(419, 223);
            this.passwordText.Name = "passwordText";
            this.passwordText.PasswordChar = '*';
            this.passwordText.Size = new System.Drawing.Size(652, 44);
            this.passwordText.TabIndex = 9;
            // 
            // errLabel
            // 
            this.errLabel.AutoSize = true;
            this.errLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.errLabel.Location = new System.Drawing.Point(419, 297);
            this.errLabel.Name = "errLabel";
            this.errLabel.Size = new System.Drawing.Size(0, 37);
            this.errLabel.TabIndex = 10;
            // 
            // LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1129, 516);
            this.Controls.Add(this.errLabel);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.usernameError);
            this.Controls.Add(this.dangnhapBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.usernameText);
            this.Controls.Add(this.label1);
            this.Name = "LOGIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐĂNG NHẬP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usernameText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button dangnhapBtn;
        private System.Windows.Forms.Label usernameError;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Label errLabel;
    }
}