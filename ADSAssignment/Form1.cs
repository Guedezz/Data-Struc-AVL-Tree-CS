using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ADSAssignment
{
    public partial class Form1 : Form
    {
        private AVLCountry CountryAVLTree = new AVLCountry();
        private Country currentCountry = new Country();
        //variables to pass into Form Details_Form
        private string countryName;
        private double gdpGrowth;
        private double inflation;
        private double tradeBalance;
        private int hdiRanking;
        private LinkedList<String> mainTradePartners;
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // fixed window size
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "CSV Files|*.csv", ValidateNames = true })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string[] headers = new string[6]; //column headers
                    const int MAX_LINES_FILE = 50000;
                    string[] AllLines = new string[MAX_LINES_FILE];
                    AllLines = File.ReadAllLines(ofd.FileName); //name of file selected in dialog box
                    foreach (string line in AllLines)
                    {
                        if (line.StartsWith("Country")) //found first line - headers
                        {
                          headers = line.Split(',');
                        }
                        else
                        {
                            //split data using commas
                            string[] columns = line.Split(',');
                            LinkedList<String> tradePartnersLinkedList = new LinkedList<string>();
                            string[] partners = columns[5].Split(';', '[', ']');
                            foreach (string tradePartner in partners) 
                            {
                                if (tradePartner != "")
                                {
                                   tradePartnersLinkedList.AddLast(tradePartner);
                                }
                            }
                            Country c = new Country(columns[0], Double.Parse(columns[1]), Double.Parse(columns[2]),
                            Double.Parse(columns[3]), int.Parse(columns[4]), tradePartnersLinkedList);

                            CountryAVLTree.InsertItem(c);
                            fetchMainForm();
                        }
                    }
                     MessageBox.Show("Operation Complete. Number of countries: " + CountryAVLTree.Count(), "Operation Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public void fetchMainForm()
        {
            countryComboBox.DataSource = CountryAVLTree.GetAllCountries();
            countryComboBox.DisplayMember = "countryName";
            selectCountryLabel.Text = "Select Country: " + CountryAVLTree.Count().ToString();
            countLabel.Text = CountryAVLTree.Count().ToString();
            depthLabel.Text = CountryAVLTree.Height().ToString();
        }
        private void detailsButton_Click(object sender, EventArgs e)
        {
            try
            {
                //set selected contry details into variables and pass to second form
                currentCountry = (Country)countryComboBox.SelectedItem;
                Details_Form details_Form;

                countryName = currentCountry.CountryName;
                gdpGrowth = currentCountry.GDPGrowth;
                inflation = currentCountry.Inflation;
                tradeBalance = currentCountry.TradeBalance;
                hdiRanking = currentCountry.HDIRanking;
                mainTradePartners = currentCountry.TradePartners;
                //initialise form and pass on
                details_Form = new Details_Form(countryName, gdpGrowth, inflation, tradeBalance, hdiRanking, mainTradePartners)
                { refToMainTree = CountryAVLTree, current = currentCountry };

                Visible = false;
                details_Form.Show();
            }
            catch
            {
                MessageBox.Show("Please select a country", "No country selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void searchCountryTextBox_TextChanged(object sender, EventArgs e)
        {
            AVLCountry searchTree = new AVLCountry();
            string userInput = searchCountryTextBox.Text;
            var source = new AutoCompleteStringCollection();
            if (userInput == "")
            {
                //refresh comboBox
                countryComboBox.DataSource = CountryAVLTree.GetAllCountries();
                countryComboBox.DisplayMember = "countryName";
                selectCountryLabel.Text = "Select Country: " + CountryAVLTree.Count().ToString();
                //clear search results
                foreach (Country search in searchTree.GetAllCountries())
                {
                    searchTree.RemoveItem(search);
                }
            }
            else
            {
                //clear all user innput
                int countryCount = 0;
                currentCountry = null;
                countryComboBox.Text = "";
                selectCountryLabel.Text = "Select Country: 0";
                foreach (Country c in CountryAVLTree.GetAllCountries())
                {
                    if (c.CountryName.ToLower().StartsWith(userInput.ToLower().Trim()))
                    {
                        source.Add(c.CountryName);
                        countryCount++;
                        searchTree.InsertItem(c);
                    }
                }
                foreach (Country search in searchTree.GetAllCountries())
                {
                    if (!search.CountryName.ToLower().StartsWith(userInput.ToLower().Trim()))
                    {
                        source.Remove(search.CountryName);
                        countryCount--;
                        searchTree.RemoveItem(search);
                    }
                }
                countryComboBox.DataSource = searchTree.GetAllCountries();
                countryComboBox.DisplayMember = "countryName";
                selectCountryLabel.Text = "Select Country: " + countryCount;
                searchCountryTextBox.AutoCompleteCustomSource = source;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you wish to exit? All unsaved data will be lost.", "Exit",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();
        }

        private void insertCountryButton_Click(object sender, EventArgs e)
        {
            addCountry_Form addCountry = new addCountry_Form();
            addCountry.refToMainTree = CountryAVLTree;
            addCountry.Show();
            this.Hide();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "CSV|* .csv", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string headers = "Country,GDP Growth,Inflation,Trade Balance,HDI Ranking,Main Trade Partners";
                    string format = "{0},{1},{2},{3},{4},{5}";
                    using (var sw = new StreamWriter(sfd.FileName))
                    {
                        sw.WriteLine(headers);
                        foreach (Country c in CountryAVLTree.GetAllCountries())
                        {
                            string partners = "[";
                            foreach (string partner in c.TradePartners)
                            {
                                partners = partners + partner.Replace(' ', '_') + ";";
                            }
                            partners = partners.Remove(partners.Length - 1);
                            partners = partners + "]";
                            sw.WriteLine(String.Format(format, c.CountryName.Replace(' ', '_'), c.GDPGrowth, c.Inflation, c.TradeBalance, c.HDIRanking, partners));
                        }
                        if (sw != null)
                        {
                            sw.Close();
                        }
                    }
                    MessageBox.Show("Your data has been successfuly saved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } 
        }
    }
}
