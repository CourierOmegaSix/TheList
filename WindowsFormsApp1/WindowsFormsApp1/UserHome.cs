using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class UserHome : Form
    {
        private User user;
        public User User { get; set; }

        public UserHome(User user)
        {
            InitializeComponent();
            User = user;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserInfo f1 = new UserInfo();
            f1.ShowDialog();
            this.Close();
        }

        private void UserHome_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Goal_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
