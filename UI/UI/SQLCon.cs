using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace UI
{
    public class Connect
    {
        public SqlConnection conn = new SqlConnection();
        public Connect()
        {
            this.conn.ConnectionString = @"Data Source=DESKTOP-LATGDUJ;Initial Catalog=TTTH;Integrated Security=True";
            if (this.conn.State == ConnectionState.Closed)
                this.conn.Open();
        }
        public void Disconnect()
        {
            this.conn.Close();
        }
    }
}
