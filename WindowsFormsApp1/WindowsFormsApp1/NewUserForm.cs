using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class NewUserForm : Form
    {
        String userName;
        String password;
        public NewUserForm(String n, String p)
        {         
            InitializeComponent();
            usernameBox.Text = n;
            passwordBox.Text = p;
            userName = n;
            password = p;           
        }
      
        private void SubmitButton_Click(object sender, EventArgs e)
        {

            String fName, lName, address, confirmPass, zipCode;
            DateTime dob;

            fName = fNameBox.Text;
            lName = lNameBox.Text;
            address = addressBox.Text;
            confirmPass = confirmPassBox.Text;
            zipCode = zipcodeBox.Text;
            dob = dobBox.Value;

            







        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            fNameBox.Text = "";
            lNameBox.Text = "";
            addressBox.Text = "";
            confirmPassBox.Text = "";
            zipcodeBox.Text = "";
            dobBox.Value = new System.DateTime(2019, 10, 5, 0, 0, 0, 0);

        }

        private void dobBox_ValueChanged(object sender, EventArgs e)
        {

        }

        private void newUserInfoGroup_Enter(object sender, EventArgs e)
        {

        }

        private void usernameBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
