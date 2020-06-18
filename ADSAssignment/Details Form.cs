using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ADSAssignment
{
    public partial class Details_Form : Form
    {
        public AVLCountry refToMainTree { get; set; }
        public Country current { get; set; }
        Form1 refToForm1 = Application.OpenForms.OfType<Form1>().Single(); // creates a reference to form 1

        private void Details_Form_Load(object sender, EventArgs e)
        {
            Assign(this);
            refToForm1.fetchMainForm();
        }

        public Details_Form(string countryName, double gdpGrowth, double inflation, double tradeBalance, int hdiRanking, LinkedList<string> tradePartners)
        {
            InitializeComponent();
            this.FormClosing += DetailsFormClosing; //Show main form when this closes
            this.FormBorderStyle = FormBorderStyle.FixedSingle; //non resizable
            countryTextBox.Text = countryName;
            gdpGrowthTextBox.Text = gdpGrowth.ToString();
            inflationTextBox.Text = inflation.ToString();
            tradeBalanceTextBox.Text = tradeBalance.ToString();
            hdiRankingTextBox.Text = hdiRanking.ToString();
            if (tradePartners != null)
            {
                foreach (string partner in tradePartners)
                {
                    tradePartnersListBox.Items.Add(partner);
                }   
                tradePartnersListBox.Sorted = true;
            }
        }

        //handles X(Close) button and form closing - if this form is closed open Form1
        void DetailsFormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                refToForm1.Show();
            if (e.CloseReason == CloseReason.WindowsShutDown)
                refToForm1.Show();
        }

        private void backToMainFormButton_Click(object sender, EventArgs e)
        {
            if (saveButton.Enabled == true)
            {
                if (MessageBox.Show("Do you wish to save the current changes?", "Unsaved Changes",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    performSaveOperation();
                else
                {
                    Close();
                    refToForm1.fetchMainForm();
                }
            }
            else
                Close();
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You are about to permanently delete " + countryTextBox.Text
            + " from the record. Do you want to proceed?", "Delete Operation",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                refToMainTree.RemoveItem(current);
                refToForm1.fetchMainForm();
                Close();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you wish to save the current changes?", "Edit country",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                performSaveOperation();
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
            saveButton.Enabled = true;
        }

        private void addPartnerButton_Click(object sender, EventArgs e)
        {
            
            string partner = addTradePartnerTextBox.Text;
            if (!string.IsNullOrWhiteSpace(partner))
            {
                tradePartnersListBox.Items.Add(partner);
                addTradePartnerTextBox.Text= null;
            }
                
        }

        private void removePartnerButton_Click(object sender, EventArgs e)
        {
            tradePartnersListBox.Items.Remove(tradePartnersListBox.SelectedItem);
        }

        private void tradePartnersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //identify selected item
                string curItem = tradePartnersListBox.SelectedItem.ToString();
            }
            catch
            {
                //if not possible activate saveButton (a change as occured)
               saveButton.Enabled = true;
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
                refToMainTree.RemoveItem(current);
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

        private void showTradePartnersButton_Click(object sender, EventArgs e)
        {
            tradePartnersForm TPForm = new tradePartnersForm();
            TPForm.refToMainTree = refToMainTree;
            TPForm.current = current;
            TPForm.Show();
            Hide();
        }
    }
}
