﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class RemoveGoalForm : Form
    {
        public User user;
        public Goal rgoal;
        public RemoveGoalForm(User u, Goal g)
        {
            InitializeComponent();
            user = u;
            rgoal = g;
        }

        private void removeGoalButton_Click(object sender, EventArgs e)
        {

            user.RemoveGoal(rgoal);
            this.Close();

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
