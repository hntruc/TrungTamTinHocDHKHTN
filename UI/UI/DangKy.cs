using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    public class DangKy
    {
        public string mahp { get; set; }
        public string namhoc { get; set; }
        public int hocky { get; set; }
        public string mahv { get; set; }
        public string manv { get; set; }
        public string ngay { get; set; }

        public DangKy() { }

        public void KHOITAO (string mahp, string namhoc, int hocky,
            string mahv, string manv, string ngay)
        {
            this.mahp = mahp;
            this.namhoc = namhoc;
            this.hocky = hocky;
            this.mahv = mahv;
            this.manv = manv;
            this.ngay = ngay;
        }

        public static int THEMHOCPHAN(DangKy dk)
        {
            int check = DangKyDB.THEMHOCPHAN(dk);
            if (check == 1)
            {
                return 1;
            }
            else
                return 0;
        }

        public static int THEMHOCPHANHVM(DangKy dk)
        {
            int check = DangKyDB.THEMHOCPHANHVM(dk);
            if (check == 1)
            {
                return 1;
            }
            else
                return 0;
        }

        public static void XOAHOCPHAN(string mahp, string namhoc, int hocky, string mahv)
        {
            DangKyDB.XOAHOCPHAN(mahp, namhoc, hocky, mahv);
        }

        public static int KIEMTRAHOCPHANCOBAN(string mahp, string mahv)
        {
            return DangKyDB.KIEMTRAHOCPHANCOBAN(mahp, mahv);
        }
    }
}
