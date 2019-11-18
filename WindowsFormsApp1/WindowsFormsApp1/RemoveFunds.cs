using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class RemoveFunds : Form{
        private User user;

        public RemoveFunds(User user){
            InitializeComponent();
            this.user = user;
        }

        private void RemoveFunds_CancelButton_Click(object sender, EventArgs e){
            this.Close();
        }

        private void RemoveFunds_ConfirmButton_Click(object sender, EventArgs e){
            user.SpendingFunds = user.SpendingFunds - Convert.ToDecimal(RemoveFunds_UserInputTextbox.Text);
            this.Close();
        }
    }
}
