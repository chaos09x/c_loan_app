using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project9A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if(userTextBox.Text == "Chris" && passwordTextBox.Text == "Wood")
            {
                Form2 login = new Form2();
                login.Show();
            }
            else
            {
                MessageBox.Show("Invalid Login");
            }
        }
    }
}
