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
            this.fetchStocks();
        }

        private void btnAddSales_Click(object sender, EventArgs e)
        {
            long customerTcId;
            string customerFullName;
            try
            {
                if (maskedTxtCustomerTcId.Text.ToString().Length != 0)
                {
                    if (maskedTxtCustomerTcId.MaskCompleted)
                    {
                        customerTcId = Convert.ToInt64(maskedTxtCustomerTcId.Text);
                    } else
                    {
                        throw new Exception("Invalid Customer T.C. ID");
                    }
                } else
                {
                    throw new ArgumentNullException("Customer T.C. ID");
                }
                if (txtCustomerFullName.TextLength != 0)
                {
                    customerFullName = txtCustomerFullName.Text;
                } else
                {
                    throw new ArgumentNullException("Customer Full Name");
                }
                if (comboPulseType.SelectedIndex > -1)
                {
                    string pulseType = comboPulseType.SelectedItem.ToString();
                } else
                {
                    throw new ArgumentNullException("Pulse Type");
                }
                if (txtPulseQuantity.Text.ToString().Length != 0)
                {
                    int pulseQuantity = Convert.ToInt32(txtPulseQuantity.Text);
                } else
                {
                    throw new ArgumentNullException("Pulse Quantity");
                }
            } catch (Exception error)
            {
                MessageBox.Show(error.Message.ToString(), "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void fetchStocks()
        {
            connection = new ConnectionController();
            DataSet ds = connection.GetData("SELECT * FROM Stocks", "stocksTable");


            grpStockStatus.Controls.Clear();

            int count = ds.Tables[0].Rows.Count;

            for (int i = 0; i < count; i++)
            {
                DataRow table = ds.Tables[0].Rows[i];
                ComboboxItem item = new ComboboxItem();
                item.Value = table.ItemArray.GetValue(1).ToString();
                item.Text = table.ItemArray.GetValue(2).ToString();
                comboPulseType.Items.Add(item);

                ProgressBar bar = new ProgressBar();
                Label label = new Label();
                label.Text = table.ItemArray.GetValue(2).ToString() + ':';
                label.Top = 30 + (i * 30);
                label.Left = 10;
                label.Width = 100;
                bar.Top = 30 + (i * 30);
                bar.Left = 120;
                bar.Width = 200;
                bar.Value = Convert.ToInt32(table.ItemArray.GetValue(1).ToString());
                grpStockStatus.Controls.Add(label);
                grpStockStatus.Controls.Add(bar);
            }

            // Create Reload Stock Button
            Button button = new Button();
            button.Top = 177;
            button.Left = 324;
            button.Text = "Reload";
            button.Name = "btnReload";
            grpStockStatus.Controls.Add(button);
        }
    }
}
