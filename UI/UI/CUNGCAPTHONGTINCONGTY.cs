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
    public partial class CUNGCAPTHONGTINCONGTY : Form
    {
        public CUNGCAPTHONGTINCONGTY()
        {
            InitializeComponent();
        }

        private void ihd_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In hóa đơn thành công");
            MENU_KETOAN nvkt = new MENU_KETOAN();
            nvkt.Show();
            this.Dispose();
        }

        void Proc_luuhoadon()
        {
            DataProvider provider = new DataProvider();
            string query = "EXEC INHOADONCONGTY @masothue, @mahv, @tencongty";
            provider.ExecuteProc(query, new object[] { textBox4.Text, textBox3.Text, textBox1.Text });
        }


        private void luu_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In hóa đơn thành công");
        
            try
            {
                Proc_luuhoadon();
            }
            catch
            {
                MessageBox.Show("Lỗi nhập liệu");

            }

            MENU_KETOAN m = new MENU_KETOAN();
            m.Show();
            this.Dispose();

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            MENU_KETOAN m = new MENU_KETOAN();
            m.Show();
            this.Dispose();
        }

        private void CUNGCAPTHONGTINCONGTY_Load(object sender, EventArgs e)
        {

        }
    }
}
