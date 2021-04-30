using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UI
{
    public partial class CHONMONHOC : Form
    {
        string mahv_text;
        public List<HocPhanMo> chose_list = new List<HocPhanMo>();
        public static int inputCorrect;

        public CHONMONHOC()
        {
            InitializeComponent();
        }

        public void receive_mahv(string a)
        {
            mahv_text = a;
        }

        void FillDataGridView()
        {
            var list = HocPhanMo.HienThi();

            var bindingList = new BindingList<HocPhanMo>(list);
            var source = new BindingSource(bindingList, null);

            danhSachHocPhan.DataSource = source;
            danhSachHocPhan.ReadOnly = false;
            danhSachHocPhan.Columns[9].Visible = false;
            danhSachHocPhan.Columns[10].Visible = false;
            danhSachHocPhan.Columns[0].HeaderCell.Value = "Tên môn học";
            danhSachHocPhan.Columns[1].HeaderCell.Value = "Tên giáo viên";
            danhSachHocPhan.Columns[2].HeaderCell.Value = "Sỉ số";
            danhSachHocPhan.Columns[3].HeaderCell.Value = "Giá học phần";
            danhSachHocPhan.Columns[4].HeaderCell.Value = "Năm học";
            danhSachHocPhan.Columns[5].HeaderCell.Value = "Học kỳ";
            danhSachHocPhan.Columns[6].HeaderCell.Value = "Tiết";
            danhSachHocPhan.Columns[7].HeaderCell.Value = "Ngày";
            danhSachHocPhan.Columns[8].HeaderCell.Value = "Loại học phần";
            danhSachHocPhan.Columns[11].HeaderCell.Value = "Tên học phần cơ bản";
        }

        private void subjectOption_Load(object sender, EventArgs e)
        {
            hotenLabel.Text = mahv_text;
            try
            {
                FillDataGridView();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }
        private void dangkyBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đăng ký thành công!");
            MENU_TIEPNHAN n = new MENU_TIEPNHAN();
            n.Show();
            this.Hide();
        }
        private void backBtn_Click(object sender, EventArgs e)
        {
            CHONLOAIHOCVIEN r = new CHONLOAIHOCVIEN();
            r.Show();
            this.Dispose();
        }
        private void danhSachHocPhanChon_DoubleClick(object sender, EventArgs e)
        {
            if (danhSachHocPhanChon.CurrentRow.Index != -1)
            {
                int row = danhSachHocPhanChon.CurrentRow.Index;
                DangKy.XOAHOCPHAN(chose_list[row].mahp, chose_list[row].namhoc, chose_list[row].hocky, hotenLabel.Text);
                danhSachHocPhanChon.Rows.RemoveAt(row);
                FillDataGridView();
            }
        }
        private void danhSachHocPhan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (Int32.Parse(this.danhSachHocPhan.Rows[e.RowIndex].Cells[2].Value.ToString()) < 30)
                {
                    if (Int32.Parse(this.danhSachHocPhan.Rows[e.RowIndex].Cells[8].Value.ToString()) == 0)
                    {
                        string date = DateTime.Now.ToString("yyyy-MM-dd");
                        DangKy dkdb = new DangKy();
                        dkdb.KHOITAO(this.danhSachHocPhan.Rows[e.RowIndex].Cells[9].Value.ToString(),
                            this.danhSachHocPhan.Rows[e.RowIndex].Cells[4].Value.ToString(),
                            Int32.Parse(this.danhSachHocPhan.Rows[e.RowIndex].Cells[5].Value.ToString()),
                            hotenLabel.Text,
                            LOGIN.username,
                            date);
                        int check = DangKy.THEMHOCPHAN(dkdb);
                        if (check == 1)
                        {
                            int rowId = danhSachHocPhanChon.Rows.Add();

                            this.danhSachHocPhanChon.Rows[rowId].Cells[0].Value = this.danhSachHocPhan.Rows[e.RowIndex].Cells[0].Value.ToString();
                            this.danhSachHocPhanChon.Rows[rowId].Cells[1].Value = this.danhSachHocPhan.Rows[e.RowIndex].Cells[1].Value.ToString();
                            this.danhSachHocPhanChon.Rows[rowId].Cells[2].Value = (Int32.Parse(this.danhSachHocPhan.Rows[e.RowIndex].Cells[2].Value.ToString()) + 1).ToString();
                            this.danhSachHocPhanChon.Rows[rowId].Cells[3].Value = this.danhSachHocPhan.Rows[e.RowIndex].Cells[3].Value.ToString();
                            this.danhSachHocPhanChon.Rows[rowId].Cells[4].Value = this.danhSachHocPhan.Rows[e.RowIndex].Cells[4].Value.ToString();
                            this.danhSachHocPhanChon.Rows[rowId].Cells[5].Value = this.danhSachHocPhan.Rows[e.RowIndex].Cells[5].Value.ToString();
                            this.danhSachHocPhanChon.Rows[rowId].Cells[6].Value = this.danhSachHocPhan.Rows[e.RowIndex].Cells[6].Value.ToString();
                            this.danhSachHocPhanChon.Rows[rowId].Cells[7].Value = this.danhSachHocPhan.Rows[e.RowIndex].Cells[7].Value.ToString();
                            this.danhSachHocPhanChon.Rows[rowId].Cells[8].Value = this.danhSachHocPhan.Rows[e.RowIndex].Cells[8].Value.ToString();

                            HocPhanMo subject = new HocPhanMo();

                            subject.KHOITAO(this.danhSachHocPhan.Rows[e.RowIndex].Cells[0].Value.ToString(),
                                this.danhSachHocPhan.Rows[e.RowIndex].Cells[1].Value.ToString(),
                                Int32.Parse(this.danhSachHocPhan.Rows[e.RowIndex].Cells[2].Value.ToString()),
                                (float)Convert.ToDouble(this.danhSachHocPhan.Rows[e.RowIndex].Cells[3].Value.ToString()),
                                this.danhSachHocPhan.Rows[e.RowIndex].Cells[4].Value.ToString(),
                                Int32.Parse(this.danhSachHocPhan.Rows[e.RowIndex].Cells[5].Value.ToString()),
                                Int32.Parse(this.danhSachHocPhan.Rows[e.RowIndex].Cells[6].Value.ToString()),
                                this.danhSachHocPhan.Rows[e.RowIndex].Cells[7].Value.ToString(),
                                this.danhSachHocPhan.Rows[e.RowIndex].Cells[8].Value.ToString(),
                                this.danhSachHocPhan.Rows[e.RowIndex].Cells[9].Value.ToString(),
                                this.danhSachHocPhan.Rows[e.RowIndex].Cells[10].Value.ToString(),
                                this.danhSachHocPhan.Rows[e.RowIndex].Cells[11].Value.ToString());

                            chose_list.Add(subject);
                            FillDataGridView();
                        }

                        else
                        {
                            MessageBox.Show("Học phần đã được chọn.");
                        }
                    }
                    else
                    {
                        if (DangKy.KIEMTRAHOCPHANCOBAN(this.danhSachHocPhan.Rows[e.RowIndex].Cells[10].Value.ToString(), hotenLabel.Text) == 1)
                        {
                            string date = DateTime.Now.ToString("yyyy-MM-dd");
                            DangKy dkdb = new DangKy();
                            dkdb.KHOITAO(this.danhSachHocPhan.Rows[e.RowIndex].Cells[9].Value.ToString(),
                                this.danhSachHocPhan.Rows[e.RowIndex].Cells[4].Value.ToString(),
                                Int32.Parse(this.danhSachHocPhan.Rows[e.RowIndex].Cells[5].Value.ToString()),
                                hotenLabel.Text,
                                LOGIN.username,
                                date);
                            int check = DangKy.THEMHOCPHAN(dkdb);
                            if (check == 1)
                            {
                                int rowId = danhSachHocPhanChon.Rows.Add();

                                this.danhSachHocPhanChon.Rows[rowId].Cells[0].Value = this.danhSachHocPhan.Rows[e.RowIndex].Cells[0].Value.ToString();
                                this.danhSachHocPhanChon.Rows[rowId].Cells[1].Value = this.danhSachHocPhan.Rows[e.RowIndex].Cells[1].Value.ToString();
                                this.danhSachHocPhanChon.Rows[rowId].Cells[2].Value = (Int32.Parse(this.danhSachHocPhan.Rows[e.RowIndex].Cells[2].Value.ToString()) + 1).ToString();
                                this.danhSachHocPhanChon.Rows[rowId].Cells[3].Value = this.danhSachHocPhan.Rows[e.RowIndex].Cells[3].Value.ToString();
                                this.danhSachHocPhanChon.Rows[rowId].Cells[4].Value = this.danhSachHocPhan.Rows[e.RowIndex].Cells[4].Value.ToString();
                                this.danhSachHocPhanChon.Rows[rowId].Cells[5].Value = this.danhSachHocPhan.Rows[e.RowIndex].Cells[5].Value.ToString();
                                this.danhSachHocPhanChon.Rows[rowId].Cells[6].Value = this.danhSachHocPhan.Rows[e.RowIndex].Cells[6].Value.ToString();
                                this.danhSachHocPhanChon.Rows[rowId].Cells[7].Value = this.danhSachHocPhan.Rows[e.RowIndex].Cells[7].Value.ToString();
                                this.danhSachHocPhanChon.Rows[rowId].Cells[8].Value = this.danhSachHocPhan.Rows[e.RowIndex].Cells[8].Value.ToString();

                                HocPhanMo subject = new HocPhanMo();

                                subject.KHOITAO(this.danhSachHocPhan.Rows[e.RowIndex].Cells[0].Value.ToString(),
                                    this.danhSachHocPhan.Rows[e.RowIndex].Cells[1].Value.ToString(),
                                    Int32.Parse(this.danhSachHocPhan.Rows[e.RowIndex].Cells[2].Value.ToString()),
                                    (float)Convert.ToDouble(this.danhSachHocPhan.Rows[e.RowIndex].Cells[3].Value.ToString()),
                                    this.danhSachHocPhan.Rows[e.RowIndex].Cells[4].Value.ToString(),
                                    Int32.Parse(this.danhSachHocPhan.Rows[e.RowIndex].Cells[5].Value.ToString()),
                                    Int32.Parse(this.danhSachHocPhan.Rows[e.RowIndex].Cells[6].Value.ToString()),
                                    this.danhSachHocPhan.Rows[e.RowIndex].Cells[7].Value.ToString(),
                                    this.danhSachHocPhan.Rows[e.RowIndex].Cells[8].Value.ToString(),
                                    this.danhSachHocPhan.Rows[e.RowIndex].Cells[9].Value.ToString(),
                                    this.danhSachHocPhan.Rows[e.RowIndex].Cells[10].Value.ToString(),
                                    this.danhSachHocPhan.Rows[e.RowIndex].Cells[11].Value.ToString());

                                chose_list.Add(subject);
                                FillDataGridView();
                            }
                            else
                            {
                                MessageBox.Show("Học phần đã được chọn.");
                            }
                        }
                        else
                        {
                            string date = DateTime.Now.ToString("yyyy-MM-dd");
                            DangKy dkdb = new DangKy();
                            dkdb.KHOITAO(this.danhSachHocPhan.Rows[e.RowIndex].Cells[9].Value.ToString(),
                                this.danhSachHocPhan.Rows[e.RowIndex].Cells[4].Value.ToString(),
                                Int32.Parse(this.danhSachHocPhan.Rows[e.RowIndex].Cells[5].Value.ToString()),
                                hotenLabel.Text,
                                LOGIN.username,
                                date);
                            int check = DangKy.THEMHOCPHANHVM(dkdb);
                  
                            if (check == 1)
                            {
                                int rowId = danhSachHocPhanChon.Rows.Add();

                                this.danhSachHocPhanChon.Rows[rowId].Cells[0].Value = this.danhSachHocPhan.Rows[e.RowIndex].Cells[0].Value.ToString();
                                this.danhSachHocPhanChon.Rows[rowId].Cells[1].Value = this.danhSachHocPhan.Rows[e.RowIndex].Cells[1].Value.ToString();
                                this.danhSachHocPhanChon.Rows[rowId].Cells[2].Value = (Int32.Parse(this.danhSachHocPhan.Rows[e.RowIndex].Cells[2].Value.ToString()) + 1).ToString();
                                this.danhSachHocPhanChon.Rows[rowId].Cells[3].Value = this.danhSachHocPhan.Rows[e.RowIndex].Cells[3].Value.ToString();
                                this.danhSachHocPhanChon.Rows[rowId].Cells[4].Value = this.danhSachHocPhan.Rows[e.RowIndex].Cells[4].Value.ToString();
                                this.danhSachHocPhanChon.Rows[rowId].Cells[5].Value = this.danhSachHocPhan.Rows[e.RowIndex].Cells[5].Value.ToString();
                                this.danhSachHocPhanChon.Rows[rowId].Cells[6].Value = this.danhSachHocPhan.Rows[e.RowIndex].Cells[6].Value.ToString();
                                this.danhSachHocPhanChon.Rows[rowId].Cells[7].Value = this.danhSachHocPhan.Rows[e.RowIndex].Cells[7].Value.ToString();
                                this.danhSachHocPhanChon.Rows[rowId].Cells[8].Value = this.danhSachHocPhan.Rows[e.RowIndex].Cells[8].Value.ToString();

                                HocPhanMo subject = new HocPhanMo();

                                subject.KHOITAO(this.danhSachHocPhan.Rows[e.RowIndex].Cells[0].Value.ToString(),
                                    this.danhSachHocPhan.Rows[e.RowIndex].Cells[1].Value.ToString(),
                                    Int32.Parse(this.danhSachHocPhan.Rows[e.RowIndex].Cells[2].Value.ToString()),
                                    (float)Convert.ToDouble(this.danhSachHocPhan.Rows[e.RowIndex].Cells[3].Value.ToString()),
                                    this.danhSachHocPhan.Rows[e.RowIndex].Cells[4].Value.ToString(),
                                    Int32.Parse(this.danhSachHocPhan.Rows[e.RowIndex].Cells[5].Value.ToString()),
                                    Int32.Parse(this.danhSachHocPhan.Rows[e.RowIndex].Cells[6].Value.ToString()),
                                    this.danhSachHocPhan.Rows[e.RowIndex].Cells[7].Value.ToString(),
                                    this.danhSachHocPhan.Rows[e.RowIndex].Cells[8].Value.ToString(),
                                    this.danhSachHocPhan.Rows[e.RowIndex].Cells[9].Value.ToString(),
                                    this.danhSachHocPhan.Rows[e.RowIndex].Cells[10].Value.ToString(),
                                    this.danhSachHocPhan.Rows[e.RowIndex].Cells[11].Value.ToString());

                                chose_list.Add(subject);
                                FillDataGridView();

                            }
                            else
                            {
                                MessageBox.Show("Học phần đã được chọn.");
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Sỉ số tối đa là 30 học viên.");
                }

            }
        }
    }
}