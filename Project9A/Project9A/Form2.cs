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

namespace Project9A
{
    struct AccountEntry
    {
        public string accountID;
        public string accountNumber;
        public string accountType;
        public string amount;
    }

    struct CustomerEntry
    {
        public string customerID;
        public string firstName;
        public string lastName;
        public string accountID;
    }

    struct LoanEntry
    {
        public string customerID;
        public string loanID;
        public string loanType;
        public string years;
        public string interestRate;
        public string amount;
    }

    public partial class Form2 : Form
    {
        private List<AccountEntry> accountList = new List<AccountEntry>();
        private List<CustomerEntry> customerList = new List<CustomerEntry>();
        private List<LoanEntry> loanList = new List<LoanEntry>();

        public Form2()
        {
            InitializeComponent();
        }

        private void ReadAccountFile()
        {
            try
            {
                StreamReader inputFile;
                string line;
                AccountEntry entry = new AccountEntry();
                char[] delim = { ',' };
                inputFile = File.OpenText("accounts.txt");
                while (!inputFile.EndOfStream)
                {
                    line = inputFile.ReadLine();
                    string[] tokens = line.Split(delim);
                    entry.accountID = tokens[0];
                    entry.accountNumber = tokens[1];
                    entry.accountType = tokens[2];
                    entry.amount = tokens[3];
                    accountList.Add(entry);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ReadCustomerFile()
        {
            try
            {
                StreamReader inputFile;
                string line;
                CustomerEntry entry = new CustomerEntry();
                char[] delim = { ',' };
                inputFile = File.OpenText("customers.txt");
                while (!inputFile.EndOfStream)
                {
                    line = inputFile.ReadLine();
                    string[] tokens = line.Split(delim);
                    entry.customerID = tokens[0];
                    entry.firstName = tokens[1];
                    entry.lastName = tokens[2];
                    entry.accountID = tokens[3];
                    customerList.Add(entry);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ReadLoanFile()
        {
            try
            {
                StreamReader inputFile;
                string line;
                LoanEntry entry = new LoanEntry();
                char[] delim = { ',' };
                inputFile = File.OpenText("loans.txt");
                while (!inputFile.EndOfStream)
                {
                    line = inputFile.ReadLine();
                    string[] tokens = line.Split(delim);
                    entry.customerID = tokens[0];
                    entry.loanID = tokens[1];
                    entry.loanType = tokens[2];
                    entry.years = tokens[3];
                    entry.interestRate = tokens[4];
                    entry.amount = tokens[5];
                    loanList.Add(entry);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            loanCheckBox.Checked = false;
            accountCheckBox.Checked = false;
            customerCheckBox.Checked = false;
            customerTextBox.Text = "";
            loanTextBox.Text = "";
            accountTextBox.Text = "";
            accountListBox.Items.Clear();
            loanListBox.Items.Clear();
            customerListBox.Items.Clear();
        }

        private void backupButton_Click(object sender, EventArgs e)
        {
            if (loanCheckBox.Checked == true || accountCheckBox.Checked == true || customerCheckBox.Checked == true)
            {
                if (loanCheckBox.Checked == true)
                {
                    TextWriter tw = new StreamWriter("backupLoanList.txt");
                    foreach (LoanEntry entry in loanList)
                    {
                        tw.WriteLine(entry);
                    }
                    tw.Close();
                }
                if (accountCheckBox.Checked == true)
                {
                    TextWriter tw = new StreamWriter("backupAccountList.txt");

                    foreach (AccountEntry entry in accountList)
                    {
                        tw.WriteLine(entry);
                    }
                    tw.Close();
                }
                if (customerCheckBox.Checked == true)
                {
                    TextWriter tw = new StreamWriter("backupCustomerList.txt");
                    foreach (CustomerEntry entry in customerList)
                    {
                        tw.WriteLine(entry);
                    }
                    tw.Close();
                }
            }
            else
            {
                MessageBox.Show("You need to check a box");
            }
        }

        private void restoreButton_Click(object sender, EventArgs e)
        {
            if (loanCheckBox.Checked == true || accountCheckBox.Checked == true || customerCheckBox.Checked == true)
            {
                if (loanCheckBox.Checked == true)
                {
                    ReadLoanFile();
                    foreach (LoanEntry entry in loanList)
                    {
                        loanListBox.Items.Add(entry.customerID + ", " + entry.loanID + ", " + entry.loanType + ", " + entry.years + ", " + entry.interestRate + ", " + entry.amount);
                    }
                    loanCheckBox.Checked = false;
                }
                if (accountCheckBox.Checked == true)
                {
                    ReadAccountFile();
                    foreach (AccountEntry entry in accountList)
                    {
                        accountListBox.Items.Add(entry.accountID + ", " + entry.accountNumber + ", " + entry.accountType + ", " + entry.amount);
                    }
                    accountCheckBox.Checked = false;
                }
                if (customerCheckBox.Checked == true)
                {
                    ReadCustomerFile();
                    foreach (CustomerEntry entry in customerList)
                    {
                        customerListBox.Items.Add(entry.customerID + ", " + entry.firstName + ", " + entry.lastName + ", " + entry.accountID);
                    }
                    customerCheckBox.Checked = false;
                }
            }
            else
            {
                MessageBox.Show("You need to check a box");
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if(loanCheckBox.Checked == true || accountCheckBox.Checked == true || customerCheckBox.Checked == true)
            {
                if (loanCheckBox.Checked == true)
                {
                    loanListBox.Items.Add(loanTextBox.Text);
                }
                if (accountCheckBox.Checked == true)
                {
                    accountListBox.Items.Add(accountTextBox.Text);
                }
                if (customerCheckBox.Checked == true)
                {
                    customerListBox.Items.Add(customerTextBox.Text);
                }
            }
            else
            {
                MessageBox.Show("You need to check a box");
            }
        }
    }
}
