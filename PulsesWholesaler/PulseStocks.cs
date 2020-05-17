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
    class PulseStocks
    {
        private SqlConnection con;
        ConnectionController connection;

        public PulseStocks()
        {
            connection = new ConnectionController();
            con = connection.connect();
        }

        public DataSet fetch()
        {
            DataSet data_set = new DataSet();
            SqlCommand allPulseStocks = new SqlCommand("PfetchPulseStocks", con);
            SqlDataAdapter sqlDa = new SqlDataAdapter(allPulseStocks);
            sqlDa.Fill(data_set, "pulseStocksTable");
            return data_set;
        }

        public Boolean checkStockAvailability(int pulseStockId, int pulseQuantity)
        {
            DataSet data_set = new DataSet();
            SqlCommand pulseStock = new SqlCommand("PcheckAvailabilityPulseStock", con);
            pulseStock.Parameters.AddWithValue("@GetPulseStockId", pulseStockId);
            pulseStock.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sqlDa = new SqlDataAdapter(pulseStock);
            sqlDa.Fill(data_set, "pulseStocksTable");
            DataRow dRow = data_set.Tables[0].Rows[0];

            if (pulseQuantity > Convert.ToInt32(dRow.ItemArray.GetValue(1).ToString()))
            {
                return false;
            }
            return true;
        }
    }
}
