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
    public partial class MyBank : Form
    {
        public MyBank()
        {
            InitializeComponent();
        }

        private void aTMToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ATM page = new ATM();
            page.Show();
        }

        private void loanApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoanApplication page = new LoanApplication();
            page.Show();
        }

        private void mortgageCalculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MortgageCalculator page = new MortgageCalculator();
            page.Show();
        }

        private void administratorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AdministratorLogon login = new AdministratorLogon();
            login.Show();
        }
    }
}
