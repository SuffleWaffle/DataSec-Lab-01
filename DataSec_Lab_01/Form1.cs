using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataSec_Lab_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void signinButton_Click(object sender, EventArgs e)
        {
            if(usernameTextBox.Text == "admin" && passwordTextBox.Text == "qwerty1234")
            {
                MessageBox.Show(
                    String.Format(
                        "\tSTATUS: ACCESS GRANTED\n\nINFO: Authorization complete. Welcome back {0}!", 
                        usernameTextBox.Text
                        )
                    );
                signinStatLabel.BackColor = Color.Green;
            }
            else
            {
                MessageBox.Show("\tSTATUS: ACCESS DENIED\n\nINFO: Incorrect username or password.");
                signinStatLabel.BackColor = Color.Red;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
