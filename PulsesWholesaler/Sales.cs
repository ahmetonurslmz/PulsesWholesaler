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
    class Sales
    {
        private SqlConnection con;
        ConnectionController connection;

        public Sales()
        {
            connection = new ConnectionController();
            con = connection.connect();
        }

        public DataTable fetch()
        {
            SqlCommand allSalesCmd = new SqlCommand("PfetchSales", con);
            SqlDataAdapter sqlDa = new SqlDataAdapter(allSalesCmd);
            DataTable data_set = new DataTable();
            sqlDa.Fill(data_set);
            return data_set;
        }
    }
}
