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
    public class Login
    {
        //path to Profiles.txt (JE)
        private static string  path = (@"../../Login/Profiles.txt");


        //method used to store username/password into Profiles.txt (JE)
        public static void WriteFolder(UserInfoVal wrote)
        {
            //hashes the password (JE)
            wrote.Password = wrote.Password.GetHashCode().ToString();

            //Seriazlies the wrote object(UserInfoVal's UserName and Password) into a json string(JE)
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(wrote);

            using (var tw = new StreamWriter(path, true))
            {
                tw.WriteLine(json.ToString());
                tw.Close();
            }
        }

        //method used to search for matchin username and password (JE)
        public static Boolean JsonLogin(string username, string password)
        {
            //Hashes password before doing calculations(JE)
            string p = password.GetHashCode().ToString();


            string[] lines = File.ReadAllLines(path);
            //moves through line by line seeing if there is a match between Profiles.txt and the username/password (JE)
            foreach (string line in lines)
            {
                //Deserialzes the line in the text file back into the UserInfoVal Object (JE)
                dynamic obj1 = Newtonsoft.Json.JsonConvert.DeserializeObject(line);

                if (obj1.UserName == username && obj1.Password == p)
                {
                    return true;
                }
            }
            return false ;
        }
    }
}
