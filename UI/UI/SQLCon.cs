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

    public class DataProvider
    {
        private string connectionStr = @"Data Source=DALASTA\SQLEXPRESS;Initial Catalog = TTTH; Integrated Security = True";

        public DataTable ExecuteQuery(string query)
        {
            SqlConnection connection = new SqlConnection(connectionStr);

            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            connection.Close();

            return data;
        }

        public DataTable ExecuteProc(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listparameter = query.Split(' ');
                    int i = 0;
                    foreach (string item in listparameter)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(data);

                connection.Close();
            }

            return data;
        }

        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;

            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listparameter = query.Split(' ');
                    int i = 0;
                    foreach (string item in listparameter)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteScalar();
                connection.Close();
            }

            return data;
        }
    }

}
