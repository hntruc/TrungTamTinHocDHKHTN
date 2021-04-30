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
    public partial class TRACUUKETQUA : Form
    {
        public TRACUUKETQUA()
        {
            InitializeComponent();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            MENU_TIEPNHAN n = new MENU_TIEPNHAN();
            n.Show();
        }

        private void xemketqua_Click(object sender, EventArgs e)
        {
            if (KetQuaHocPhan.KIEMTRAHV(mahv_text.Text) == 0 && KetQuaHocPhan.KIEMTRAHP(mahp_text.Text) == 0)
            {
                MessageBox.Show("Mã học viên và mã học phần không tồn tại!");
            }
            else if (KetQuaHocPhan.KIEMTRAHV(mahv_text.Text) == 0 && KetQuaHocPhan.KIEMTRAHP(mahp_text.Text) == 1)
            {
                MessageBox.Show("Mã học viên không tồn tại!");
            }
            else if (KetQuaHocPhan.KIEMTRAHP(mahp_text.Text) == 0)
            {
                MessageBox.Show("Mã học phần không tồn tại!");
            }
            else
            {
                TRACUUKETQUA_KQ s = new TRACUUKETQUA_KQ();
                s.receive_info(mahv_text.Text, mahp_text.Text);
                s.Show();
                this.Hide();
            }
        }
    }
}
