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
    public partial class irdtkInput : Form
    {
        public irdtkInput()
        {
            InitializeComponent();
        }

        void DANGKYTHICCQT_KHAC()
        {
            string query = "EXEC DANGKYTHICCQT_KHAC @CMND , @HOTEN , @DIACHI , @SDT , @EMAIL , @MACCQT , @DOTTHI";

            DataProvider provider = new DataProvider();
            provider.ExecuteProc(query, new object[] {cmndText.Text, hotenText.Text, textBox4.Text, textBox6.Text, textBox3.Text, textBox1.Text, textBox2.Text});
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            DANGKYTHICCQT r = new DANGKYTHICCQT();
            r.Show();
            this.Close();
        }

        private void dangkyBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DANGKYTHICCQT_KHAC();
            }
            catch
            {
                MessageBox.Show("Lỗi nhập liệu");
                irdtkInput i = new irdtkInput();
                i.Show();
                this.Hide();
                return;
            }

            PHIEUDUTHI p = new PHIEUDUTHI();
            p.Show();
            this.Hide();
        }

        private void irdtkInput_Load(object sender, EventArgs e)
        {

        }

        private void hotenText_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmndText_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

