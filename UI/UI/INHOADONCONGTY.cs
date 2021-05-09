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
    public partial class INHOADONCONGTY : Form
    {
        public INHOADONCONGTY()
        {
            InitializeComponent();
        }

        private void yes_btn_Click(object sender, EventArgs e)
        {
            CUNGCAPTHONGTINCONGTY c = new CUNGCAPTHONGTINCONGTY();
            c.Show();
            this.Hide();
        }

        private void no_btn_Click(object sender, EventArgs e)
        {
            MENU_KETOAN m = new MENU_KETOAN();
            m.Show();
            this.Dispose();
        }

        private void INHOADONCONGTY_Load(object sender, EventArgs e)
        {

        }
    }
}
