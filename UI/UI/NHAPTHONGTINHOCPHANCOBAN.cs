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
    public partial class NHAPTHONGTINHOCPHANCOBAN : Form
    {
        public static int xacnhan_coban;
        public NHAPTHONGTINHOCPHANCOBAN()
        {
            InitializeComponent();
        }
        private void xacnhan_Click(object sender, EventArgs e)
        {
            if (yes.Checked)
            {
                xacnhan_coban = 1;
                this.Close();
            }
            else
            {
                xacnhan_coban = 0;
                this.Close();
            }
        }
    }
}
