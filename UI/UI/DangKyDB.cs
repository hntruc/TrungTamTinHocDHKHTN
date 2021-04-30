using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace UI
{
    public class DangKyDB
    {
        static public Connect c = new Connect();
        public static void XOAHOCPHAN(string mahp, string namhoc, int hocky, string mahv)
        {
                SqlCommand sqlCmd = new SqlCommand("XOAHOCPHAN", c.conn);
                sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@MAHP", mahp);
                sqlCmd.Parameters.AddWithValue("@NAMHOC", namhoc);
                sqlCmd.Parameters.AddWithValue("@HOCKY", hocky);
                sqlCmd.Parameters.AddWithValue("@MAHV", mahv);
                sqlCmd.ExecuteNonQuery();
        }

        public static int THEMHOCPHAN(DangKy dk)
        {
            try
            {
                SqlCommand sqlCmd = new SqlCommand("THEMHOCPHAN", c.conn);
                sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@MAHP", dk.mahp);
                sqlCmd.Parameters.AddWithValue("@NAMHOC", dk.namhoc);
                sqlCmd.Parameters.AddWithValue("@HOCKY", dk.hocky);
                sqlCmd.Parameters.AddWithValue("@MAHV", dk.mahv);
                sqlCmd.Parameters.AddWithValue("@MANV", dk.manv);
                sqlCmd.Parameters.AddWithValue("@NGAY", dk.ngay);
                sqlCmd.ExecuteNonQuery();
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public static int THEMHOCPHANHVM(DangKy dk)
        {
            try
            {
                SqlCommand sqlCmd = new SqlCommand("THEMHOCPHANHVM", c.conn);
                sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@MAHP", dk.mahp);
                sqlCmd.Parameters.AddWithValue("@NAMHOC", dk.namhoc);
                sqlCmd.Parameters.AddWithValue("@HOCKY", dk.hocky);
                sqlCmd.Parameters.AddWithValue("@MAHV", dk.mahv);
                sqlCmd.Parameters.AddWithValue("@MANV", dk.manv);
                sqlCmd.Parameters.AddWithValue("@NGAY", dk.ngay);
                sqlCmd.ExecuteNonQuery();
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public static int KIEMTRAHOCPHANCOBAN(string mahp, string mahv)
        {
            try
            {
                SqlCommand sqlCmd = new SqlCommand("KIEMTRAHOCPHANCOBAN", c.conn);
                sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@MAHP", mahp);
                sqlCmd.Parameters.AddWithValue("@MAHV", mahv);
                var check = sqlCmd.Parameters.Add("@RES", System.Data.SqlDbType.Int);
                check.Direction = System.Data.ParameterDirection.ReturnValue;
                
                sqlCmd.ExecuteNonQuery();

                return Int32.Parse(check.Value.ToString());
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
    }
}
