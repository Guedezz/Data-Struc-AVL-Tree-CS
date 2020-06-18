namespace ADSAssignment
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numberOfCountriesLabel = new System.Windows.Forms.Label();
            this.TreeDepthLabel = new System.Windows.Forms.Label();
            this.detailsButton = new System.Windows.Forms.Button();
            this.countryComboBox = new System.Windows.Forms.ComboBox();
            this.searchCountryTextBox = new System.Windows.Forms.TextBox();
            this.searchCountryLabel = new System.Windows.Forms.Label();
            this.selectCountryLabel = new System.Windows.Forms.Label();
            this.insertCountryButton = new System.Windows.Forms.Button();
            this.countLabel = new System.Windows.Forms.Label();
            this.depthLabel = new System.Windows.Forms.Label();
            this.aVLCountryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aVLCountryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(699, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(90, 36);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(218, 38);
            this.openFileToolStripMenuItem.Text = "Open File";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(218, 38);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(218, 38);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // numberOfCountriesLabel
            // 
            this.numberOfCountriesLabel.AutoSize = true;
            this.numberOfCountriesLabel.Location = new System.Drawing.Point(7, 267);
            this.numberOfCountriesLabel.Name = "numberOfCountriesLabel";
            this.numberOfCountriesLabel.Size = new System.Drawing.Size(239, 25);
            this.numberOfCountriesLabel.TabIndex = 2;
            this.numberOfCountriesLabel.Text = "Unique countries count:";
            // 
            // TreeDepthLabel
            // 
            this.TreeDepthLabel.AutoSize = true;
            this.TreeDepthLabel.Location = new System.Drawing.Point(297, 267);
            this.TreeDepthLabel.Name = "TreeDepthLabel";
            this.TreeDepthLabel.Size = new System.Drawing.Size(125, 25);
            this.TreeDepthLabel.TabIndex = 3;
            this.TreeDepthLabel.Text = "Tree Depth:";
            // 
            // detailsButton
            // 
            this.detailsButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.detailsButton.Location = new System.Drawing.Point(284, 88);
            this.detailsButton.Name = "detailsButton";
            this.detailsButton.Size = new System.Drawing.Size(394, 40);
            this.detailsButton.TabIndex = 6;
            this.detailsButton.Text = "Details";
            this.detailsButton.UseVisualStyleBackColor = true;
            this.detailsButton.Click += new System.EventHandler(this.detailsButton_Click);
            // 
            // countryComboBox
            // 
            this.countryComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.countryComboBox.FormattingEnabled = true;
            this.countryComboBox.Location = new System.Drawing.Point(12, 93);
            this.countryComboBox.Name = "countryComboBox";
            this.countryComboBox.Size = new System.Drawing.Size(238, 33);
            this.countryComboBox.TabIndex = 7;
            // 
            // searchCountryTextBox
            // 
            this.searchCountryTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.searchCountryTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.searchCountryTextBox.Location = new System.Drawing.Point(12, 162);
            this.searchCountryTextBox.Name = "searchCountryTextBox";
            this.searchCountryTextBox.Size = new System.Drawing.Size(238, 31);
            this.searchCountryTextBox.TabIndex = 8;
            this.searchCountryTextBox.TextChanged += new System.EventHandler(this.searchCountryTextBox_TextChanged);
            // 
            // searchCountryLabel
            // 
            this.searchCountryLabel.AutoSize = true;
            this.searchCountryLabel.Location = new System.Drawing.Point(14, 134);
            this.searchCountryLabel.Name = "searchCountryLabel";
            this.searchCountryLabel.Size = new System.Drawing.Size(167, 25);
            this.searchCountryLabel.TabIndex = 9;
            this.searchCountryLabel.Text = "Search Country:";
            // 
            // selectCountryLabel
            // 
            this.selectCountryLabel.AutoSize = true;
            this.selectCountryLabel.Location = new System.Drawing.Point(12, 65);
            this.selectCountryLabel.Name = "selectCountryLabel";
            this.selectCountryLabel.Size = new System.Drawing.Size(159, 25);
            this.selectCountryLabel.TabIndex = 10;
            this.selectCountryLabel.Text = "Select Country:";
            // 
            // insertCountryButton
            // 
            this.insertCountryButton.Location = new System.Drawing.Point(284, 153);
            this.insertCountryButton.Name = "insertCountryButton";
            this.insertCountryButton.Size = new System.Drawing.Size(394, 40);
            this.insertCountryButton.TabIndex = 12;
            this.insertCountryButton.Text = "Insert country";
            this.insertCountryButton.UseVisualStyleBackColor = true;
            this.insertCountryButton.Click += new System.EventHandler(this.insertCountryButton_Click);
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Location = new System.Drawing.Point(252, 267);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(24, 25);
            this.countLabel.TabIndex = 13;
            this.countLabel.Text = "0";
            // 
            // depthLabel
            // 
            this.depthLabel.AutoSize = true;
            this.depthLabel.Location = new System.Drawing.Point(428, 267);
            this.depthLabel.Name = "depthLabel";
            this.depthLabel.Size = new System.Drawing.Size(24, 25);
            this.depthLabel.TabIndex = 14;
            this.depthLabel.Text = "0";
            // 
            // aVLCountryBindingSource
            // 
            this.aVLCountryBindingSource.DataSource = typeof(ADSAssignment.AVLCountry);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 304);
            this.Controls.Add(this.depthLabel);
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.insertCountryButton);
            this.Controls.Add(this.selectCountryLabel);
            this.Controls.Add(this.searchCountryLabel);
            this.Controls.Add(this.searchCountryTextBox);
            this.Controls.Add(this.countryComboBox);
            this.Controls.Add(this.detailsButton);
            this.Controls.Add(this.TreeDepthLabel);
            this.Controls.Add(this.numberOfCountriesLabel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "International Trading Data";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aVLCountryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.BindingSource aVLCountryBindingSource;
        private System.Windows.Forms.Label numberOfCountriesLabel;
        private System.Windows.Forms.Label TreeDepthLabel;
        private System.Windows.Forms.Button detailsButton;
        private System.Windows.Forms.ComboBox countryComboBox;
        private System.Windows.Forms.TextBox searchCountryTextBox;
        private System.Windows.Forms.Label searchCountryLabel;
        private System.Windows.Forms.Label selectCountryLabel;
        private System.Windows.Forms.Button insertCountryButton;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.Label depthLabel;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

