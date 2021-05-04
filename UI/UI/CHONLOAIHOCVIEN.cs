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
    public partial class CHONLOAIHOCVIEN : Form
    {
        public CHONLOAIHOCVIEN()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            MENU_TIEPNHAN hv = new MENU_TIEPNHAN();
            hv.Show();
            this.Close();
        }

        private void HOCVIENMOI_Click(object sender, EventArgs e)
        {
            DANGKYHOCPHANHOCVIENMOI hvm = new DANGKYHOCPHANHOCVIENMOI();
            hvm.Show();
            this.Dispose();
        }

        private void HOCVIENCU_Click(object sender, EventArgs e)
        {
            DANGKYHOCPHANHOCVIENCU hvc = new DANGKYHOCPHANHOCVIENCU();
            hvc.Show();
            this.Dispose();
        }
    }
}
