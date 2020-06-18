namespace ADSAssignment
{
    partial class tradePartnersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tradePartnersForm));
            this.countryDataGridView = new System.Windows.Forms.DataGridView();
            this.tradePartnersLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.countryDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // countryDataGridView
            // 
            this.countryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.countryDataGridView.Location = new System.Drawing.Point(12, 28);
            this.countryDataGridView.Name = "countryDataGridView";
            this.countryDataGridView.RowTemplate.Height = 33;
            this.countryDataGridView.Size = new System.Drawing.Size(785, 374);
            this.countryDataGridView.TabIndex = 0;
            // 
            // tradePartnersLabel
            // 
            this.tradePartnersLabel.AutoSize = true;
            this.tradePartnersLabel.Location = new System.Drawing.Point(13, 423);
            this.tradePartnersLabel.Name = "tradePartnersLabel";
            this.tradePartnersLabel.Size = new System.Drawing.Size(279, 25);
            this.tradePartnersLabel.TabIndex = 1;
            this.tradePartnersLabel.Text = "Showing Trade Partners of: ";
            // 
            // tradePartnersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(809, 460);
            this.Controls.Add(this.tradePartnersLabel);
            this.Controls.Add(this.countryDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "tradePartnersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trade Partners";
            this.Load += new System.EventHandler(this.tradePartners_Load);
            ((System.ComponentModel.ISupportInitialize)(this.countryDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView countryDataGridView;
        private System.Windows.Forms.Label tradePartnersLabel;
    }
}