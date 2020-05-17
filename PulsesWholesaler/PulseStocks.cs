using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PulsesWholesaler
{
    class PulseStocks
    {
        public DataSet fetch(SqlConnection con)
        {
            DataSet data_set = new DataSet();
            SqlCommand allPulseStocks = new SqlCommand("PfetchPulseStocks", con);
            SqlDataAdapter sqlDa = new SqlDataAdapter(allPulseStocks);
            sqlDa.Fill(data_set, "pulseStocksTable");
            return data_set;
        }

        public Boolean checkStockAvailability(SqlConnection con)
        {

        }
    }
}
