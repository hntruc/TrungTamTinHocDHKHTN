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

        private void ihdtt_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In hóa đơn thành công");
            INHOADONCONGTY i = new INHOADONCONGTY();
            i.Show();
            this.Hide();
        }

        private void ihdct_btn_Click(object sender, EventArgs e)
        {
            CUNGCAPTHONGTINCONGTY bci = new CUNGCAPTHONGTINCONGTY();
            bci.Show();
            this.Dispose();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            MENU_KETOAN m = new MENU_KETOAN();
            m.Show();
            this.Dispose();
        }

        private void payInput_Load(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Add("HV001", "1.500.000");
        }
    }
}
