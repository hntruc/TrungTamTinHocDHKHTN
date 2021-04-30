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

        private void luu_btn_Click(object sender, EventArgs e)
        {
            
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            MENU_KETOAN m = new MENU_KETOAN();
            m.Show();
            this.Dispose();
        }
    }
}
