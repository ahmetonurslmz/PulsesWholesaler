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
            this.SuspendLayout();
            // 
            // groupBoxCustomerInformation
            // 
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCustomerInformation;
        private System.Windows.Forms.GroupBox groupBoxStockStatus;
        private System.Windows.Forms.GroupBox groupBoxSalesDetails;
    }
}

