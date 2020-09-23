using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Policy_Microservice.Model
{
    public class Member_Policy
    {
        public string PolicyName { get; set; }
        public string PolicyID { get; set; }
        public DateTime SubscriptionDate { get; set; }
        public string MemberID { get; set; }
        public string MemberName { get; set; }

    }
}
