using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PulsesWholesaler
{
    public partial class PulsesWholesaler : Form
    {
        ConnectionController connection;

        public PulsesWholesaler()
        {
            InitializeComponent();
            connection = new ConnectionController();
            connection.OpenConnection();
        }

        private void PulsesWholesaler_Load(object sender, EventArgs e)
        {

        }

        private void btnAddSales_Click(object sender, EventArgs e)
        {
            int customerTcId = Convert.ToInt32(maskedTxtCustomerTcId.Text);
            string customerFullName = txtCustomerFullName.Text;
            int pulseType = Convert.ToInt32(comboPulsesType.SelectedItem.ToString());
            int pulseQuantity = Convert.ToInt32(txtPulseQuantity);
        }
    }
}
