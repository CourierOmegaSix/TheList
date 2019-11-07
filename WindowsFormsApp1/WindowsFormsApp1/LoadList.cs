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

            Login.loadList(user, listBox1.SelectedItem.ToString());
            this.Close();
        }
        private void populateList()
        {
            string folderpath = @"../../Login/" + user.UserInformation["firstName"] + "Lists";
            DirectoryInfo folder = new DirectoryInfo(folderpath);
            FileInfo[] nameArray = folder.GetFiles();
            //string[] nameArray = Directory.GetFiles(folderpath);

            foreach(FileInfo file in nameArray)
            {
                listBox1.Items.Add(file.Name);
            }

        }
    }
}
