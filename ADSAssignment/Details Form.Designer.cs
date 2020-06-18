namespace ADSAssignment
{
    partial class Details_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Details_Form));
            this.backToMainFormButton = new System.Windows.Forms.Button();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.gdpGrowthTextBox = new System.Windows.Forms.TextBox();
            this.inflationTextBox = new System.Windows.Forms.TextBox();
            this.tradeBalanceTextBox = new System.Windows.Forms.TextBox();
            this.hdiRankingTextBox = new System.Windows.Forms.TextBox();
            this.tradePartnersListBox = new System.Windows.Forms.ListBox();
            this.countryLabel = new System.Windows.Forms.Label();
            this.GDPGrowthLabel = new System.Windows.Forms.Label();
            this.InflationLabel = new System.Windows.Forms.Label();
            this.tradeBalanceLabel = new System.Windows.Forms.Label();
            this.hdiRankingLabel = new System.Windows.Forms.Label();
            this.tradePartnersLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.removePartnerButton = new System.Windows.Forms.Button();
            this.addPartnerButton = new System.Windows.Forms.Button();
            this.addTradePartnerTextBox = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.showTradePartnersButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backToMainFormButton
            // 
            this.backToMainFormButton.Location = new System.Drawing.Point(17, 310);
            this.backToMainFormButton.Name = "backToMainFormButton";
            this.backToMainFormButton.Size = new System.Drawing.Size(160, 45);
            this.backToMainFormButton.TabIndex = 0;
            this.backToMainFormButton.Text = "Back";
            this.backToMainFormButton.UseVisualStyleBackColor = true;
            this.backToMainFormButton.Click += new System.EventHandler(this.backToMainFormButton_Click);
            // 
            // countryTextBox
            // 
            this.countryTextBox.Location = new System.Drawing.Point(181, 25);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(148, 31);
            this.countryTextBox.TabIndex = 1;
            // 
            // gdpGrowthTextBox
            // 
            this.gdpGrowthTextBox.Location = new System.Drawing.Point(181, 80);
            this.gdpGrowthTextBox.Name = "gdpGrowthTextBox";
            this.gdpGrowthTextBox.Size = new System.Drawing.Size(148, 31);
            this.gdpGrowthTextBox.TabIndex = 2;
            // 
            // inflationTextBox
            // 
            this.inflationTextBox.Location = new System.Drawing.Point(181, 135);
            this.inflationTextBox.Name = "inflationTextBox";
            this.inflationTextBox.Size = new System.Drawing.Size(148, 31);
            this.inflationTextBox.TabIndex = 3;
            // 
            // tradeBalanceTextBox
            // 
            this.tradeBalanceTextBox.Location = new System.Drawing.Point(181, 190);
            this.tradeBalanceTextBox.Name = "tradeBalanceTextBox";
            this.tradeBalanceTextBox.Size = new System.Drawing.Size(148, 31);
            this.tradeBalanceTextBox.TabIndex = 4;
            // 
            // hdiRankingTextBox
            // 
            this.hdiRankingTextBox.Location = new System.Drawing.Point(181, 244);
            this.hdiRankingTextBox.Name = "hdiRankingTextBox";
            this.hdiRankingTextBox.Size = new System.Drawing.Size(148, 31);
            this.hdiRankingTextBox.TabIndex = 5;
            // 
            // tradePartnersListBox
            // 
            this.tradePartnersListBox.FormattingEnabled = true;
            this.tradePartnersListBox.ItemHeight = 25;
            this.tradePartnersListBox.Location = new System.Drawing.Point(383, 57);
            this.tradePartnersListBox.Name = "tradePartnersListBox";
            this.tradePartnersListBox.Size = new System.Drawing.Size(264, 129);
            this.tradePartnersListBox.TabIndex = 6;
            this.tradePartnersListBox.SelectedIndexChanged += new System.EventHandler(this.tradePartnersListBox_SelectedIndexChanged);
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Location = new System.Drawing.Point(12, 31);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(93, 25);
            this.countryLabel.TabIndex = 7;
            this.countryLabel.Text = "Country:";
            // 
            // GDPGrowthLabel
            // 
            this.GDPGrowthLabel.AutoSize = true;
            this.GDPGrowthLabel.Location = new System.Drawing.Point(12, 86);
            this.GDPGrowthLabel.Name = "GDPGrowthLabel";
            this.GDPGrowthLabel.Size = new System.Drawing.Size(131, 25);
            this.GDPGrowthLabel.TabIndex = 8;
            this.GDPGrowthLabel.Text = "GDPGrowth:";
            // 
            // InflationLabel
            // 
            this.InflationLabel.AutoSize = true;
            this.InflationLabel.Location = new System.Drawing.Point(12, 141);
            this.InflationLabel.Name = "InflationLabel";
            this.InflationLabel.Size = new System.Drawing.Size(93, 25);
            this.InflationLabel.TabIndex = 9;
            this.InflationLabel.Text = "Inflation:";
            // 
            // tradeBalanceLabel
            // 
            this.tradeBalanceLabel.AutoSize = true;
            this.tradeBalanceLabel.Location = new System.Drawing.Point(12, 196);
            this.tradeBalanceLabel.Name = "tradeBalanceLabel";
            this.tradeBalanceLabel.Size = new System.Drawing.Size(158, 25);
            this.tradeBalanceLabel.TabIndex = 10;
            this.tradeBalanceLabel.Text = "Trade Balance:";
            // 
            // hdiRankingLabel
            // 
            this.hdiRankingLabel.AutoSize = true;
            this.hdiRankingLabel.Location = new System.Drawing.Point(12, 250);
            this.hdiRankingLabel.Name = "hdiRankingLabel";
            this.hdiRankingLabel.Size = new System.Drawing.Size(138, 25);
            this.hdiRankingLabel.TabIndex = 11;
            this.hdiRankingLabel.Text = "HDI Ranking:";
            // 
            // tradePartnersLabel
            // 
            this.tradePartnersLabel.AutoSize = true;
            this.tradePartnersLabel.Location = new System.Drawing.Point(378, 29);
            this.tradePartnersLabel.Name = "tradePartnersLabel";
            this.tradePartnersLabel.Size = new System.Drawing.Size(214, 25);
            this.tradePartnersLabel.TabIndex = 12;
            this.tradePartnersLabel.Text = "Main Trade Partners:";
            // 
            // saveButton
            // 
            this.saveButton.Enabled = false;
            this.saveButton.Location = new System.Drawing.Point(383, 310);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(405, 45);
            this.saveButton.TabIndex = 13;
            this.saveButton.Text = "Save all changes";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // removePartnerButton
            // 
            this.removePartnerButton.ForeColor = System.Drawing.Color.Black;
            this.removePartnerButton.Location = new System.Drawing.Point(664, 57);
            this.removePartnerButton.Name = "removePartnerButton";
            this.removePartnerButton.Size = new System.Drawing.Size(124, 44);
            this.removePartnerButton.TabIndex = 15;
            this.removePartnerButton.Text = "−";
            this.removePartnerButton.UseVisualStyleBackColor = true;
            this.removePartnerButton.Click += new System.EventHandler(this.removePartnerButton_Click);
            // 
            // addPartnerButton
            // 
            this.addPartnerButton.ForeColor = System.Drawing.Color.Black;
            this.addPartnerButton.Location = new System.Drawing.Point(664, 107);
            this.addPartnerButton.Name = "addPartnerButton";
            this.addPartnerButton.Size = new System.Drawing.Size(125, 42);
            this.addPartnerButton.TabIndex = 16;
            this.addPartnerButton.Text = "+";
            this.addPartnerButton.UseVisualStyleBackColor = true;
            this.addPartnerButton.Click += new System.EventHandler(this.addPartnerButton_Click);
            // 
            // addTradePartnerTextBox
            // 
            this.addTradePartnerTextBox.Location = new System.Drawing.Point(664, 155);
            this.addTradePartnerTextBox.Name = "addTradePartnerTextBox";
            this.addTradePartnerTextBox.Size = new System.Drawing.Size(124, 31);
            this.addTradePartnerTextBox.TabIndex = 17;
            // 
            // deleteButton
            // 
            this.deleteButton.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.deleteButton.Location = new System.Drawing.Point(383, 244);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(405, 44);
            this.deleteButton.TabIndex = 14;
            this.deleteButton.Text = "Delete country";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // showTradePartnersButton
            // 
            this.showTradePartnersButton.Location = new System.Drawing.Point(383, 196);
            this.showTradePartnersButton.Name = "showTradePartnersButton";
            this.showTradePartnersButton.Size = new System.Drawing.Size(405, 43);
            this.showTradePartnersButton.TabIndex = 18;
            this.showTradePartnersButton.Text = "Show trade partners";
            this.showTradePartnersButton.UseVisualStyleBackColor = true;
            this.showTradePartnersButton.Click += new System.EventHandler(this.showTradePartnersButton_Click);
            // 
            // Details_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 383);
            this.Controls.Add(this.showTradePartnersButton);
            this.Controls.Add(this.addTradePartnerTextBox);
            this.Controls.Add(this.addPartnerButton);
            this.Controls.Add(this.removePartnerButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.saveButton);
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
            this.Controls.Add(this.backToMainFormButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Details_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Country Details";
            this.Load += new System.EventHandler(this.Details_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backToMainFormButton;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.TextBox gdpGrowthTextBox;
        private System.Windows.Forms.TextBox inflationTextBox;
        private System.Windows.Forms.TextBox tradeBalanceTextBox;
        private System.Windows.Forms.TextBox hdiRankingTextBox;
        private System.Windows.Forms.ListBox tradePartnersListBox;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Label GDPGrowthLabel;
        private System.Windows.Forms.Label InflationLabel;
        private System.Windows.Forms.Label tradeBalanceLabel;
        private System.Windows.Forms.Label hdiRankingLabel;
        private System.Windows.Forms.Label tradePartnersLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button removePartnerButton;
        private System.Windows.Forms.Button addPartnerButton;
        private System.Windows.Forms.TextBox addTradePartnerTextBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button showTradePartnersButton;
    }
}