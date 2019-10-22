using System;

namespace WindowsFormsApp1
{
    class Goal : IComparable<Goal>
    {
        // Fields
        private string goalName;
        private decimal estimatedGoalCost;
        private string optionalGoalDescription;

        // Properties
        public string GoalName { get; set; }
        public decimal EstimatedGoalCost { get; set; }
        public string OptionalGoalDescription { get; set; }

        // Constructor
        public Goal(string name, decimal cost)
        {
            GoalName = name;
            EstimatedGoalCost = cost;
        }

        public int CompareTo(Goal otherGoal)
        {
            if(this.EstimatedGoalCost == otherGoal.EstimatedGoalCost)
            {
                return 0;
            }

            if(this.EstimatedGoalCost < otherGoal.EstimatedGoalCost)
            {
                return -1;
            }

            else
            {
                return 1;
            }
        }
    }
}
