using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class UserHome : Form
    {
        private User user;
        public User User 
        {
            get
            {
                return this.user;
            }

            set
            {
                this.user = value;
            }
        }

        public UserHome(User user)
        {
            InitializeComponent();
            User = user;
            Console.WriteLine(User.UserInformation["firstName"]);
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

        private void AddGoal_Button_Click(object sender, EventArgs e)
        {

            //pulls up the AddGoalForm(JE)
            AddGoalForm AddGoalForm = new AddGoalForm(User);
            AddGoalForm.ShowDialog();

            RefreshBox();

        }

        private void RemoveGoal_Button_Click(object sender, EventArgs e)
        {

        }

        private void PrintList_Button_Click(object sender, EventArgs e)
        {

        }

        private void LoadList_Button_Click(object sender, EventArgs e)
        {

        }

        private void SaveList_Button_Click(object sender, EventArgs e)
        {

        }

        private void AddFunds_Button_Click(object sender, EventArgs e)
        {

        }
        private void RefreshBox()
        {
            //loops through the User.Goals linked array and adds each element to the list boxes(JE)
            Goal_ListBox.Items.Clear();
            Cost_ListBox.Items.Clear();
            int size = User.Goals.Count;
            for (int i = 0; i < size; i++){
                Goal_ListBox.Items.Add(User.Goals.ElementAt(i).GoalName);
                Cost_ListBox.Items.Add(User.Goals.ElementAt(i).EstimatedGoalCost + "$");
            }
            
        }

        private void SpendingFunds_Label_Click(object sender, EventArgs e)
        {

        }

        private void Cost_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
