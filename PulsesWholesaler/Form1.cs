using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PulsesWholesaler
{
    public partial class PulsesWholesaler : Form
    {
        ConnectionController connection;

        public PulsesWholesaler()
        {
            InitializeComponent();
        }

        public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        private void PulsesWholesaler_Load(object sender, EventArgs e)
        {
            connection = new ConnectionController();
            DataSet ds = connection.GetData("SELECT * FROM Stocks", "stocksTable");



            int count = ds.Tables[0].Rows.Count;

            for (int i = 0; i < count; i++)
            {
                DataRow table = ds.Tables[0].Rows[i];
                ComboboxItem item = new ComboboxItem();
                item.Value = table.ItemArray.GetValue(1).ToString();
                item.Text = table.ItemArray.GetValue(2).ToString();
                comboPulseType.Items.Add(item);
            }
        }

        private void btnAddSales_Click(object sender, EventArgs e)
        {
            // int customerTcId = Convert.ToInt32(maskedTxtCustomerTcId.Text);
            string customerFullName = txtCustomerFullName.Text;
            Console.WriteLine(comboPulseType.SelectedItem);
            string pulseType = comboPulseType.SelectedItem.ToString();
            int pulseQuantity = Convert.ToInt32(txtPulseQuantity.Text);
        }
    }
}
