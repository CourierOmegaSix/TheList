using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LoadList : Form
    {
        User user;

        public LoadList(User use)
        {
            InitializeComponent();
            user = use;
            populateList();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Load_Click(object sender, EventArgs e)
        {
            Console.WriteLine(listBox1.SelectedItem.ToString());

            //Adds the .txt back into the selected List items, then passed into the method(JE)
            Login.loadList(user, (listBox1.SelectedItem.ToString() + ".txt"));
            this.Close();
        }
        private void populateList()
        {
            string folderpath = @"../../Login/" + user.UserInformation["firstName"] + "Lists";

            DirectoryInfo folder = new DirectoryInfo(folderpath);
            FileInfo[] nameArray = folder.GetFiles();

            foreach(FileInfo file in nameArray)
            {
                //removes the path and file extension from the List .txt file(JE)
                listBox1.Items.Add(Path.GetFileNameWithoutExtension(file.Name));
            }

        }
    }
}
