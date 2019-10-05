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
    public partial class userInfo : Form
    {
        UserInfoVal infoVal;

        public userInfo()
        {
            InitializeComponent();          
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
 
            String userName = usrName.Text;
            String passWord = pass.Text;
            bool userValid;
            bool passValid;

            //Create new instance of UserInfoVal, pass in user info, then check username and password.
            infoVal = new UserInfoVal(userName, passWord);
            userValid = infoVal.UsernameCheck();
            passValid = infoVal.PassCheck();

            if(!userValid || !passValid){}
            else{
                //If valid hide main form and create UserHome form. 
                this.Hide();
                UserHome homePage = new UserHome();
                homePage.ShowDialog();
                this.Close();
            }                       
        }

        private void JoinButton_Click(object sender, EventArgs e)
        {
            String userName = usrName.Text;
            String passWord = pass.Text;
            bool userValid;
            bool passValid;

            //Create new instance of UserInfoVal, pass in user info, then check username and password.
            infoVal = new UserInfoVal(userName, passWord);
            userValid = infoVal.UsernameCheck();
            passValid = infoVal.PassCheck();

            //If valid hide main form and create newUser form.
            if (!userValid || !passValid) { }
            else{
                this.Hide();
                NewUser newUserJoin = new NewUser();
                newUserJoin.ShowDialog();
                this.Close();
            }
        }
    }
}
