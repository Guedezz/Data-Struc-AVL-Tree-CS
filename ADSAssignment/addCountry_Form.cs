using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ADSAssignment
{
    public partial class addCountry_Form : Form
    {
        public AVLCountry refToMainTree { get; set; }
        public Country current { get; set; }

        Form1 refToForm1 = Application.OpenForms.OfType<Form1>().Single(); //reference to Form1
        public addCountry_Form()
        {
            InitializeComponent();
            this.FormClosing += addCountryFormClosing; //Show main form when this closes
            this.FormBorderStyle = FormBorderStyle.FixedSingle; //non resizable
        }
        private void addCountry_Form_Load_1(object sender, EventArgs e)
        {
            Assign(this);
        }
        
        //handles changes in any textbox in this form
        void Assign(Control control)
        {
            foreach (Control ctrl in control.Controls)
            {
                if (ctrl is TextBox)
                {
                    TextBox textBoxes = (TextBox)ctrl;
                    textBoxes.TextChanged += new EventHandler(textBoxes_TextChanged);
                }
                else
                    Assign(ctrl);
            }
        }

        void textBoxes_TextChanged(object sender, EventArgs e)
        {
            createCountryButton.Enabled = true;
        }

        //handles X(Close) button and form closing
        void addCountryFormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                refToForm1.Show();

            if (e.CloseReason == CloseReason.WindowsShutDown)
                refToForm1.Show();
        }

        private void createCountryButton_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you wish insert " + countryTextBox.Text + " into main tree?", "Create new country",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                performSaveOperation();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addPartnerButton_Click(object sender, EventArgs e)
        {
            string partner = addTradePartnerTextBox.Text;
            if (!string.IsNullOrWhiteSpace(partner))
            {
                tradePartnersListBox.Items.Add(partner);
                addTradePartnerTextBox.Text = null;
            }
        }

        private void removePartnerButton_Click_1(object sender, EventArgs e)
        {
            tradePartnersListBox.Items.Remove(tradePartnersListBox.SelectedItem);
        }

        private void tradePartnersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //identify item selected
                string curItem = tradePartnersListBox.SelectedItem.ToString();
            }
            catch
            {
                //if not possible activate saveButton (a change as occured)
                createCountryButton.Enabled = true;
            }
        }
        void performSaveOperation()
        {
            string name = countryTextBox.Text;
            string gdpGrowth = gdpGrowthTextBox.Text;
            string inflation = inflationTextBox.Text;
            string tradeBalance = tradeBalanceTextBox.Text;
            string hdiRanking = hdiRankingTextBox.Text;
            LinkedList<string> tradePartners = new LinkedList<string>();
            int size = tradePartnersListBox.Items.Count;
            string[] partners = new string[size];
            for (int i = 0; i < size; i++)
            {
                partners[i] = tradePartnersListBox.Items[i].ToString();
            }

            foreach (string tradePartner in partners)
            {
                tradePartners.AddLast(tradePartner);
            }
            try
            {
                Country temp = new Country(name, double.Parse(gdpGrowth), double.Parse(inflation), double.Parse(tradeBalance), int.Parse(hdiRanking), tradePartners);
                refToMainTree.InsertItem(temp);
                refToForm1.fetchMainForm();
                refToForm1.Show();
                Close();
            }
            catch
            {
                MessageBox.Show("Record not saved. Please ensure all fields respect the correct format or are not empty."
              , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
