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

        void PROC_DANGKYTHICCQT_HV()
        {
            string query = "EXEC DANGKYTHICCQT_HV @MAHV , @HOTEN , @CMND , @MACCQT , @DOTTHI";

            DataProvider provider = new DataProvider();
            provider.ExecuteProc(query, new object[] { textBox3.Text, hotenText.Text, cmndText.Text, textBox1.Text, textBox2.Text });

        }
        private void dangkyBtn_Click(object sender, EventArgs e)
        {
            try
            {
                PROC_DANGKYTHICCQT_HV();
            }
            catch
            {
                MessageBox.Show("Lỗi nhập liệu");
                DANGKYTHICCQT_HV i = new DANGKYTHICCQT_HV();
                i.Show();
                this.Hide();
                return;
            }
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
