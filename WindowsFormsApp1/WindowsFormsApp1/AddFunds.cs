using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AddFunds : Form
    {
        private User user;
        
        public AddFunds(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void AddFunds_ConfirmButton_Click(object sender, EventArgs e)
        {
            user.SpendingFunds = user.SpendingFunds + Convert.ToDecimal(AddFunds_UserInputTextbox.Text);
            this.Close();
        }

        private void AddFunds_CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
