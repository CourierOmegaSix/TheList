using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Web;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class Login
    {

        //path to Profiles text files (JE)
        private static string  path = (@"../../Login/Profiles.txt");

        //path to list path files
        private static string lpath = (@"../../Login/");


        //method used to store username/password into Profiles.txt (JE)
        public static void recordLogin(UserInfoVal wrote)
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
        public static Boolean searchLogin(string username, string password)
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

        public static void saveList(User u)
        {
            string userpath = (@"../../Login/" + u.UserInformation["userName"] + ".txt");
            string filepath = lpath + u.UserInformation["firstName"] + "Lists" + ".txt";

            string json = Newtonsoft.Json.JsonConvert.SerializeObject(u.Goals);
            string json2 = Newtonsoft.Json.JsonConvert.SerializeObject(u);
            if (!File.Exists(filepath))
            {
                var tw = new StreamWriter(filepath, false);

                tw.WriteLine(json.ToString());
                tw.Close();

                tw = new StreamWriter(userpath, false);

                tw.WriteLine(json2.ToString());
                tw.Close();

            }
            else
            {

                var tw = new StreamWriter(filepath, false);

                tw.WriteLine(json.ToString());
                tw.Close();

                tw = new StreamWriter(userpath, false);

                tw.WriteLine(json2.ToString());
                tw.Close();
                
            }

        }


        public static void loadList(User u)
        {
            //a temp linked list that will be used to override the users,(basically reseting the users Goals linked list)(JE)
            LinkedList<Goal> temp = new LinkedList<Goal>();

            string filepath = lpath + u.UserInformation["firstName"] + "Lists" + ".txt";
            string userpath = (@"../../Login/" + u.UserInformation["userName"] + ".txt");
            try
            {
                if (File.Exists(filepath))
                {
                    StreamReader reader = File.OpenText(filepath);
                    List<Goal> JsonArray;
                    JsonArray = JsonConvert.DeserializeObject<List<Goal>>(reader.ReadLine());
                    reader.Close();

                    foreach (Goal l in JsonArray)
                    {
                        //Console.WriteLine(l.GoalName);
                        temp.AddLast(l);
                    }
                    //Loading user( for the total funds)(JE)
                    u.Goals = temp;

                    reader = File.OpenText(userpath);
                    User JsonO;
                    JsonO = JsonConvert.DeserializeObject<User>(reader.ReadLine());
                    //Console.WriteLine(JsonO.SpendingFunds);
                    u.SpendingFunds = JsonO.SpendingFunds;
                    reader.Close();
                }
                else
                {
                    //should always be working(JE)
                    MessageBox.Show("No goals to load.");
                }
            }
            catch
            {
                MessageBox.Show("Error: File is empty.");
            }
        }
    }
}
