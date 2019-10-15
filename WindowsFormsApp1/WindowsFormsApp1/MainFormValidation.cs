using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace WindowsFormsApp1
{
    class MainFormValidation{      

        //Fields
        const int MIN_LENGTH = 8;
        const int MAX_LENGTH = 15;
        public String UserName {get; set;}
        public String Password { get; set; }

        //Constructor
        public MainFormValidation(String n, String p){
            UserName = n;
            Password = p;
        }
                 
        public bool UsernameCheck(){           
            bool isValid = false;

            if (string.IsNullOrWhiteSpace(UserName)){
                MessageBox.Show("Please enter a valid Username!");
                isValid = false;
            } 
            else {
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

            if (Password == "" || Password == null || Password.Length == 0){ 
                MessageBox.Show("Password is required!");
                isValid = false;
                return isValid;

                if(Password.Length < 8 || Password.Length > 15){
                    MessageBox.Show("Not a valid password!");
                    isValid = false;
                    return isValid;
                }
            }
            else if (!hasNum.IsMatch(Password)) { MessageBox.Show("Password must contain at least one number!");
                isValid = false;
            }
            else if (!hasUpper.IsMatch(Password)) { MessageBox.Show("Password must contain at least one uppercase letter!");
                isValid = false; 
            }
            else if (!hasSymbols.IsMatch(Password)){ MessageBox.Show("Password must contain at least one special character!");
                isValid = false;
            }
            else if (!hasLower.IsMatch(Password)){ MessageBox.Show("Password must contain at least one lowercase letter!");
                isValid = false;
            }
            else { MessageBox.Show("Password is valid!");
                isValid = true;
            }
            return isValid;

            //****** Add code to check if user exist and if username and password match in database!! ******

        }

    }
}

