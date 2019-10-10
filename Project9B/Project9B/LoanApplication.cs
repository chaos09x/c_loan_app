using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Project9B
{
    struct StateEntry
    {
        public string states;
        public string statenum;
    }
    public partial class LoanApplication : Form
    {
        private List<StateEntry> stateList = new List<StateEntry>();

        public LoanApplication()
        {
            InitializeComponent();
        }

        private bool IsValidFormat(string str)
        {
            const int VALID_LENGTH = 11;
            bool valid;
            if (str.Length == VALID_LENGTH && str[3] == '-' && str[6] == '-')
            {
                valid = true;
            }
            else
            {
                valid = false;
            }
            return valid;
        }

        private bool LastNameLength(string str)
        {
            bool valid = true;
            if (str.Length <= 30)
            {
                foreach (char ch in str)
                {
                    if (!char.IsLetter(ch))
                    {
                        valid = false;
                    }
                }
            }
            else
            {
                valid = false;
            }
            return valid;
        }
        private bool FirstNameLength(string str)
        {
            bool valid = true;
            if (str.Length <= 20)
            {
                foreach (char ch in str)
                {
                    if (!char.IsLetter(ch))
                    {
                        valid = false;
                    }
                }
            }
            else
            {
                valid = false;
            }
            return valid;
        }
        private void ReadStateList()
        {
            try
            {
                StreamReader inputFile;
                string line;
                StateEntry entry = new StateEntry();
                char[] delim = { ',' };
                inputFile = File.OpenText("statelist.txt");
                while (!inputFile.EndOfStream)
                {
                    line = inputFile.ReadLine();
                    string[] tokens = line.Split(delim);
                    entry.states = tokens[0];
                    entry.statenum = tokens[1];
                    stateList.Add(entry);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoanApplication_Load(object sender, EventArgs e)
        {
            ReadStateList();
            foreach (StateEntry entry in stateList)
            {
                stateListBox.Items.Add(entry.states);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            fNameTextBox.Text = ""; lNameTextBox.Text = ""; miTextBox.Text = ""; ageComboBox.SelectedIndex = -1; ssnTextBox.Text = "XXX-XX-XXXX";
            maleRadioButton.Checked = false; femaleRadioButton.Checked = false; marriedRadioButton.Checked = false; unmarriedRadioButton.Checked = false;
            widowedRadioButton.Checked = false; divorcedRadioButton.Checked = false; carRadioButton.Checked = false; houseRadioButton.Checked = false;
            schoolRadioButton.Checked = false; otherRadioButton.Checked = false; employerTextBox.Text = ""; yearworkTextBox.Text = "";
            salaryTextBox.Text = ""; numTextBox.Text = ""; streetTextBox.Text = ""; cityTextBox.Text = "";
            zipTextBox.Text = ""; fNameTextBox.Focus();
            foreach (int i in positionCheckedListBox.CheckedIndices)
            {
                positionCheckedListBox.SetItemCheckState(i, CheckState.Unchecked);
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (!IsValidFormat(ssnTextBox.Text))
            {
                MessageBox.Show("Fix SSN");
            }
            else if (!FirstNameLength(fNameTextBox.Text))
            {
                MessageBox.Show("Fix First Name");
            }
            else if (!LastNameLength(lNameTextBox.Text))
            {
                MessageBox.Show("Fix Last Name");
            }
            else
            {
                string path = @"loanAPP.txt";
                if (!File.Exists(path))
                {
                    using (StreamWriter sw = File.CreateText(path)) { }
                }
                using (StreamWriter sw = File.AppendText(path))
                {
                    string a = ""; string b = ""; string c = "";
                    if (maleRadioButton.Checked == true) { a = "Male"; }
                    else if(femaleRadioButton.Checked == true) { a = "Female"; }
                    else { MessageBox.Show("Check a gender"); }
                    if (marriedRadioButton.Checked == true) { b = "Married"; }
                    else if(unmarriedRadioButton.Checked == true) { b = "Unmarried"; }
                    else if(widowedRadioButton.Checked == true) { b = "Widowed"; }
                    else if(divorcedRadioButton.Checked == true) { b = "Divorced"; }
                    else { MessageBox.Show("Check a marital status"); }
                    if (carRadioButton.Checked == true) { c = "Car"; }
                    else if (houseRadioButton.Checked == true) { c = "House"; }
                    else if (otherRadioButton.Checked == true) { c = "Other"; }
                    else if(schoolRadioButton.Checked == true) { c = "School"; }
                    else { MessageBox.Show("Check a loan type"); }
                    if(positionCheckedListBox.CheckedItems == null) { MessageBox.Show("Select a position"); }
                    sw.WriteLine(fNameTextBox.Text + "," + lNameTextBox.Text + "," + miTextBox.Text + "," + ageComboBox.SelectedValue + "," +
                        ssnTextBox.Text + "," + a + "," + b + "," + numTextBox.Text + "," + streetTextBox.Text + "," + 
                        cityTextBox.Text + "," + zipTextBox.Text + "," + stateListBox.SelectedValue + "," + employerTextBox.Text + "," + 
                        positionCheckedListBox.SelectedValue + "," + yearworkTextBox.Text + "," + salaryTextBox.Text + "," + c);
                    sw.Close();
                }
            }
            
        }
    }
}
