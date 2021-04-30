using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class LOGIN : Form
    {
        public static string username;
        public LOGIN()
        {
            InitializeComponent();
        }

        private void dangnhapBtn_Click(object sender, EventArgs e)
        {
            username = usernameText.Text;
            if (usernameText.Text == "NV01" && passwordText.Text == "abc")
            {
                MENU_TIEPNHAN menu = new MENU_TIEPNHAN();
                menu.Show();
                this.Hide();
            }
            else if (usernameText.Text == "NV01" && passwordText.Text != "abc")
            {

                errLabel.Text = "Sai mật khẩu!";
            }
            else if (usernameText.Text == "NV02" && passwordText.Text == "xyz")
            {
                MENU_KETOAN menu = new MENU_KETOAN();
                menu.Show();
                this.Hide();
            }
            else if (usernameText.Text == "NV02" && passwordText.Text != "xyz")
            {
                errLabel.Text = "Sai mật khẩu!";
            }
            else if (usernameText.Text == "NV03" && passwordText.Text == "def")
            {
                MENU_BOPHANVANPHONG menu = new MENU_BOPHANVANPHONG();
                menu.Show();
                this.Hide();
            }
            else if (usernameText.Text == "NV03" && passwordText.Text != "def")
            {
                errLabel.Text = "Sai mật khẩu!";
            }
            else
            {
                errLabel.Text = "Tài khoản không hợp lệ!";
            }
            /* if (String.IsNullOrEmpty(usernameText.Text))
             {
                 var t = new Timer();
                 t.Interval = 2000;
                 t.Tick += (s, en) =>
                 {
                     usernameError.Hide();
                     t.Stop();
                 };
                 t.Start();
                 usernameError.Text = "Vui lòng nhập username.";
             }

             if (String.IsNullOrEmpty(password_Text.Text))
             {
                 var t = new Timer();
                 t.Interval = 2000;
                 t.Tick += (s, en) =>
                 {
                     passwordError.Hide();
                     t.Stop();
                 };
                 t.Start();
                 passwordError.Text = "Vui lòng nhập password.";
             }

             if ((!String.IsNullOrEmpty(usernameText.Text)) & (!String.IsNullOrEmpty(password_Text.Text)))
             {
                 if ((nvkt_radio.Checked == false) & (nvtp_radio.Checked == false))
                 {
                     var t = new Timer();
                     t.Interval = 2000;
                     t.Tick += (s, en) =>
                     {
                         radioError.Hide();
                         t.Stop();
                     };
                     t.Start();
                     radioError.Text = "Vui lòng chọn loại người dùng.";
                 }
                 if (nvkt_radio.Checked == true)
                 {
                     this.Close();
                     payInput pi = new payInput();
                     pi.Show();
                 }
                 else if (nvtp_radio.Checked == true)
                 {
                     nvtpOption nvtp = new nvtpOption();
                     nvtp.Show();
                     this.Hide();
                 }
             }*/

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
            //System.Environment.Exit(0);
        }
    }
}
