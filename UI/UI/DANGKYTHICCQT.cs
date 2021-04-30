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
    public partial class DANGKYTHICCQT : Form
    {
        public DANGKYTHICCQT()
        {
            InitializeComponent();
        }

        private void hv_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            DANGKYTHICCQT_HV i = new DANGKYTHICCQT_HV();
            i.Show();
        }

        private void dtk_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            irdtkInput i = new irdtkInput();
            i.Show();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            MENU_TIEPNHAN n = new MENU_TIEPNHAN();
            n.Show();
            this.Close();
        }
    }
}
