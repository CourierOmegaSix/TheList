using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Security.Cryptography;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logging
{
    class Login
    {
        public string userName;
        public string passWord;

        //path to Profiles.txt (JE)
        string path = (@"../../Login/Profiles.txt");


        public Login(string u, string p)
        {
            this.userName = u;
            this.passWord = p;
        }

        //method used to store username/password into Profiles.txt (JE)
        public void WriteFolder(Login wrote)
        {
            wrote.passWord = wrote.passWord.GetHashCode().ToString();

            string json = Newtonsoft.Json.JsonConvert.SerializeObject(wrote);
            using (var tw = new StreamWriter(path, true))
            {
                tw.WriteLine(json.ToString());
                tw.Close();
            }
        }

        //method used to search for matchin username and password (JE)
        public Login JsonLogin(string username, string password)
        {
            Login objic = new Login(null, null);


            string[] lines = File.ReadAllLines(path);
            //moves through line by line seeind if there is a match between Profiles.txt and the username/password (JE)
            foreach (string line in lines)
            {

                dynamic obj1 = Newtonsoft.Json.JsonConvert.DeserializeObject(line);

                if (obj1.userName == username && obj1.passWord == password)
                {
                    objic.userName = obj1.userName;
                    objic.passWord = obj1.passWord;

                    Console.WriteLine("working!!! YESSS~!!!!!");
                    return objic;
                }
            }
            return objic;
        }

    }
}
