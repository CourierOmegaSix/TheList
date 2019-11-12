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

        //name is returned from SaveList form, which will be the file name(JE)
        public static void saveList(User u, string name)
        {
            //Designated foler the saved lists will be stored(JE)
            string folderpath = lpath + u.UserInformation["firstName"] + "Lists";

            //Naming the list file based on user input(JE)
            string filepath = folderpath + "/" + name + ".txt";

            //if folder doesn't exist it will create it(JE)
            if (Directory.Exists(folderpath))
            {
                //if file path doesn't exist(JE)
                if (!File.Exists(filepath))
                {
                    string json = Newtonsoft.Json.JsonConvert.SerializeObject(u.Goals);
                    using (var tw = new StreamWriter(filepath, true))
                    {
                        tw.WriteLine(json.ToString());
                        tw.Close();
                    }
                }
                //if there is already a list with the name the user entered(JE)
                else
                {
                    MessageBox.Show("File name already exist.");
                }
            }
            else
            {
                Directory.CreateDirectory(folderpath);
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(u.Goals);
                using (var tw = new StreamWriter(filepath, true))
                {
                    tw.WriteLine(json.ToString());
                    tw.Close();
                }
            }

        }
        //file name is returned from loadList, which is the name of the txt file the user selected(JE)
        public static void loadList(User u, string fileName)
        {
            //a temp linked list that will be used to override the users,(basically reseting the users Goals linked list)(JE)
            LinkedList<Goal> temp = new LinkedList<Goal>();

            string folderpath = lpath + u.UserInformation["firstName"] + "Lists";
            string finalpath = folderpath + "/" + fileName;
            if (File.Exists(finalpath))
            {
                StreamReader reader = File.OpenText(finalpath);
                List<Goal> objects;
                objects = JsonConvert.DeserializeObject<List<Goal>>(reader.ReadLine());
                reader.Close();

                foreach (Goal l in objects)
                {
                    Console.WriteLine(l.GoalName);
                    temp.AddLast(l);

                }
                u.Goals = temp;

            }
            else
            {
                //should always be working(JE)
                Console.WriteLine("FILE DOES NNOT EXISTST!!!");
            }


        }
    }
}
