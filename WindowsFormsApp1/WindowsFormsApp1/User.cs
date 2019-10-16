using System.Collections.Generic;

namespace WindowsFormsApp1
{
    class User
    {
        // Fields
        protected LinkedList<Goal> goals;
        protected decimal spendingFunds;

        // Properties
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
            Goals = new LinkedList<Goal>();
            SpendingFunds = 0.00M;
        }
    }
}
