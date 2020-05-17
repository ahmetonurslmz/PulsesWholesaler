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
            DataTable data_table = new DataTable();
            sqlDa.Fill(data_table);
            return data_table;
        }

        public Boolean create(long customerTcId, string customerFullName, int pulseTypeId, int pulseQuantity)
        {
            SqlCommand cmd = new SqlCommand("PcreateSale", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CustomerTcId", customerTcId);
            cmd.Parameters.AddWithValue("@CustomerFullName", customerFullName);
            cmd.Parameters.AddWithValue("@PulseTypeId", pulseTypeId);
            cmd.Parameters.AddWithValue("@PulseQuantity", pulseQuantity);


            SqlDataAdapter sqlDa = new SqlDataAdapter(cmd);
            DataSet data_set = new DataSet();
            sqlDa.Fill(data_set);

            return true;
        }
    }
}
