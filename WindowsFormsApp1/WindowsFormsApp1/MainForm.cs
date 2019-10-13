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
    public partial class userInfo : Form
    {
        UserInfoVal infoVal;
        Login login;
        ArrayList names = new ArrayList();



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
                this.Close();
            }
        }

        private void JoinButton_Click(object sender, EventArgs e)
        {
            String userName = usrName.Text;
            String passWord = pass.Text;

            login = new Login(userName, passWord);
            


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

                    //uses the writeFolder function in Login.cs
                    login.writeFolder(login);
                    

                    newUserJoin.ShowDialog();
                    this.Close();
                }
                
            }
        

        private void userInfo_Load(object sender, EventArgs e)
        {

        }

        private void usrName_TextChanged(object sender, EventArgs e)
        {

        }

        private void pass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
