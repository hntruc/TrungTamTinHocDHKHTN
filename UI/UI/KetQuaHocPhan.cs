using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    public class KetQuaHocPhan
    {
        public string mahp { get; set; }
        public string mahv { get; set; }
        public string namhoc { get; set; }
        public int hocky { get; set; }
        public float diemhocphan { get; set; }
        public string ngay { get; set; }
        public string tenhp { get; set; }
        public string tenhv { get; set; }

        public void KHOITAO(string mahp, string mahv, string namhoc, int hocky, float diemhocphan, string tenhv, string tenhp, string ngay)
        {
            this.mahp = mahp;
            this.mahv = mahv;
            this.namhoc = namhoc;
            this.hocky = hocky;
            this.diemhocphan = diemhocphan;
            this.tenhv = tenhv;
            this.tenhp = tenhp;
            this.ngay = ngay;
        }
        public KetQuaHocPhan() { }
        static public KetQuaHocPhan XEMKETQUA(string mahv, string mahp)
        {
            KetQuaHocPhan res = KetQuaHocPhanDB.XEMKETQUA(mahv, mahp);
            return res;
        }
        public static int KIEMTRAHV(string mahv)
        {
            int check = KetQuaHocPhanDB.KIEMTRAHV(mahv);
            if (check == 1)
            {
                return 1;
            }
            else
                return 0;
        }
        public static int KIEMTRAHP(string mahp)
        {
            int check = KetQuaHocPhanDB.KIEMTRAHP(mahp);
            if (check == 1)
            {
                return 1;
            }
            else
                return 0;
        }

    }
}
