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
    public partial class TIMGIAOVIENLIENLAC : Form
    {
        public TIMGIAOVIENLIENLAC()
        {
            InitializeComponent();
        }

        private void lhgvScreen_Load(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Add("GV001", "Nguyen Thi Van","0918762531",
                "ntvan@gmail.com","ban");
            this.dataGridView1.Rows.Add("GV002", "Lam Quoc Trung", "0925778532",
                "lqtrung@gmail.com", "trong");
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            MENU_BOPHANVANPHONG b = new MENU_BOPHANVANPHONG();
            b.Show();
            this.Hide();
        }
    }
}
