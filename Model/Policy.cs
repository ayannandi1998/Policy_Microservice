using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Policy_Microservice.Model
{
    public class Policy
    {
        public string PolicyName { get; set; }
        public string PolicyID { get; set; }
        public int PremiumAmmountDue { get; set; }
        public int Tenure { get; set; }
        public string MemberID { get; set; }
    }
}
