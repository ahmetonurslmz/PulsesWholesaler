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

        private DataSet get(int pulseStockId)
        {
            DataSet data_set = new DataSet();
            SqlCommand pulseStock = new SqlCommand("PcheckAvailabilityPulseStock", con);
            pulseStock.Parameters.AddWithValue("@GetPulseStockId", pulseStockId);
            pulseStock.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sqlDa = new SqlDataAdapter(pulseStock);
            sqlDa.Fill(data_set, "pulseStocksTable");
            return data_set;
        }

        public Boolean checkStockAvailability(int pulseStockId, int pulseQuantity)
        {
            DataSet data_set = get(pulseStockId);
            DataRow dRow = data_set.Tables[0].Rows[0];

            if (pulseQuantity > Convert.ToInt32(dRow.ItemArray.GetValue(1).ToString()))
            {
                return false;
            }
            return true;
        }


        private Boolean updatePulseStock(int pulseStockId, int newPulseStockSize)
        {
            SqlCommand cmd = new SqlCommand("PupdatePulseStock", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PulseStockId", pulseStockId);
            cmd.Parameters.AddWithValue("@NewPulseStockSize", newPulseStockSize);


            SqlDataAdapter sqlDa = new SqlDataAdapter(cmd);
            DataSet cmd_data_set = new DataSet();
            sqlDa.Fill(cmd_data_set);

            return true;
        }

        public Boolean decreaseStockSize(int pulseStockId, int pulseQuantity)
        {
            DataSet data_set = get(pulseStockId);
            DataRow dRow = data_set.Tables[0].Rows[0];

            int newPulseStockSize = Convert.ToInt32(dRow.ItemArray.GetValue(1).ToString()) - pulseQuantity;

            return updatePulseStock(pulseStockId, newPulseStockSize);
        }

        public Boolean fillAllPulseStocks()
        {
            DataSet data_set = fetch();
            int pulseCount = data_set.Tables[0].Rows.Count;
            for (int i = 0; i < pulseCount; i++)
            {
                DataRow table = data_set.Tables[0].Rows[i];
                updatePulseStock(Convert.ToInt32(table.ItemArray.GetValue(0).ToString()), 1000);
            }
            return true;
        }
    }
}
