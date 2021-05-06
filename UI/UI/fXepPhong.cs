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
    public partial class fXepPhong : Form
    {
        public fXepPhong()
        {
            InitializeComponent();

            loadTenPhongHoc();
            loadChitietPhongHoc();
            loadHocphanmo();

        }

        void loadTenPhongHoc()
        {
            string query = "Select tenphonghoc as N'Tên phòng học' from dbo.PhongHoc";
            DataProvider provider = new DataProvider();
            GridTenPH.DataSource = provider.ExecuteQuery(query);
        }

        void loadChitietPhongHoc()
        {
            string query = "select mahp, namhoc, hocky, tenphonghoc from chitietphonghoc";
            DataProvider provider = new DataProvider();
            Gridchitietph.DataSource = provider.ExecuteQuery(query);
        }

        void loadHocphanmo()
        {
            string query = "select mahp, namhoc, hocky, ngay, tiet from hocphanmo";
            DataProvider provider = new DataProvider();
            GridHocphanmo.DataSource = provider.ExecuteQuery(query);
        }

        void Proc_XepPhong()
        {
            string query = "EXEC Proc_XepPhong @mahp , @namhoc , @hocky , @tenphonghoc";

            DataProvider provider = new DataProvider();
            int hk = Convert.ToInt32(hocky.Text);
            provider.ExecuteProc(query, new object[] { mahp.Text, namhoc.Text, hk, tenphonghoc.Text });

        }
        private void xn_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Proc_XepPhong();
            }
            catch
            {
                MessageBox.Show("Lỗi nhập liệu");

            }

            fXepPhong f = new fXepPhong();
            f.Show();
            this.Close();
        }

        private void fXepPhong_Load(object sender, EventArgs e)
        {

        }


        private void GridTenPH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Gridchitietph_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GridHocphanmo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MENU_BOPHANVANPHONG b = new MENU_BOPHANVANPHONG();
            b.Show();
            this.Hide();
        }
    }
}
