using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Web;

namespace WindowsFormsApp1
{
    public class Login
    {

        //path to Profiles.txt (JE)
        private static string  path = (@"../../Login/Profiles.txt");
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

        public static void saveList(LinkedList<Goal> g)
        {
            string name = lpath + "test.txt";

            string json = Newtonsoft.Json.JsonConvert.SerializeObject(g);

            using (var tw = new StreamWriter(name, true))
            {
                tw.WriteLine(json.ToString());
                tw.Close();
            }

        }
        public static void loadList(User u)
        {
            string finalpath = lpath + "test.txt";
            if (File.Exists(finalpath))
            {
                StreamReader reader = File.OpenText(finalpath);
                List<Goal> objects;
                objects = JsonConvert.DeserializeObject<List<Goal>>(reader.ReadLine());

                foreach(Goal l in objects){
                    Console.WriteLine(l.GoalName);
                    u.AddGoalList(l);
                }
                reader.Close();
                //while((line = reader.ReadLine()) != null)
                //{
                //    string[] split = line.Split('z');
                //    for (int i = 0; i < split.Length; i++)
                //    {
                        
                //        dynamic obj1 = Newtonsoft.Json.JsonConvert.DeserializeObject(split[i]);
                //        Goal gg = obj1 as Goal;
                //        Console.WriteLine(gg.GoalName);
                //        u.AddGoalList(gg);

                //    }
                //}

            }


        }
    }
}
