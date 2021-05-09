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
    public partial class THANHTOANCHUNGCHI : Form
    {
        public THANHTOANCHUNGCHI()
        {
            InitializeComponent();
        }

        void Proc_thanhtoanchungchi()
        {
            string query = "EXEC THANHTOAN_HDCC @TONGTIEN, @THANHTOAN, @MANV, @CMND";

            DataProvider provider = new DataProvider();
            if (radioButton1.Checked == true)
                provider.ExecuteProc(query, new object[] { textBox4.Text, radioButton1.Text, textBox1.Text, textBox2.Text });
            else if (radioButton2.Checked == true)
                provider.ExecuteProc(query, new object[] { textBox4.Text, radioButton2.Text, textBox1.Text, textBox2.Text });

        }

        private void ihdtt_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In hóa đơn thành công");
            try
            {
                Proc_thanhtoanchungchi();
            }
            catch
            {
                MessageBox.Show("Lỗi nhập liệu");

            }


            INHOADONCONGTY i = new INHOADONCONGTY();
            i.Show();
            this.Hide();

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            MENU_KETOAN m = new MENU_KETOAN();
            m.Show();
            this.Dispose();
        }

        private void THANHTOANCHUNGCHI_Load_1(object sender, EventArgs e)
        {

        }
    }
}
