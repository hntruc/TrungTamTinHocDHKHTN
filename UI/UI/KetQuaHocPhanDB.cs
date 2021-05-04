using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace UI
{
    public class KetQuaHocPhanDB
    {
        static public KetQuaHocPhan XEMKETQUA (string mahv, string mahp)
        {
            Connect c = new Connect();
            SqlCommand cmd = new SqlCommand("TRACUUKETQUA", c.conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MAHV", mahv));
            cmd.Parameters.Add(new SqlParameter("@MAHP", mahp));
            KetQuaHocPhan kqhp = new KetQuaHocPhan();
            using (SqlDataReader r = cmd.ExecuteReader())
            {
                if (r.Read())
                {
                    kqhp.KHOITAO(
                        r["MAHP"].ToString(),
                        r["MAHV"].ToString(),
                        r["NAMHOC"].ToString(),
                        Int32.Parse(r["HOCKY"].ToString()),
                        (float)Convert.ToDouble(r["DIEMHOCPHAN"].ToString()),
                        r["TENHV"].ToString(),
                        r["TENHP"].ToString(),
                        r["NGAY"].ToString());
                }
                c.Disconnect();
                return kqhp;
            }
        }
    }
}
