using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WindowsFormsApp1{

    [DataContract]
    public class User{
        // Fields
        [DataMember] protected Dictionary<string, string> userInformation;
        [DataMember] protected LinkedList<Goal> goals;
        [DataMember] protected decimal spendingFunds;

        // Properties
        public Dictionary<string, string> UserInformation{
            get{
                return this.userInformation;
            }
        }
        public LinkedList<Goal> Goals { get; set; }
        public decimal SpendingFunds{
            get{
                return this.spendingFunds;
            }
            set{
                this.spendingFunds = value;
            }
        }
        // Constructor
        public User(){
            userInformation = new Dictionary<string, string>();
            Goals = new LinkedList<Goal>();
            SpendingFunds = 0.00M;
        }

        //method to add to the goals array(JE)
        public void AddGoal(string name, string price){
            decimal p = decimal.Parse(price);
            Goal g = new Goal(name, p);
            this.Goals.AddLast(g);
        }
        public void AddGoalList(Goal g){
            Goals.AddFirst(g);
        }
        //method used to remove a goal, used in RemoveGoalForm(JE)
        public void RemoveGoal(Goal index){
            Goals.Remove(index);  
        }

        public LinkedList<Goal> GetPossibleGoals(){
            LinkedList<Goal> possibleGoals = new LinkedList<Goal>();
            decimal fundsToWorkWith = SpendingFunds;

            foreach(Goal g in this.Goals){
                if(g.EstimatedGoalCost <= fundsToWorkWith){
                    fundsToWorkWith -= g.EstimatedGoalCost;
                    possibleGoals.AddLast(g);
                }
            }
            return possibleGoals;
        }
    }
}
