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
            this.groupBoxCustomerInformation = new System.Windows.Forms.GroupBox();
            this.groupBoxStockStatus = new System.Windows.Forms.GroupBox();
            this.groupBoxSalesDetails = new System.Windows.Forms.GroupBox();
            this.lblCustomerTcId = new System.Windows.Forms.Label();
            this.txtCustomerFullName = new System.Windows.Forms.TextBox();
            this.lblCustomerFullName = new System.Windows.Forms.Label();
            this.lblPulseType = new System.Windows.Forms.Label();
            this.txtPulseQuantity = new System.Windows.Forms.TextBox();
            this.lblPulseQuantity = new System.Windows.Forms.Label();
            this.comboPulseType = new System.Windows.Forms.ComboBox();
            this.btnAddSales = new System.Windows.Forms.Button();
            this.maskedTxtCustomerTcId = new System.Windows.Forms.MaskedTextBox();
            this.groupBoxCustomerInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCustomerInformation
            // 
            this.groupBoxCustomerInformation.Controls.Add(this.maskedTxtCustomerTcId);
            this.groupBoxCustomerInformation.Controls.Add(this.btnAddSales);
            this.groupBoxCustomerInformation.Controls.Add(this.comboPulseType);
            this.groupBoxCustomerInformation.Controls.Add(this.txtPulseQuantity);
            this.groupBoxCustomerInformation.Controls.Add(this.lblPulseQuantity);
            this.groupBoxCustomerInformation.Controls.Add(this.lblPulseType);
            this.groupBoxCustomerInformation.Controls.Add(this.txtCustomerFullName);
            this.groupBoxCustomerInformation.Controls.Add(this.lblCustomerFullName);
            this.groupBoxCustomerInformation.Controls.Add(this.lblCustomerTcId);
            this.groupBoxCustomerInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxCustomerInformation.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCustomerInformation.Name = "groupBoxCustomerInformation";
            this.groupBoxCustomerInformation.Size = new System.Drawing.Size(405, 208);
            this.groupBoxCustomerInformation.TabIndex = 0;
            this.groupBoxCustomerInformation.TabStop = false;
            this.groupBoxCustomerInformation.Text = "Customer Information";
            // 
            // groupBoxStockStatus
            // 
            this.groupBoxStockStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxStockStatus.Location = new System.Drawing.Point(432, 12);
            this.groupBoxStockStatus.Name = "groupBoxStockStatus";
            this.groupBoxStockStatus.Size = new System.Drawing.Size(405, 208);
            this.groupBoxStockStatus.TabIndex = 1;
            this.groupBoxStockStatus.TabStop = false;
            this.groupBoxStockStatus.Text = "Stock Status";
            // 
            // groupBoxSalesDetails
            // 
            this.groupBoxSalesDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxSalesDetails.Location = new System.Drawing.Point(12, 230);
            this.groupBoxSalesDetails.Name = "groupBoxSalesDetails";
            this.groupBoxSalesDetails.Size = new System.Drawing.Size(825, 208);
            this.groupBoxSalesDetails.TabIndex = 2;
            this.groupBoxSalesDetails.TabStop = false;
            this.groupBoxSalesDetails.Text = "Sales Details";
            // 
            // lblCustomerTcId
            // 
            this.lblCustomerTcId.AutoSize = true;
            this.lblCustomerTcId.Location = new System.Drawing.Point(35, 46);
            this.lblCustomerTcId.Name = "lblCustomerTcId";
            this.lblCustomerTcId.Size = new System.Drawing.Size(128, 18);
            this.lblCustomerTcId.TabIndex = 0;
            this.lblCustomerTcId.Text = "Customer T.C. ID:";
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
            this.lblCustomerFullName.Size = new System.Drawing.Size(149, 18);
            this.lblCustomerFullName.TabIndex = 2;
            this.lblCustomerFullName.Text = "Customer Full Name:";
            // 
            // lblPulseType
            // 
            this.lblPulseType.AutoSize = true;
            this.lblPulseType.Location = new System.Drawing.Point(70, 112);
            this.lblPulseType.Name = "lblPulseType";
            this.lblPulseType.Size = new System.Drawing.Size(85, 18);
            this.lblPulseType.TabIndex = 4;
            this.lblPulseType.Text = "Pulse Type:";
            // 
            // txtPulseQuantity
            // 
            this.txtPulseQuantity.Location = new System.Drawing.Point(169, 139);
            this.txtPulseQuantity.Name = "txtPulseQuantity";
            this.txtPulseQuantity.Size = new System.Drawing.Size(119, 24);
            this.txtPulseQuantity.TabIndex = 7;
            // 
            // lblPulseQuantity
            // 
            this.lblPulseQuantity.AutoSize = true;
            this.lblPulseQuantity.Location = new System.Drawing.Point(48, 142);
            this.lblPulseQuantity.Name = "lblPulseQuantity";
            this.lblPulseQuantity.Size = new System.Drawing.Size(107, 18);
            this.lblPulseQuantity.TabIndex = 6;
            this.lblPulseQuantity.Text = "Pulse Quantity:";
            // 
            // comboPulseType
            // 
            this.comboPulseType.FormattingEnabled = true;
            this.comboPulseType.Location = new System.Drawing.Point(169, 107);
            this.comboPulseType.Name = "comboPulseType";
            this.comboPulseType.Size = new System.Drawing.Size(119, 26);
            this.comboPulseType.TabIndex = 8;
            // 
            // btnAddSales
            // 
            this.btnAddSales.Location = new System.Drawing.Point(294, 137);
            this.btnAddSales.Name = "btnAddSales";
            this.btnAddSales.Size = new System.Drawing.Size(84, 29);
            this.btnAddSales.TabIndex = 9;
            this.btnAddSales.Text = "Add Sales";
            this.btnAddSales.UseVisualStyleBackColor = true;
            this.btnAddSales.Click += new System.EventHandler(this.btnAddSales_Click);
            // 
            // maskedTxtCustomerTcId
            // 
            this.maskedTxtCustomerTcId.CausesValidation = false;
            this.maskedTxtCustomerTcId.Location = new System.Drawing.Point(169, 40);
            this.maskedTxtCustomerTcId.Mask = "00000000000";
            this.maskedTxtCustomerTcId.Name = "maskedTxtCustomerTcId";
            this.maskedTxtCustomerTcId.Size = new System.Drawing.Size(119, 24);
            this.maskedTxtCustomerTcId.TabIndex = 10;
            this.maskedTxtCustomerTcId.ValidatingType = typeof(int);
            // 
            // PulsesWholesaler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 450);
            this.Controls.Add(this.groupBoxSalesDetails);
            this.Controls.Add(this.groupBoxStockStatus);
            this.Controls.Add(this.groupBoxCustomerInformation);
            this.Name = "PulsesWholesaler";
            this.Text = "Pulses Wholesaler";
            this.Load += new System.EventHandler(this.PulsesWholesaler_Load);
            this.groupBoxCustomerInformation.ResumeLayout(false);
            this.groupBoxCustomerInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCustomerInformation;
        private System.Windows.Forms.GroupBox groupBoxStockStatus;
        private System.Windows.Forms.GroupBox groupBoxSalesDetails;
        private System.Windows.Forms.Button btnAddSales;
        private System.Windows.Forms.ComboBox comboPulseType;
        private System.Windows.Forms.TextBox txtPulseQuantity;
        private System.Windows.Forms.Label lblPulseQuantity;
        private System.Windows.Forms.Label lblPulseType;
        private System.Windows.Forms.TextBox txtCustomerFullName;
        private System.Windows.Forms.Label lblCustomerFullName;
        private System.Windows.Forms.Label lblCustomerTcId;
        private System.Windows.Forms.MaskedTextBox maskedTxtCustomerTcId;
    }
}

