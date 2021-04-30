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
    public partial class MENU_BOPHANVANPHONG : Form
    {
        public MENU_BOPHANVANPHONG()
        {
            InitializeComponent();
        }

        private void xp_btn_Click(object sender, EventArgs e)
        {
            XEPPHONG x = new XEPPHONG();
            x.Show();
            this.Close();
        }

        private void lhgv_btn_Click(object sender, EventArgs e)
        {
            TIMGIAOVIENLIENLAC l = new TIMGIAOVIENLIENLAC();
            l.Show();
            this.Close();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            LOGIN l = new LOGIN();
            l.Show();
            this.Close();
        }
    }
}
