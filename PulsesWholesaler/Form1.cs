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
    }
}
