using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI;

namespace UI
{
    public partial class fXemDSGV : Form
    {
        public fXemDSGV()
        {
            InitializeComponent();
            Proc_XemDSGV();
        }

        void Proc_XemDSGV()
        {
            string query = "EXEC Proc_XemDSGV";
            DataProvider provider = new DataProvider();
            GridXemDSGV.DataSource = provider.ExecuteProc(query, new object[] {null});

        }

        private void GridXemDSGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void QuaylaiButton_Click(object sender, EventArgs e)
        {
            MENU_BOPHANVANPHONG b = new MENU_BOPHANVANPHONG();
            b.Show();
            this.Hide();
        }
    }
}
