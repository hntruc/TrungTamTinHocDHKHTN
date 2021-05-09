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
    public partial class THANHTOANKHOAHOC : Form
    {
        public THANHTOANKHOAHOC()
        {
            InitializeComponent();
        }

        private void ihdct_btn_Click(object sender, EventArgs e)
        {
            CUNGCAPTHONGTINCONGTY bci = new CUNGCAPTHONGTINCONGTY();
            bci.Show();
            this.Dispose();
        }


        private void THANHTOANKHOAHOC_Load(object sender, EventArgs e)
        {

        }

        void Proc_thanhtoankhoahoc()
        {
            string query = "EXEC THANHTOAN_HDHP @TONGTIEN, @THANHTOAN, @MAHV, @MANV";

            DataProvider provider = new DataProvider();
            if (radioButton1.Checked == true)
                provider.ExecuteProc(query, new object[] { textBox4.Text, radioButton1.Text, textBox3.Text, textBox2.Text });
            else if (radioButton2.Checked == true)
                provider.ExecuteProc(query, new object[] { textBox4.Text, radioButton2.Text, textBox3.Text, textBox2.Text });

        }

        private void ihdtt_btn_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("In hóa đơn thành công");
            
            try
            {
                Proc_thanhtoankhoahoc();
            }
            catch
            {
                MessageBox.Show("Lỗi nhập liệu");

            }

            INHOADONCONGTY i = new INHOADONCONGTY();
            i.Show();
            this.Hide();
        }

        private void backBtn_Click_1(object sender, EventArgs e)
        {
            MENU_KETOAN m = new MENU_KETOAN();
            m.Show();
            this.Dispose();
        }
    }
}
