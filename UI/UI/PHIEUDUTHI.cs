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
    public partial class PHIEUDUTHI : Form
    {
        public PHIEUDUTHI()
        {
            InitializeComponent();
        }

        private void ikq_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In giấy xác nhận đăng ký thành công.");
            MENU_TIEPNHAN m = new MENU_TIEPNHAN();
            m.Show();
            this.Dispose();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            DANGKYTHICCQT r = new DANGKYTHICCQT();
            r.Show();
            this.Close();
        }

        private void irhvConfirm_Load(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Add("Nguyễn Văn A","21/03/2000","0981724536","MOS","21/03/2021");
        }
    }
}
