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
    public partial class XEPPHONG : Form
    {
        public XEPPHONG()
        {
            InitializeComponent();
        }

        private void xpScreen_Load(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Add("Phòng I.32");
            this.dataGridView1.Rows.Add("Phòng I.86");

            this.dataGridView2.Rows.Add("I.32", "MH001", "2020-2021", "1", "GV001");
            this.dataGridView2.Rows.Add("I.86", "MH002", "2020-2021", "1", "GV002");
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            MENU_BOPHANVANPHONG b = new MENU_BOPHANVANPHONG();
            b.Show();
            this.Hide();
        }
    }
}
