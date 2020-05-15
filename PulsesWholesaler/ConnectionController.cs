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
        private string connectionString = Properties.Settings.Default.ConnectionString;


        public void OpenConnection()
        {
            SqlConnection connection = new SqlConnection(connectionString);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
                MessageBox.Show("Connection successfully!");
            }

        }
    }
}
