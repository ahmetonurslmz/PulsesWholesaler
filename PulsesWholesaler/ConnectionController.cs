using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace PulsesWholesaler
{
    class ConnectionController
    {
        private string _connectionString = Properties.Settings.Default.ConnectionString;
        SqlConnection connection;
        SqlDataAdapter sqlAdapter;

        public Object OpenConnection()
        {
            connection = new SqlConnection(_connectionString);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            return connection;
        }

        public DataSet GetData(string query, string table)
        {
            return retrieveObjects(query, table);
        }

        private DataSet retrieveObjects(string query, string table)
        {
            this.OpenConnection();

            sqlAdapter = new SqlDataAdapter(query, connection);
            DataSet data_set = new DataSet();
            sqlAdapter.Fill(data_set, table);
            connection.Close();
            return data_set;
        }
    }
}
