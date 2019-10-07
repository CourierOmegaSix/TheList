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
            userName = n;
            password = p;           
        }
      
        private void submitButton_Click(object sender, EventArgs e)
        {
            String fName, lName, address, confirmPass;
            int zipCode;
            DateTime dob;

            fName = fNameBox.Text;
            lName = lNameBox.Text;
            address = addressBox.Text;
            confirmPass = confirmPassBox.Text;
            zipCode = int.Parse(zipcodeBox.Text);
            dob = dobBox.Value;







        }

        private void resetButton_Click(object sender, EventArgs e)
        {

        }
    }
}
