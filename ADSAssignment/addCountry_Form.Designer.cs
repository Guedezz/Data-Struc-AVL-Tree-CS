namespace ADSAssignment
{
    partial class addCountry_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addCountry_Form));
            this.addTradePartnerTextBox = new System.Windows.Forms.TextBox();
            this.addPartnerButton = new System.Windows.Forms.Button();
            this.removePartnerButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.createCountryButton = new System.Windows.Forms.Button();
            this.tradePartnersLabel = new System.Windows.Forms.Label();
            this.hdiRankingLabel = new System.Windows.Forms.Label();
            this.tradeBalanceLabel = new System.Windows.Forms.Label();
            this.InflationLabel = new System.Windows.Forms.Label();
            this.GDPGrowthLabel = new System.Windows.Forms.Label();
            this.countryLabel = new System.Windows.Forms.Label();
            this.tradePartnersListBox = new System.Windows.Forms.ListBox();
            this.hdiRankingTextBox = new System.Windows.Forms.TextBox();
            this.tradeBalanceTextBox = new System.Windows.Forms.TextBox();
            this.inflationTextBox = new System.Windows.Forms.TextBox();
            this.gdpGrowthTextBox = new System.Windows.Forms.TextBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addTradePartnerTextBox
            // 
            this.addTradePartnerTextBox.Location = new System.Drawing.Point(662, 144);
            this.addTradePartnerTextBox.Name = "addTradePartnerTextBox";
            this.addTradePartnerTextBox.Size = new System.Drawing.Size(124, 31);
            this.addTradePartnerTextBox.TabIndex = 35;
            // 
            // addPartnerButton
            // 
            this.addPartnerButton.ForeColor = System.Drawing.Color.Black;
            this.addPartnerButton.Location = new System.Drawing.Point(662, 96);
            this.addPartnerButton.Name = "addPartnerButton";
            this.addPartnerButton.Size = new System.Drawing.Size(125, 42);
            this.addPartnerButton.TabIndex = 34;
            this.addPartnerButton.Text = "+";
            this.addPartnerButton.UseVisualStyleBackColor = true;
            this.addPartnerButton.Click += new System.EventHandler(this.addPartnerButton_Click);
            // 
            // removePartnerButton
            // 
            this.removePartnerButton.ForeColor = System.Drawing.Color.Black;
            this.removePartnerButton.Location = new System.Drawing.Point(662, 46);
            this.removePartnerButton.Name = "removePartnerButton";
            this.removePartnerButton.Size = new System.Drawing.Size(124, 44);
            this.removePartnerButton.TabIndex = 33;
            this.removePartnerButton.Text = "−";
            this.removePartnerButton.UseVisualStyleBackColor = true;
            this.removePartnerButton.Click += new System.EventHandler(this.removePartnerButton_Click_1);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.cancelButton.Location = new System.Drawing.Point(381, 233);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(405, 44);
            this.cancelButton.TabIndex = 32;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // createCountryButton
            // 
            this.createCountryButton.Enabled = false;
            this.createCountryButton.Location = new System.Drawing.Point(381, 189);
            this.createCountryButton.Name = "createCountryButton";
            this.createCountryButton.Size = new System.Drawing.Size(405, 41);
            this.createCountryButton.TabIndex = 31;
            this.createCountryButton.Text = "Create country";
            this.createCountryButton.UseVisualStyleBackColor = true;
            this.createCountryButton.Click += new System.EventHandler(this.createCountryButton_Click_1);
            // 
            // tradePartnersLabel
            // 
            this.tradePartnersLabel.AutoSize = true;
            this.tradePartnersLabel.Location = new System.Drawing.Point(376, 18);
            this.tradePartnersLabel.Name = "tradePartnersLabel";
            this.tradePartnersLabel.Size = new System.Drawing.Size(214, 25);
            this.tradePartnersLabel.TabIndex = 30;
            this.tradePartnersLabel.Text = "Main Trade Partners:";
            // 
            // hdiRankingLabel
            // 
            this.hdiRankingLabel.AutoSize = true;
            this.hdiRankingLabel.Location = new System.Drawing.Point(10, 239);
            this.hdiRankingLabel.Name = "hdiRankingLabel";
            this.hdiRankingLabel.Size = new System.Drawing.Size(138, 25);
            this.hdiRankingLabel.TabIndex = 29;
            this.hdiRankingLabel.Text = "HDI Ranking:";
            // 
            // tradeBalanceLabel
            // 
            this.tradeBalanceLabel.AutoSize = true;
            this.tradeBalanceLabel.Location = new System.Drawing.Point(10, 185);
            this.tradeBalanceLabel.Name = "tradeBalanceLabel";
            this.tradeBalanceLabel.Size = new System.Drawing.Size(158, 25);
            this.tradeBalanceLabel.TabIndex = 28;
            this.tradeBalanceLabel.Text = "Trade Balance:";
            // 
            // InflationLabel
            // 
            this.InflationLabel.AutoSize = true;
            this.InflationLabel.Location = new System.Drawing.Point(10, 130);
            this.InflationLabel.Name = "InflationLabel";
            this.InflationLabel.Size = new System.Drawing.Size(93, 25);
            this.InflationLabel.TabIndex = 27;
            this.InflationLabel.Text = "Inflation:";
            // 
            // GDPGrowthLabel
            // 
            this.GDPGrowthLabel.AutoSize = true;
            this.GDPGrowthLabel.Location = new System.Drawing.Point(10, 75);
            this.GDPGrowthLabel.Name = "GDPGrowthLabel";
            this.GDPGrowthLabel.Size = new System.Drawing.Size(131, 25);
            this.GDPGrowthLabel.TabIndex = 26;
            this.GDPGrowthLabel.Text = "GDPGrowth:";
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Location = new System.Drawing.Point(10, 20);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(93, 25);
            this.countryLabel.TabIndex = 25;
            this.countryLabel.Text = "Country:";
            // 
            // tradePartnersListBox
            // 
            this.tradePartnersListBox.FormattingEnabled = true;
            this.tradePartnersListBox.ItemHeight = 25;
            this.tradePartnersListBox.Location = new System.Drawing.Point(381, 46);
            this.tradePartnersListBox.Name = "tradePartnersListBox";
            this.tradePartnersListBox.Size = new System.Drawing.Size(264, 129);
            this.tradePartnersListBox.TabIndex = 24;
            // 
            // hdiRankingTextBox
            // 
            this.hdiRankingTextBox.Location = new System.Drawing.Point(179, 233);
            this.hdiRankingTextBox.Name = "hdiRankingTextBox";
            this.hdiRankingTextBox.Size = new System.Drawing.Size(148, 31);
            this.hdiRankingTextBox.TabIndex = 23;
            // 
            // tradeBalanceTextBox
            // 
            this.tradeBalanceTextBox.Location = new System.Drawing.Point(179, 179);
            this.tradeBalanceTextBox.Name = "tradeBalanceTextBox";
            this.tradeBalanceTextBox.Size = new System.Drawing.Size(148, 31);
            this.tradeBalanceTextBox.TabIndex = 22;
            // 
            // inflationTextBox
            // 
            this.inflationTextBox.Location = new System.Drawing.Point(179, 124);
            this.inflationTextBox.Name = "inflationTextBox";
            this.inflationTextBox.Size = new System.Drawing.Size(148, 31);
            this.inflationTextBox.TabIndex = 21;
            // 
            // gdpGrowthTextBox
            // 
            this.gdpGrowthTextBox.Location = new System.Drawing.Point(179, 69);
            this.gdpGrowthTextBox.Name = "gdpGrowthTextBox";
            this.gdpGrowthTextBox.Size = new System.Drawing.Size(148, 31);
            this.gdpGrowthTextBox.TabIndex = 20;
            // 
            // countryTextBox
            // 
            this.countryTextBox.Location = new System.Drawing.Point(179, 14);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(148, 31);
            this.countryTextBox.TabIndex = 19;
            // 
            // addCountry_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 313);
            this.Controls.Add(this.addTradePartnerTextBox);
            this.Controls.Add(this.addPartnerButton);
            this.Controls.Add(this.removePartnerButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.createCountryButton);
            this.Controls.Add(this.tradePartnersLabel);
            this.Controls.Add(this.hdiRankingLabel);
            this.Controls.Add(this.tradeBalanceLabel);
            this.Controls.Add(this.InflationLabel);
            this.Controls.Add(this.GDPGrowthLabel);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.tradePartnersListBox);
            this.Controls.Add(this.hdiRankingTextBox);
            this.Controls.Add(this.tradeBalanceTextBox);
            this.Controls.Add(this.inflationTextBox);
            this.Controls.Add(this.gdpGrowthTextBox);
            this.Controls.Add(this.countryTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "addCountry_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insert new country";
            this.Load += new System.EventHandler(this.addCountry_Form_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox addTradePartnerTextBox;
        private System.Windows.Forms.Button addPartnerButton;
        private System.Windows.Forms.Button removePartnerButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button createCountryButton;
        private System.Windows.Forms.Label tradePartnersLabel;
        private System.Windows.Forms.Label hdiRankingLabel;
        private System.Windows.Forms.Label tradeBalanceLabel;
        private System.Windows.Forms.Label InflationLabel;
        private System.Windows.Forms.Label GDPGrowthLabel;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.ListBox tradePartnersListBox;
        private System.Windows.Forms.TextBox hdiRankingTextBox;
        private System.Windows.Forms.TextBox tradeBalanceTextBox;
        private System.Windows.Forms.TextBox inflationTextBox;
        private System.Windows.Forms.TextBox gdpGrowthTextBox;
        private System.Windows.Forms.TextBox countryTextBox;
    }
}