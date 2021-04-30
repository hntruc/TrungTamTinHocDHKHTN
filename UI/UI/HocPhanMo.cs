using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    public class HocPhanMo
    {
        public string tenhp { get; set; }
        public string tengv { get; set; }
        public int tongsl { get; set; }
        public float giahocphan { get; set; }
        public string namhoc { get; set; }
        public int hocky { get; set; }
        public int tiet { get; set; }
        public string ngay { get; set; }
        public string loaihp { get; set; }
        public string mahp { get; set; }
        public string mahpcb { get; set; }
        public string tenhpcb { get; set; }

        public void KHOITAO(string tenhp, string tengv, int tongsl, float giahocphan, string namhoc,
            int hocky, int tiet, string ngay, string loaihp, string mahp, string mahpcb, string tenhpcb)
        {
            this.tenhp = tenhp;
            this.tengv = tengv;
            this.tongsl = tongsl;
            this.giahocphan = giahocphan;
            this.namhoc = namhoc;
            this.hocky = hocky;
            this.tiet = tiet;
            this.ngay = ngay;
            this.loaihp = loaihp;
            this.mahp = mahp;
            this.mahpcb = mahpcb;
            this.tenhpcb = tenhpcb;
        }
        public HocPhanMo() { }
        static public List<HocPhanMo> HienThi()
        {
            List<HocPhanMo> listSubjects = new List<HocPhanMo>();
            listSubjects = HocPhanMoDB.HIENTHI();
            return listSubjects;
        }
    }
}
