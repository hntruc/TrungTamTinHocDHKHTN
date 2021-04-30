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
    public partial class TRACUUKETQUA_KQ : Form
    {
        string mhv;
        string mhp;
        public TRACUUKETQUA_KQ()
        {
            InitializeComponent();
        }

        public void receive_info(string mahv, string mahp)
        {
            mhv = mahv;
            mhp = mahp;
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            this.Dispose();
            TRACUUKETQUA f = new TRACUUKETQUA();
            f.Show();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            MENU_TIEPNHAN nvt = new MENU_TIEPNHAN();
            nvt.Show();
            this.Dispose();
        }

        private void searchResult_Load(object sender, EventArgs e)
        {
            KetQuaHocPhan kqhp = KetQuaHocPhan.XEMKETQUA(mhv,mhp);
            this.dataGridView1.Rows.Add(kqhp.mahp, kqhp.tenhp, kqhp.mahv, kqhp.tenhv, kqhp.namhoc, kqhp.hocky, kqhp.diemhocphan, kqhp.ngay);
            if (kqhp.diemhocphan >= 5)
            { 
                this.dataGridView1.Columns[7].HeaderCell.Value = "Ngày cấp chứng chỉ";
            }
        }
        private void inketqua_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In kết quả thành công.");
            MENU_TIEPNHAN m = new MENU_TIEPNHAN();
            m.Show();
            this.Dispose();
        }
    }
}
