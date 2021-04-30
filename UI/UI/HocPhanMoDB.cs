using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace UI
{
    public class HocPhanMoDB
    {
        public HocPhanMoDB() { }
        static public List<HocPhanMo> HIENTHI()
        {
            List<HocPhanMo> listSubject = new List<HocPhanMo>();
            Connect c = new Connect();
            SqlCommand cmd = new SqlCommand("HIENTHI", c.conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    HocPhanMo subject = new HocPhanMo();
                    subject.KHOITAO(reader["tenhp"].ToString(),
                    reader["tengv"].ToString(),
                    Int32.Parse(reader["tongsl"].ToString()),
                    (float)Convert.ToDouble(reader["giahocphan"].ToString()),
                    reader["namhoc"].ToString(),
                    Int32.Parse(reader["hocky"].ToString()),
                    Int32.Parse(reader["tiet"].ToString()),
                    reader["ngay"].ToString(),
                    reader["loaihp"].ToString(),
                    reader["mahp"].ToString(),
                    reader["MAHP_COBAN"].ToString(),
                    reader["TENHP_COBAN"].ToString());
 
                    listSubject.Add(subject);
                }
            }
            c.Disconnect();

            return listSubject;

        }
    }
}
