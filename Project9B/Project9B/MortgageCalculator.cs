using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project9B
{
    public partial class MortgageCalculator : Form
    {
        // initialize variables so click event wont reset them to 0
        double count; double totalLoans; double totalMonthPayment; double averageMonthPayment;
        public MortgageCalculator()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            try
            {
                count = count + 1;
                // initialize variables & various calculations to put into labels
                // m = monthly payment, p = principal, r = monthly interest rate, calculated by dividing annual interest rate by 12
                // n is number of payments (the number of months you will pay on the loan)
                double P = double.Parse(loanAmtBox.Text);
                double r = double.Parse(interestRateBox.Text) / 100 / 12;
                double n = double.Parse(yearsBox.Text) * 12;
                double M = Math.Round(P * ((r * Math.Pow((1 + r), n)) / (Math.Pow((1 + r), n) - 1)), 2);
                monthPayLabel.Text = M.ToString("c");
                totalLoans = totalLoans + P;
                totalLoanLabel.Text = totalLoans.ToString("c");
                totalMonthPayment = totalMonthPayment + M;
                totalMonthPayLabel.Text = totalMonthPayment.ToString("c");
                averageMonthPayment = Math.Round(totalMonthPayment / count, 2);
                avgMonthPayLabel.Text = averageMonthPayment.ToString("c");
            }
            catch (Exception ex)
            {
                // shows an error message when numbers aren't put into boxes
                MessageBox.Show(ex.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // clears user input section
            loanAmtBox.Text = "";
            interestRateBox.Text = "";
            yearsBox.Text = "";
            monthPayLabel.Text = "";
            loanAmtBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void awesomeButton_Click(object sender, EventArgs e)
        {
            // shows my awesome text
            MessageBox.Show("Everything is awesome, when you're cwood19");
        }
    }
}
