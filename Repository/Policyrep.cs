using Policy_Microservice.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Policy_Microservice.Repository
{
    public class Policyrep 
    {
        private static List<Policy> Pol = new List<Policy>
        {
            new Policy{ PolicyName="PDummy1",PolicyID="P1",PremiumAmmountDue=10000,Tenure=2, MemberID="M1"  },
            new Policy{ PolicyName="PDummy2",PolicyID="P2",PremiumAmmountDue=20000,Tenure=4, MemberID="M2"  },
            new Policy{ PolicyName="PDummy3",PolicyID="P3",PremiumAmmountDue=30000,Tenure=5, MemberID="M3"  }
        };

        public List<Provider_Policy> GetEligibleClaimAmount(string pid, string mid)
        {
            throw new NotImplementedException();
        }
    }
    
}
