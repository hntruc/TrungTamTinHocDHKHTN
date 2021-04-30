using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UI
{
    public partial class DANGKYHOCPHANHOCVIENMOI : Form
    {
        string mahv;
        
        public DANGKYHOCPHANHOCVIENMOI()
        {
            InitializeComponent();
        }

        private void dangkyBtn_Click(object sender, EventArgs e)
        {
            HocVien hv = new HocVien(cmndText.Text, hotenText.Text,diachiText.Text, sdtText.Text, emailText.Text);
            int flag = HocVien.LuuHocVien(hv);
            if (flag != 0)
            {
                mahv = HocVien.LayMaHocVien(cmndText.Text.ToString());
                CHONMONHOC so = new CHONMONHOC();
                so.receive_mahv(mahv);
                so.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Thêm học viên không thành công.");
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            CHONLOAIHOCVIEN dkh = new CHONLOAIHOCVIEN();
            dkh.Show();
            this.Dispose();
        }
    }
}
