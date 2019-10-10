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

    public partial class Administrator : Form
    {
        private List<AccountEntry> accountList = new List<AccountEntry>();
        private List<CustomerEntry> customerList = new List<CustomerEntry>();
        private List<LoanEntry> loanList = new List<LoanEntry>();

        public Administrator()
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

        private void addButton_Click(object sender, EventArgs e)
        {
            if (loanCheckBox.Checked == true || accountCheckBox.Checked == true || customerCheckBox.Checked == true)
            {
                if (loanCheckBox.Checked == true)
                {
                    loanListBox.Items.Add(loanTextBox.Text);
                    string path = @"backupLoanList.txt";
                    if (!File.Exists(path))
                    {
                        using (StreamWriter sw = File.CreateText(path)) { }
                    }
                    using (StreamWriter sw = File.AppendText(path))
                    {
                        sw.WriteLine(loanTextBox.Text);
                        sw.Close();
                    }
                }
                if (accountCheckBox.Checked == true)
                {
                    accountListBox.Items.Add(accountTextBox.Text);
                    string path = @"backupAccountList.txt";
                    if (!File.Exists(path))
                    {
                        using (StreamWriter sw = File.CreateText(path)) { }
                    }
                    using (StreamWriter sw = File.AppendText(path))
                    {
                        sw.WriteLine(loanTextBox.Text);
                        sw.Close();
                    }
                }
                if (customerCheckBox.Checked == true)
                {
                    customerListBox.Items.Add(customerTextBox.Text);
                    string path = @"backupCustomerList.txt";
                    if (!File.Exists(path))
                    {
                        using (StreamWriter sw = File.CreateText(path)) { }
                    }
                    using (StreamWriter sw = File.AppendText(path))
                    {
                        sw.WriteLine(loanTextBox.Text);
                        sw.Close();
                    }
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
                    MessageBox.Show("Successful backup");
                }
                if (accountCheckBox.Checked == true)
                {
                    ReadAccountFile();
                    foreach (AccountEntry entry in accountList)
                    {
                        accountListBox.Items.Add(entry.accountID + ", " + entry.accountNumber + ", " + entry.accountType + ", " + entry.amount);
                    }
                    accountCheckBox.Checked = false;
                    MessageBox.Show("Successful backup");
                }
                if (customerCheckBox.Checked == true)
                {
                    ReadCustomerFile();
                    foreach (CustomerEntry entry in customerList)
                    {
                        customerListBox.Items.Add(entry.customerID + ", " + entry.firstName + ", " + entry.lastName + ", " + entry.accountID);
                    }
                    customerCheckBox.Checked = false;
                    MessageBox.Show("Successful backup");
                }
            }
            else
            {
                MessageBox.Show("You need to check a box");
            }
        }

        private void backupButton_Click(object sender, EventArgs e)
        {
            if (loanCheckBox.Checked == true || accountCheckBox.Checked == true || customerCheckBox.Checked == true)
            {
                if (loanCheckBox.Checked == true)
                {
                    string path = @"backupLoanList.txt";
                    if (!File.Exists(path))
                    {
                        using (StreamWriter sw = File.CreateText(path)) { }
                    }
                    using (StreamWriter sw = File.AppendText(path))
                    {
                        foreach (LoanEntry entry in loanList)
                        {
                            sw.WriteLine(entry.customerID + "," + entry.loanID + "," + entry.loanType + "," + entry.years + "," + entry.interestRate + "," + entry.amount);
                        }
                        sw.Close();
                    }
                    
                }
                if (accountCheckBox.Checked == true)
                {
                    string path = @"backupAccountList.txt";
                    if (!File.Exists(path))
                    {
                        using (StreamWriter sw = File.CreateText(path)) { }
                    }
                    using (StreamWriter sw = File.AppendText(path))
                    {
                        foreach (AccountEntry entry in accountList)
                        {
                            sw.WriteLine(entry.accountID + "," + entry.accountNumber + "," + entry.accountType + "," + entry.amount);
                        }
                        sw.Close();
                    }
                }
                if (customerCheckBox.Checked == true)
                {
                    string path = @"backupCustomerList.txt";
                    if (!File.Exists(path))
                    {
                        using (StreamWriter sw = File.CreateText(path)) { }
                    }
                    using (StreamWriter sw = File.AppendText(path))
                    {
                        foreach (CustomerEntry entry in customerList)
                        {
                            sw.WriteLine(entry.customerID + "," + entry.firstName + "," + entry.lastName + "," + entry.accountID);
                        }
                        sw.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("You need to check a box");
            }
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

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
