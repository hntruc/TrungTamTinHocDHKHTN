using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    public class HocVien
    {
        public string tenHV { get; set; }
        public string diachi { get; set; }
        public string sdt { get; set; }
        public string email { get; set; }
        public string cmnd { get; set; }

        public HocVien (string cmnd, string tenHV, string diachi, string sdt, string email)
        {
            this.tenHV = tenHV;
            this.diachi = diachi;
            this.sdt = sdt;
            this.email = email;
            this.cmnd = cmnd;
        }

        static public int LuuHocVien(HocVien hv)
        {
            int check = HocVienDB.THEMHOCVIEN(hv.cmnd, hv.tenHV, hv.diachi, hv.sdt, hv.email);
            return check;
        }

        static public string LayMaHocVien(string cmnd)
        {
            return HocVienDB.LayMaHocVien(cmnd);
        }

        static public int KiemTraCMND(string cmnd)
        {
            return HocVienDB.KiemTraCMND(cmnd);
        }
    }
}
