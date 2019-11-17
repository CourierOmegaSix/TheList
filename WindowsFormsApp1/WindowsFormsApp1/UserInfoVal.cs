using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApp1{
    public class UserInfoVal{
        //Fields
        const int MIN_LENGTH = 8;
        const int MAX_LENGTH = 15;
        public String UserName { get; set; }
        public String Password { get; set; }

        //Constructor
        public UserInfoVal(String n, String p){
            UserName = n;
            Password = p;
        }

        public bool UsernameCheck(){
            bool isValid = false;

            if (string.IsNullOrWhiteSpace(UserName)){
                MessageBox.Show("Please enter a valid Username!");
                isValid = false;
            }
            else{
                isValid = true;
            }
            return isValid;
        }
        //Password must be 8-15 characters long including 1 uppercase letter, 1 special character, and alphanumeric characters
        //Special characters include !@#$%^&*()
        public bool PassCheck(){

            bool isValid;

            Regex hasNum = new Regex(@"[0-9]+");
            Regex hasUpper = new Regex(@"[A-Z]+");
            Regex hasLower = new Regex(@"[a-z]+");
            Regex hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

            if (Password == "" || Password == null){
                MessageBox.Show("Password is required!");
                isValid = false;
            }
            else if (Password.Length < MIN_LENGTH || Password.Length > MAX_LENGTH){
                MessageBox.Show("Password must be between 8-15 characters long.");
                isValid = false;
            }
            else if (!hasNum.IsMatch(Password)){
                MessageBox.Show("Password must contain at least one number!");
                isValid = false;
            }
            else if (!hasUpper.IsMatch(Password)){
                MessageBox.Show("Password must contain at least one uppercase letter!");
                isValid = false;
            }
            else if (!hasSymbols.IsMatch(Password)){
                MessageBox.Show("Password must contain at least one special character!");
                isValid = false;
            }
            else if (!hasLower.IsMatch(Password)){
                MessageBox.Show("Password must contain at least one lowercase letter!");
                isValid = false;
            }
            else{
                MessageBox.Show("Congrats your Password is valid!");
                isValid = true;
            }
            return isValid;
        }
    }
}
