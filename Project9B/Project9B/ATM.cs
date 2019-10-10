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
using System.Globalization;

namespace Project9B
{
    public partial class ATM : Form
    {
        public ATM()
        {
            InitializeComponent();
        }

        private void depositChecking()
        {
            try
            {
                if (balanceLabelC.Text == "")
                {
                    balanceLabelC.Text = "0";
                }
                if (double.Parse(amountTextBoxC.Text) < 0)
                {
                    MessageBox.Show("Cannot enter negative numbers");
                    amountTextBoxC.Text = "";
                }
                else
                {
                    balanceLabelC.Text = (double.Parse(balanceLabelC.Text) + double.Parse(amountTextBoxC.Text)).ToString();
                    displayBalances();
                    StreamWriter sr = File.AppendText("checking.txt");
                    sr.WriteLine("Deposited: $" + amountTextBoxC.Text + " New balance: $" + balanceLabelC.Text);
                    sr.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void withdrawChecking()
        {
            try
            {
                if (balanceLabelC.Text == "")
                {
                    balanceLabelC.Text = "0";
                }
                if (double.Parse(amountTextBoxC.Text) < 0)
                {
                    MessageBox.Show("Cannot enter negative numbers");
                    amountTextBoxC.Text = "";
                }
                else
                {
                    if (double.Parse(amountTextBoxC.Text) > double.Parse(balanceLabelC.Text))
                    {
                        MessageBox.Show("Cannot withdraw more than available");
                        amountTextBoxC.Text = "";
                    }
                    else
                    {
                        balanceLabelC.Text = (double.Parse(balanceLabelC.Text) - double.Parse(amountTextBoxC.Text)).ToString();
                        displayBalances();
                        StreamWriter sr = File.AppendText("checking.txt");
                        sr.WriteLine("Withdrawn: $" + amountTextBoxC.Text + " New balance: $" + balanceLabelC.Text);
                        sr.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void depositSavings()
        {
            try
            {
                if (balanceLabelS.Text == "")
                {
                    balanceLabelS.Text = "0";
                }
                if (double.Parse(amountTextBoxS.Text) < 0)
                {
                    MessageBox.Show("Cannot enter negative numbers");
                    amountTextBoxS.Text = "";
                }
                else
                {
                    balanceLabelS.Text = (double.Parse(balanceLabelS.Text) + double.Parse(amountTextBoxS.Text)).ToString();
                    displayBalances();
                    StreamWriter ss = File.AppendText("checking.txt");
                    ss.WriteLine("Deposited: $" + amountTextBoxS.Text + " New balance: $" + balanceLabelS.Text);
                    ss.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void withdrawSavings()
        {
            try
            {
                if (balanceLabelS.Text == "")
                {
                    balanceLabelS.Text = "0";
                }
                if (double.Parse(amountTextBoxS.Text) < 0)
                {
                    MessageBox.Show("Cannot enter negative numbers");
                    amountTextBoxS.Text = "";
                }
                else
                {
                    if (double.Parse(amountTextBoxS.Text) > double.Parse(balanceLabelS.Text))
                    {
                        MessageBox.Show("Cannot withdraw more than available");
                        amountTextBoxS.Text = "";
                    }
                    else
                    {
                        balanceLabelS.Text = (double.Parse(balanceLabelS.Text) - double.Parse(amountTextBoxS.Text)).ToString();
                        displayBalances();
                        StreamWriter ss = File.AppendText("savings.txt");
                        ss.WriteLine("Withdrawn: " + amountTextBoxS.Text + " New balance: " + balanceLabelS.Text);
                        ss.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void displayBalances()
        {
            if (balanceLabelC.Text == "")
            {
                balanceLabelC.Text = "0";
            }
            if (balanceLabelS.Text == "")
            {
                balanceLabelS.Text = "0";
            }
            balanceLabelC.Text = Math.Round(decimal.Parse(balanceLabelC.Text), 2).ToString("#.00", CultureInfo.InvariantCulture);
            balanceLabelS.Text = Math.Round(decimal.Parse(balanceLabelS.Text), 2).ToString("#.00", CultureInfo.InvariantCulture);
        }

        private void submitButtonC_Click(object sender, EventArgs e)
        {
            try
            {
                if (depositRadioButtonC.Checked == false && withdrawRadioButtonC.Checked == false)
                {
                    MessageBox.Show("Make a transaction selection");
                }
                else
                {
                    if (depositRadioButtonC.Checked == true)
                    {
                        depositChecking();
                    }
                    else
                    {
                        withdrawChecking();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearButtonC_Click(object sender, EventArgs e)
        {
            amountTextBoxC.Clear();
            amountTextBoxC.Clear();
        }

        private void myButtonC_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Everything is awesome, when you're cwood19");
        }

        private void exitButtonC_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void depositRadioButtonC_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void withdrawRadioButtonC_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void submitButtonS_Click(object sender, EventArgs e)
        {
            try
            {
                if (depositRadioButtonS.Checked == false && withdrawRadioButtonS.Checked == false)
                {
                    MessageBox.Show("Make a transaction selection");
                }
                else
                {
                    if (depositRadioButtonS.Checked == true)
                    {
                        depositSavings();
                    }
                    else
                    {
                        withdrawSavings();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearButtonS_Click(object sender, EventArgs e)
        {
            amountTextBoxS.Clear();
            amountTextBoxS.Focus();
        }

        private void myButtonS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Everything is awesome, when you're cwood19");
        }

        private void exitButtonS_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
