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
    public partial class AdministratorLogon : Form
    {
        public AdministratorLogon()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            // Can't figure out why this click event isn't working but it works in the second click event. It's exactly the same.
            if (userTextBox.Text == "Chris" && passwordTextBox.Text == "Wood")
            {
                Administrator login = new Administrator();
                login.Show();
            }
            else
            {
                MessageBox.Show("Invalid Login");
            }
        }

        private void AdministratorLogon_Load(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginButton_Click_1(object sender, EventArgs e)
        {
            if (userTextBox.Text == "Chris" && passwordTextBox.Text == "Wood")
            {
                Administrator login = new Administrator();
                login.Show();
            }
            else
            {
                MessageBox.Show("Invalid Login");
            }
        }
    }
}
