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
    public partial class irdtkInput : Form
    {
        public irdtkInput()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            DANGKYTHICCQT r = new DANGKYTHICCQT();
            r.Show();
            this.Close();
        }

        private void dangkyBtn_Click(object sender, EventArgs e)
        {
            PHIEUDUTHI p = new PHIEUDUTHI();
            p.Show();
            this.Hide();
        }
    }
}

