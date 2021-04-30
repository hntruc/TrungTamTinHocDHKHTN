﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace UI
{
    public class HocVienDB
    {
        static public int THEMHOCVIEN(string cmnd, string tenHV, string diachi, string sdt, string email)
        {
                Connect c = new Connect();
                SqlCommand cmd = new SqlCommand("THEMHOCVIEN", c.conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@cmnd", cmnd));
                cmd.Parameters.Add(new SqlParameter("@tenhv", tenHV));
                cmd.Parameters.Add(new SqlParameter("@diachi", diachi));
                cmd.Parameters.Add(new SqlParameter("@sdt", sdt));
                cmd.Parameters.Add(new SqlParameter("@email", email));
                int rowAffected = cmd.ExecuteNonQuery();
                c.Disconnect();
                if (rowAffected != 0)
                {
                    return 1;
                }
                else
                    return 0;
        }
        static public string LayMaHocVien(string cmnd)
        {
            string res_mahv;
            Connect c = new Connect();
            SqlCommand cmd = new SqlCommand("LAYMAHOCVIEN", c.conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@cmnd", cmnd));

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    res_mahv = reader["MAHV"].ToString();
                }
                else
                    res_mahv = "";
            }
            c.Disconnect();
            return res_mahv;
        }
    }
}
