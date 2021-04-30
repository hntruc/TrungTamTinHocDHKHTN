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
    public partial class THANHTOANCHUNGCHI : Form
    {
        public THANHTOANCHUNGCHI()
        {
            InitializeComponent();
        }

        private void payInputCC_Load(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Add("025991225","1000000");
        }

        private void ihdtt_btn_Click(object sender, EventArgs e)
        {
            INHOADONCONGTY i = new INHOADONCONGTY();
            i.Show();
            this.Hide();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            MENU_KETOAN m = new MENU_KETOAN();
            m.Show();
            this.Dispose();
        }
    }
}
