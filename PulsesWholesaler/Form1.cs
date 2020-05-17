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



        private void btnAddSales_Click(object sender, EventArgs e)
        {
            MessageBox.Show(((KeyValuePair<int, string>)comboPulseType.SelectedItem).Key.ToString(), "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void fetchSales()
        {
            try
            {
                using (SqlConnection con = connection.connect())
                {
                    if (con.State.ToString() == "Open")
                    {
                        SqlCommand allSalesCmd = new SqlCommand("PfetchSales", con);
                        SqlDataAdapter sqlDa = new SqlDataAdapter(allSalesCmd);
                        DataTable dt = new DataTable();
                        sqlDa.Fill(dt);
                        binder.DataSource = dt;
                        dgvSales.DataSource = binder;
                    }
                }
            } catch (Exception error)
            {
                MessageBox.Show(error.Message.ToString(), "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fetchStocks()
        {
            connection = new ConnectionController();

            try
            {
                using (SqlConnection con = connection.connect())
                {
                    if (con.State.ToString() == "Open")
                    {
                        grpStockStatus.Controls.Clear();


                        // fetch Current Stocks
                        DataSet data_set = new DataSet();
                        SqlCommand allPulseStocks = new SqlCommand("PfetchPulseStocks", con);
                        SqlDataAdapter sqlDa = new SqlDataAdapter(allPulseStocks);
                        sqlDa.Fill(data_set, "pulseStocksTable");


                        int count = data_set.Tables[0].Rows.Count;

                        // create dictionary to gather pulse stock item its inside and set comboBox source.
                        Dictionary<int, string> comboSource = new Dictionary<int, string>();

                        for (int i = 0; i < count; i++)
                        {
                            DataRow table = data_set.Tables[0].Rows[i];

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
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message.ToString(), "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
