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
        PulseStocks pulseStocks;
        Sales sales;
        BindingSource binder = new BindingSource();

        public PulsesWholesaler()
        {
            InitializeComponent();
        }

        private void PulsesWholesaler_Load(object sender, EventArgs e)
        {
            this.fetchStocks();
            this.fetchSales();
        }

        private void clearCustomerInformationForm()
        {
            maskedTxtCustomerTcId.Text = null;
            txtCustomerFullName.Text = "";
            txtPulseQuantity.Text = null;
        }


        private void btnAddSales_Click(object sender, EventArgs e)
        {
            long customerTcId;
            string customerFullName;
            int pulseType;
            int pulseQuantity;

            try
            {
                if (maskedTxtCustomerTcId.Text.ToString().Length != 0)
                {
                    if (maskedTxtCustomerTcId.MaskCompleted)
                    {
                        customerTcId = Convert.ToInt64(maskedTxtCustomerTcId.Text);
                    }
                    else
                    {
                        throw new Exception("Invalid Customer T.C. ID");
                    }
                }
                else
                {
                    throw new Exception("You must enter customer T.C field.");
                }
                if (txtCustomerFullName.TextLength != 0)
                {
                    customerFullName = txtCustomerFullName.Text;
                }
                else
                {
                    throw new Exception("You must enter customer full name.");
                }
                if (comboPulseType.SelectedIndex > -1)
                {
                    pulseType = ((KeyValuePair<int, string>)comboPulseType.SelectedItem).Key;
                }
                else
                {
                    throw new Exception("You must select pulse type.");
                }
                if (txtPulseQuantity.Text.ToString().Length != 0)
                {
                    pulseQuantity = Convert.ToInt32(txtPulseQuantity.Text);

                    // checking selected pulse type whether or not has enough stocks.
                    if (!checkPulseStockAvailability(pulseType, pulseQuantity))
                    {
                        throw new Exception("Pulse stock is not enough for adding sales.");
                    }
                }
                else
                {
                    throw new Exception("You must enter pulse quantity.");
                }

                sales = new Sales();
                Boolean status = sales.create(customerTcId, customerFullName, pulseType, pulseQuantity);
                if (status)
                {
                    fetchSales();
                    clearCustomerInformationForm();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message.ToString(), "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private Boolean checkPulseStockAvailability(int pulseType, int pulseQuantity) {
            pulseStocks = new PulseStocks();
            return pulseStocks.checkStockAvailability(pulseType, pulseQuantity);
        }

        private void fetchSales()
        {
            try
            {
                sales = new Sales();
                binder.DataSource = sales.fetch();
                dgvSales.DataSource = binder;

            } catch (Exception error)
            {
                MessageBox.Show(error.Message.ToString(), "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fetchStocks()
        {
            try
            {
                grpStockStatus.Controls.Clear();

                // fetch Current Stocks
                pulseStocks = new PulseStocks();
                DataSet data_set = pulseStocks.fetch();


                int count = data_set.Tables[0].Rows.Count;

                // create dictionary to gather pulse stock item its inside and set comboBox source.
                Dictionary<int, string> comboSource = new Dictionary<int, string>();

                for (int i = 0; i < count; i++)
                {
                    DataRow table = data_set.Tables[0].Rows[i];

                    // If pulse stock is not enough for next sales, do not add to comboBox source.
                    if (Convert.ToInt32(table.ItemArray.GetValue(1).ToString()) != 0) {
                        comboSource.Add(Convert.ToInt32(table.ItemArray.GetValue(0).ToString()), table.ItemArray.GetValue(2).ToString());
                    }

                    ProgressBar progressBar = new ProgressBar();
                    Label label = new Label();
                    label.Text = table.ItemArray.GetValue(2).ToString() + ':';
                    label.Top = 30 + (i * 30);
                    label.Left = 10;
                    label.Width = 100;
                    progressBar.Top = 30 + (i * 30);
                    progressBar.Left = 120;
                    progressBar.Width = 200;
                    progressBar.Maximum = 1000;
                    progressBar.Value = Convert.ToInt32(table.ItemArray.GetValue(1).ToString());
                    grpStockStatus.Controls.Add(label);
                    grpStockStatus.Controls.Add(progressBar);
                }

                comboPulseType.DataSource = new BindingSource(comboSource, null);
                comboPulseType.DisplayMember = "Value";
                comboPulseType.ValueMember = "Key";

                // Create Reload Stock Button
                Button button = new Button();
                button.Top = 177;
                button.Left = 324;
                button.Text = "Reload";
                button.Name = "btnReload";
                grpStockStatus.Controls.Add(button);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message.ToString(), "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
