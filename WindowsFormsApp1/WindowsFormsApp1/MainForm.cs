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
            //path to the folder to store usernames
            string folderPath = (@"C:\Users\Public\json");
            //path to the txt file for usernames
            string path = (@"C:\Users\Public\json\users.txt");
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
                //if folder path exist
                if (Directory.Exists(folderPath))
                {
                    this.Hide();
                    NewUser newUserJoin = new NewUser();

                    //uses the writeFolder function in Login.cs
                    login.writeFolder(login, path);

                    newUserJoin.ShowDialog();
                    this.Close();
                }
                //if folder doesn't exist will create it and do the same thing.
                else
                {

                    Directory.CreateDirectory(folderPath);

                    this.Hide();
                    NewUser newUserJoin = new NewUser();

                    login.writeFolder(login, path);


                    newUserJoin.ShowDialog();

                    this.Close();

                }
                
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
