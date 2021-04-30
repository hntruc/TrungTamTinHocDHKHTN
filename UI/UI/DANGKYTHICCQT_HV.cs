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
    public partial class DANGKYTHICCQT_HV : Form
    {
        public DANGKYTHICCQT_HV()
        {
            InitializeComponent();
        }

        private void dangkyBtn_Click(object sender, EventArgs e)
        {
            PHIEUDUTHI irhv = new PHIEUDUTHI();
            irhv.Show();
            this.Hide();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            DANGKYTHICCQT r = new DANGKYTHICCQT();
            r.Show();
            this.Close();
        }
    }
}
