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
    }
}
