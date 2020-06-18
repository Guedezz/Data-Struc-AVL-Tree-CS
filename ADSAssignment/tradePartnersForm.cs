using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ADSAssignment
{
    public partial class tradePartnersForm : Form
    {
        DataTable dataTable;
        AVLCountry tradePartnersTree = new AVLCountry();
        Details_Form refToDetailsForm = Application.OpenForms.OfType<Details_Form>().Single();
        public Country current { get; set; }
        public AVLCountry refToMainTree { get; set; }
        public tradePartnersForm()
        {
            InitializeComponent();
            this.FormClosing += thisFormClosing; //Show main form when this closes
            this.FormBorderStyle = FormBorderStyle.FixedSingle; //window fixed size
        }

        private void tradePartners_Load(object sender, EventArgs e)
        {
            tradePartnersLabel.Text = "Showing Trade Partners of: " + current.CountryName.ToString();
            dataTable = new DataTable();
            dataTable.Columns.Add("Country");
            dataTable.Columns.Add("GDP Growth");
            dataTable.Columns.Add("Inflation");
            dataTable.Columns.Add("Trade Balance");
            dataTable.Columns.Add("HDI Ranking");
            countryDataGridView.DataSource = dataTable;

            tradePartnersTree = refToMainTree.fetchAllTradePartners(current);
            dataTable.Clear();

            foreach (Country c in tradePartnersTree.GetAllCountries())
            {
                if (tradePartnersTree != null)
                    dataTable.Rows.Add(c.CountryName, c.GDPGrowth, c.Inflation, c.TradeBalance, c.HDIRanking);
            }
            countryDataGridView.Update();
        }

        void thisFormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                refToDetailsForm.Show();
            if (e.CloseReason == CloseReason.WindowsShutDown)
                refToDetailsForm.Show();
        }
    }
}