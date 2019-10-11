using System;
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
        string path = (@"../../Login/Profiles.txt");

        public Login(string u, string p)
        {
            this.userName = u;
            this.passWord = p;
        }

        public string returnName()
        {
            return this.userName;
        }
        
        public string returnpassWord()
        {
            return this.passWord;
        }

        public void writeFolder(object wrote)
        {
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(wrote);
            using (var tw = new StreamWriter(path, true))
            {
                tw.WriteLine(json.ToString());
                tw.Close();
            }

            //MessageBox.Show(json);
        }

    }
}
