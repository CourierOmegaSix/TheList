﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WindowsFormsApp1
{
    [DataContract]
    public class User
    {
        // Fields
        [DataMember] protected Dictionary<string, string> userInformation;
        [DataMember] protected LinkedList<Goal> goals;
        [DataMember] protected decimal spendingFunds;

        // Properties
        public Dictionary<string, string> UserInformation
        {
            get
            {
                return this.userInformation;
            }
        }
        public LinkedList<Goal> Goals { get; }
        public decimal SpendingFunds
        {
            get
            {
                return this.spendingFunds;
            }

            set
            {
                this.spendingFunds = this.spendingFunds + value;
            }
        }

        // Constructor
        public User()
        {
            userInformation = new Dictionary<string, string>();
            Goals = new LinkedList<Goal>();
            SpendingFunds = 0.00M;
        }

        //method to add to the goals array(JE)
        public void AddGoal(string name, string price)
        {
            int p = Int32.Parse(price);
            Goal g = new Goal(name, p);
            this.Goals.AddLast(g);
        }
    }
}
