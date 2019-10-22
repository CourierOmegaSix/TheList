using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WindowsFormsApp1
{
    [DataContract]
    class User
    {
        // Fields
        [DataMember] protected LinkedList<Goal> goals;
        [DataMember] protected decimal spendingFunds;

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
