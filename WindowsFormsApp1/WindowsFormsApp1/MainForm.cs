using System;
using System.Collections;
using Logging;
using Newtonsoft;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class UserInfo : Form
    {
        UserInfoVal infoVal;
        Login login;
        ArrayList names = new ArrayList();

        public UserInfo()
        {
            InitializeComponent();          
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
 
            String userName = usrName.Text;
            String passWord = pass.Text;

            infoVal = new UserInfoVal(userName, passWord);

            login = new Login(userName, passWord);
            Login logincheck = login.JsonLogin(userName, passWord);

            Console.WriteLine(logincheck.userName);
            //if username and password match and rows of Profiles.txt then logincheck.userName wont be null
            //and if it's not null, will then sate it found a match and load the next window.
            if (logincheck.userName != null)
            {
                MessageBox.Show("Profile found!\n" + "Logging in as: " + logincheck.userName);
                this.Hide();
                UserHome homePage = new UserHome();
                homePage.ShowDialog();
                //Error message Disposable object created by 'new UserHome() is never disposed  //Add dispose method 10/16
                //homePage.Dispose();
                this.Close();
                //homePage.Dispose();
            }
        }

        private void JoinButton_Click(object sender, EventArgs e)
        {
            String userName = usrName.Text;
            String passWord = pass.Text;
            bool userValid;
            bool passValid;

            login = new Login(userName, passWord);

            //Create new instance of UserInfoVal, pass in user info, then check username and password.
            infoVal = new UserInfoVal(userName, passWord);
            userValid = infoVal.UsernameCheck();
            passValid = infoVal.PassCheck();

            //If valid hide main form and create newUser form.
            if(userValid && passValid)
            {
                this.Hide();
                NewUserForm userJoin = new NewUserForm(userName, passWord);
                login.WriteFolder(login);
                userJoin.ShowDialog();
                this.Close();
            }
                
        }
        

        private void UserInfo_Load(object sender, EventArgs e)
        {

        }

        private void UsrName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void infoGroup_Enter(object sender, EventArgs e)
        {

        }
    }
}
