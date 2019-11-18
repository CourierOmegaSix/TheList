using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AddGoalForm : Form{

        User u;

        public AddGoalForm(User use){
            u = use;
            InitializeComponent();
        }

        private void addGoalButton_Click(object sender, EventArgs e){

            if (goalNameBox.Text != "" && goalCostBox.Text != ""){
                //The try/catch is only there so it doesn't crash when letters are entered in the goalcost(JE)
                try{
                    //Method adds a goal to the user objects array from the form before(JE)
                    u.AddGoal(goalNameBox.Text, goalCostBox.Text);
                    this.Close();
                }
                catch{
                    MessageBox.Show("Please only enter numbers for the goal cost.");
                    this.Close();
                }
            }
            else{
                MessageBox.Show("Please enter a Goal name and Goal Cost.");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e){
            this.Close();
        }
    }
}
