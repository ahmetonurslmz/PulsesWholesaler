namespace PulsesWholesaler
{
    partial class PulsesWholesaler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpCustomerInformation = new System.Windows.Forms.GroupBox();
            this.txtPulseQuantity = new System.Windows.Forms.MaskedTextBox();
            this.maskedTxtCustomerTcId = new System.Windows.Forms.MaskedTextBox();
            this.btnAddSales = new System.Windows.Forms.Button();
            this.comboPulseType = new System.Windows.Forms.ComboBox();
            this.lblPulseQuantity = new System.Windows.Forms.Label();
            this.lblPulseType = new System.Windows.Forms.Label();
            this.txtCustomerFullName = new System.Windows.Forms.TextBox();
            this.lblCustomerFullName = new System.Windows.Forms.Label();
            this.lblCustomerTcId = new System.Windows.Forms.Label();
            this.grpStockStatus = new System.Windows.Forms.GroupBox();
            this.btnReload = new System.Windows.Forms.Button();
            this.grpSalesDetails = new System.Windows.Forms.GroupBox();
            this.dgvSales = new System.Windows.Forms.DataGridView();
            this.lblSalesCount = new System.Windows.Forms.Label();
            this.lblTotalSaleCount = new System.Windows.Forms.Label();
            this.grpCustomerInformation.SuspendLayout();
            this.grpStockStatus.SuspendLayout();
            this.grpSalesDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).BeginInit();
            this.SuspendLayout();
            // 
            // grpCustomerInformation
            // 
            this.grpCustomerInformation.Controls.Add(this.txtPulseQuantity);
            this.grpCustomerInformation.Controls.Add(this.maskedTxtCustomerTcId);
            this.grpCustomerInformation.Controls.Add(this.btnAddSales);
            this.grpCustomerInformation.Controls.Add(this.comboPulseType);
            this.grpCustomerInformation.Controls.Add(this.lblPulseQuantity);
            this.grpCustomerInformation.Controls.Add(this.lblPulseType);
            this.grpCustomerInformation.Controls.Add(this.txtCustomerFullName);
            this.grpCustomerInformation.Controls.Add(this.lblCustomerFullName);
            this.grpCustomerInformation.Controls.Add(this.lblCustomerTcId);
            this.grpCustomerInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpCustomerInformation.Location = new System.Drawing.Point(12, 12);
            this.grpCustomerInformation.Name = "grpCustomerInformation";
            this.grpCustomerInformation.Size = new System.Drawing.Size(405, 208);
            this.grpCustomerInformation.TabIndex = 0;
            this.grpCustomerInformation.TabStop = false;
            this.grpCustomerInformation.Text = "Customer Information";
            // 
            // txtPulseQuantity
            // 
            this.txtPulseQuantity.Location = new System.Drawing.Point(169, 145);
            this.txtPulseQuantity.Mask = "0000";
            this.txtPulseQuantity.Name = "txtPulseQuantity";
            this.txtPulseQuantity.Size = new System.Drawing.Size(119, 24);
            this.txtPulseQuantity.TabIndex = 11;
            this.txtPulseQuantity.ValidatingType = typeof(int);
            // 
            // maskedTxtCustomerTcId
            // 
            this.maskedTxtCustomerTcId.CausesValidation = false;
            this.maskedTxtCustomerTcId.Location = new System.Drawing.Point(169, 40);
            this.maskedTxtCustomerTcId.Mask = "00000000000";
            this.maskedTxtCustomerTcId.Name = "maskedTxtCustomerTcId";
            this.maskedTxtCustomerTcId.Size = new System.Drawing.Size(119, 24);
            this.maskedTxtCustomerTcId.TabIndex = 10;
            // 
            // btnAddSales
            // 
            this.btnAddSales.Location = new System.Drawing.Point(315, 173);
            this.btnAddSales.Name = "btnAddSales";
            this.btnAddSales.Size = new System.Drawing.Size(84, 29);
            this.btnAddSales.TabIndex = 9;
            this.btnAddSales.Text = "Add Sales";
            this.btnAddSales.UseVisualStyleBackColor = true;
            this.btnAddSales.Click += new System.EventHandler(this.btnAddSales_Click);
            // 
            // comboPulseType
            // 
            this.comboPulseType.FormattingEnabled = true;
            this.comboPulseType.Location = new System.Drawing.Point(169, 107);
            this.comboPulseType.Name = "comboPulseType";
            this.comboPulseType.Size = new System.Drawing.Size(119, 26);
            this.comboPulseType.TabIndex = 8;
            // 
            // lblPulseQuantity
            // 
            this.lblPulseQuantity.AutoSize = true;
            this.lblPulseQuantity.Location = new System.Drawing.Point(48, 148);
            this.lblPulseQuantity.Name = "lblPulseQuantity";
            this.lblPulseQuantity.Size = new System.Drawing.Size(113, 18);
            this.lblPulseQuantity.TabIndex = 6;
            this.lblPulseQuantity.Text = "Pulse Quantity*:";
            // 
            // lblPulseType
            // 
            this.lblPulseType.AutoSize = true;
            this.lblPulseType.Location = new System.Drawing.Point(70, 112);
            this.lblPulseType.Name = "lblPulseType";
            this.lblPulseType.Size = new System.Drawing.Size(91, 18);
            this.lblPulseType.TabIndex = 4;
            this.lblPulseType.Text = "Pulse Type*:";
            // 
            // txtCustomerFullName
            // 
            this.txtCustomerFullName.Location = new System.Drawing.Point(169, 76);
            this.txtCustomerFullName.Name = "txtCustomerFullName";
            this.txtCustomerFullName.Size = new System.Drawing.Size(119, 24);
            this.txtCustomerFullName.TabIndex = 3;
            // 
            // lblCustomerFullName
            // 
            this.lblCustomerFullName.AutoSize = true;
            this.lblCustomerFullName.Location = new System.Drawing.Point(14, 76);
            this.lblCustomerFullName.Name = "lblCustomerFullName";
            this.lblCustomerFullName.Size = new System.Drawing.Size(155, 18);
            this.lblCustomerFullName.TabIndex = 2;
            this.lblCustomerFullName.Text = "Customer Full Name*:";
            // 
            // lblCustomerTcId
            // 
            this.lblCustomerTcId.AutoSize = true;
            this.lblCustomerTcId.Location = new System.Drawing.Point(35, 46);
            this.lblCustomerTcId.Name = "lblCustomerTcId";
            this.lblCustomerTcId.Size = new System.Drawing.Size(134, 18);
            this.lblCustomerTcId.TabIndex = 0;
            this.lblCustomerTcId.Text = "Customer T.C. ID*:";
            // 
            // grpStockStatus
            // 
            this.grpStockStatus.Controls.Add(this.btnReload);
            this.grpStockStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpStockStatus.Location = new System.Drawing.Point(432, 12);
            this.grpStockStatus.Name = "grpStockStatus";
            this.grpStockStatus.Size = new System.Drawing.Size(405, 208);
            this.grpStockStatus.TabIndex = 1;
            this.grpStockStatus.TabStop = false;
            this.grpStockStatus.Text = "Stock Status";
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(324, 174);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(75, 28);
            this.btnReload.TabIndex = 0;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            // 
            // grpSalesDetails
            // 
            this.grpSalesDetails.Controls.Add(this.dgvSales);
            this.grpSalesDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpSalesDetails.Location = new System.Drawing.Point(12, 230);
            this.grpSalesDetails.Name = "grpSalesDetails";
            this.grpSalesDetails.Size = new System.Drawing.Size(825, 195);
            this.grpSalesDetails.TabIndex = 2;
            this.grpSalesDetails.TabStop = false;
            this.grpSalesDetails.Text = "Sales Details";
            // 
            // dgvSales
            // 
            this.dgvSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSales.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvSales.Location = new System.Drawing.Point(3, 20);
            this.dgvSales.Name = "dgvSales";
            this.dgvSales.ReadOnly = true;
            this.dgvSales.Size = new System.Drawing.Size(816, 169);
            this.dgvSales.TabIndex = 0;
            // 
            // lblSalesCount
            // 
            this.lblSalesCount.AutoSize = true;
            this.lblSalesCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSalesCount.Location = new System.Drawing.Point(818, 428);
            this.lblSalesCount.Name = "lblSalesCount";
            this.lblSalesCount.Size = new System.Drawing.Size(15, 15);
            this.lblSalesCount.TabIndex = 3;
            this.lblSalesCount.Text = "0";
            this.lblSalesCount.Visible = false;
            // 
            // lblTotalSaleCount
            // 
            this.lblTotalSaleCount.AutoSize = true;
            this.lblTotalSaleCount.Location = new System.Drawing.Point(726, 430);
            this.lblTotalSaleCount.Name = "lblTotalSaleCount";
            this.lblTotalSaleCount.Size = new System.Drawing.Size(86, 13);
            this.lblTotalSaleCount.TabIndex = 4;
            this.lblTotalSaleCount.Text = "Total Sale Count";
            // 
            // PulsesWholesaler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 450);
            this.Controls.Add(this.lblTotalSaleCount);
            this.Controls.Add(this.lblSalesCount);
            this.Controls.Add(this.grpSalesDetails);
            this.Controls.Add(this.grpStockStatus);
            this.Controls.Add(this.grpCustomerInformation);
            this.Name = "PulsesWholesaler";
            this.Text = "Pulses Wholesaler";
            this.Load += new System.EventHandler(this.PulsesWholesaler_Load);
            this.grpCustomerInformation.ResumeLayout(false);
            this.grpCustomerInformation.PerformLayout();
            this.grpStockStatus.ResumeLayout(false);
            this.grpSalesDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCustomerInformation;
        private System.Windows.Forms.GroupBox grpStockStatus;
        private System.Windows.Forms.GroupBox grpSalesDetails;
        private System.Windows.Forms.Button btnAddSales;
        private System.Windows.Forms.ComboBox comboPulseType;
        private System.Windows.Forms.Label lblPulseQuantity;
        private System.Windows.Forms.Label lblPulseType;
        private System.Windows.Forms.TextBox txtCustomerFullName;
        private System.Windows.Forms.Label lblCustomerFullName;
        private System.Windows.Forms.Label lblCustomerTcId;
        private System.Windows.Forms.MaskedTextBox maskedTxtCustomerTcId;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.MaskedTextBox txtPulseQuantity;
        private System.Windows.Forms.DataGridView dgvSales;
        private System.Windows.Forms.Label lblSalesCount;
        private System.Windows.Forms.Label lblTotalSaleCount;
    }
}

