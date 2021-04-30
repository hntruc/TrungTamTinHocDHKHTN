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
    public partial class DANGKYHOCPHANHOCVIENCU : Form
    {
        string mahv;
        public DANGKYHOCPHANHOCVIENCU()
        {
            InitializeComponent();
        }

        private void dangkyBtn_Click(object sender, EventArgs e)
        {
            mahv = HocVien.LayMaHocVien(cmndText.Text.ToString());
            if (mahv.Length == 4)
            {
                CHONMONHOC so = new CHONMONHOC();
                so.receive_mahv(mahv);
                so.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("CMND không hợp lệ!");
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            CHONLOAIHOCVIEN dkh = new CHONLOAIHOCVIEN();
            dkh.Show();
            this.Dispose();
        }
    }
}
