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
    public partial class MENU_KETOAN : Form
    {
        public MENU_KETOAN()
        {
            InitializeComponent();
        }

        private void dkhpBtn_Click(object sender, EventArgs e)
        {
            THANHTOANKHOAHOC ttkh = new THANHTOANKHOAHOC();
            ttkh.Show();
            this.Close();
        }

        private void dktccqtBtn_Click(object sender, EventArgs e)
        {
            THANHTOANCHUNGCHI ttcc = new THANHTOANCHUNGCHI();
            ttcc.Show();
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
