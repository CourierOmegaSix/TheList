﻿using System;
using System.Collections;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WindowsFormsApp1{
    public partial class UserInfo : Form
    {
        UserInfoVal infoVal;
        Login login;
        ArrayList names = new ArrayList();
        Boolean logincheck; // Moved here so I could add in a simple check to make sure an account doesn't already exist (CK)

        public UserInfo(){
            InitializeComponent();          
        }

        private void SignInButton_Click(object sender, EventArgs e){
            String userName = usrName.Text;
            String passWord = pass.Text;

            infoVal = new UserInfoVal(userName, passWord);

            logincheck = Login.searchLogin(userName, passWord);

            if (logincheck == true){
                User user = JsonConvert.DeserializeObject<User>(File.ReadAllText(@"../../Login/" + userName + ".txt"));
                MessageBox.Show("Profile found!\n" + "Logging in as: " + userName,"Sucess");
                this.Hide();

                //Error message Disposable object created by 'new UserHome() is never disposed. Include dispose() method or wrap in using statement? (KJ)
                UserHome homePage = new UserHome(user);
                homePage.ShowDialog();                
                this.Close();
                homePage.Dispose();
            }
            else if(userName == "" && passWord == ""){
                MessageBox.Show("Please enter a UserName and PassWord.");
            }
            else if(userName == ""){
                MessageBox.Show("Please enter the UserName.");
            }
            else if(passWord == ""){
                MessageBox.Show("Please enter the PassWord.");
            }
            else{
                MessageBox.Show("Profile not found.", "Error");
            }
        }

        private void JoinButton_Click(object sender, EventArgs e){
            String userName = usrName.Text;
            String passWord = pass.Text;
            logincheck = Login.searchLogin(userName, passWord);
            bool userValid;
            bool passValid;

            //Create new instance of UserInfoVal, pass in user info, then check username and password.
            infoVal = new UserInfoVal(userName, passWord);
            userValid = infoVal.UsernameCheck();
            passValid = infoVal.PassCheck();

            //If valid hide main form and create newUser form.
            // + Checks to insure no duplicate accounts are created.
            if(userValid && passValid && logincheck != true){
                this.Hide();
                NewUserForm userJoin = new NewUserForm(userName, passWord);
                Login.recordLogin(infoVal);
                userJoin.ShowDialog();
                this.Close();
            }

            else
            {
                MessageBox.Show("Error! Account already exists.");
            }
        }

        private void infoGroup_Enter(object sender, EventArgs e)
        {

        }
    }
}
