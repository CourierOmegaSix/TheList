using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Newtonsoft.Json;

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
            RefreshBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserInfo f1 = new UserInfo();
            f1.ShowDialog();
            this.Close();
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
            //if an item is selxted in the list box(JE)
            if (Goal_ListBox.SelectedIndex != -1) {

                //g is set as the goal object that was selected(JE)
                Goal g = User.Goals.ElementAt(Goal_ListBox.SelectedIndex);

                //opens remove goal winform and passes the user and g into it(JE)
                RemoveGoalForm RemoveGoal = new RemoveGoalForm(User,g);
                RemoveGoal.ShowDialog();


                RefreshBox();
            }
            else
            {
                MessageBox.Show("Must selected a goal to remove. ", "Error");
            }

        }

        private void PrintList_Button_Click(object sender, EventArgs e)
        {
            LinkedList<Goal> toPrint = User.GetPossibleGoals();

            Document document = new Document(PageSize.A4, 25, 25, 30, 30);
            FileStream fileStream = new FileStream(@"../../Lists/" + User.UserInformation["firstName"] + ".pdf", FileMode.Create);

            PdfWriter writer = PdfWriter.GetInstance(document, fileStream);
            document.Open();

            document.Add(new Paragraph("Optimized List - " + DateTime.Today));

            foreach(Goal g in toPrint)
            {
                document.Add(new Paragraph(g.ToString() + " [Amount Spent]: _______________"));
            }

            document.Close();
            writer.Close();
            fileStream.Close();

            MessageBox.Show("Printed!");
        }

        private void LoadList_Button_Click(object sender, EventArgs e)
        {
            LoadList loadlist = new LoadList(User);
            loadlist.ShowDialog();

            RefreshBox();
        }

        private void SaveList_Button_Click(object sender, EventArgs e)
        {
            SaveList savelist = new SaveList(User);
            savelist.ShowDialog();

            RefreshBox();
        }

        private void AddFunds_Button_Click(object sender, EventArgs e)
        {

        }
        private void RefreshBox()
        {
            //loops through the User.Goals linked array and adds each element to the list boxes(JE)
            Goal_ListBox.Items.Clear();
            Cost_ListBox.Items.Clear();

            // Sorting of the list (CK)
            List<Goal> temp = User.Goals.ToList();
            temp.Sort();
            User.Goals.Clear();

            foreach(Goal g in temp)
            {
                User.Goals.AddLast(g);
            }

            int size = User.Goals.Count;
            for (int i = 0; i < size; i++){
                Goal_ListBox.Items.Add(User.Goals.ElementAt(i).GoalName);
                Cost_ListBox.Items.Add("$" + User.Goals.ElementAt(i).EstimatedGoalCost.ToString("0.00"));
            }

            SpendingFunds_Label.Text = "$" + User.SpendingFunds.ToString();
            
        }

        private void SpendingFunds_Label_Click(object sender, EventArgs e)
        {

        }

        private void Cost_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
