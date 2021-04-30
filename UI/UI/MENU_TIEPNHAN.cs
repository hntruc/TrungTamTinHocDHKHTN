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
    public partial class MENU_TIEPNHAN : Form
    {
        public MENU_TIEPNHAN()
        {
            InitializeComponent();
        }

        private void tckqBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
            TRACUUKETQUA si = new TRACUUKETQUA();
            si.Show();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            LOGIN lf = new LOGIN();
            lf.Show();
        }

        private void dkhpBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            CHONLOAIHOCVIEN dkh = new CHONLOAIHOCVIEN();
            dkh.Show();
        }

        private void dktccqtBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            DANGKYTHICCQT r = new DANGKYTHICCQT();
            r.Show();
        }
    }
}
