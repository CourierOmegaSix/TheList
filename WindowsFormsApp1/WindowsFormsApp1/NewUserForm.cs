using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Windows.Forms;
using System.IO;

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

            // User creation (CK)
            User user = new User();
            user.UserInformation.Add("firstName", fName);
            user.UserInformation.Add("lastName", lName);
            user.UserInformation.Add("address", address);
            user.UserInformation.Add("zipCode", zipCode);
            user.UserInformation.Add("dateOfBirth", dob.ToString());

            string path = (@"../../Login/" + userName + ".txt");
            string temp = JsonConvert.SerializeObject(user);
            using(StreamWriter streamWriter = new StreamWriter(path))
            {
                streamWriter.WriteLine(temp.ToString());
                streamWriter.Close();
            }

            this.Hide();
            UserHome userHome = new UserHome(user);
            userHome.ShowDialog();
            this.Close();

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
    }
}
