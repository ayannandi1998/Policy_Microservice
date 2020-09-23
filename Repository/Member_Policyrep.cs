using Policy_Microservice.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Policy_Microservice.Repository
{
    public class Member_Policyrep
    {
        private static List<Member_Policy> MemberPol = new List<Member_Policy>
        {
            new Member_Policy{ PolicyName="PDummy1",PolicyID="P1",SubscriptionDate=new DateTime(2014,01,08), MemberID="M10",MemberName="Name1"},
            new Member_Policy{ PolicyName="PDummy2",PolicyID="P2",SubscriptionDate=new DateTime(2015,05,12), MemberID="M20",MemberName="Name2"  },
            new Member_Policy{ PolicyName="PDummy3",PolicyID="P3",SubscriptionDate=new DateTime(2016,08,15), MemberID="M30",MemberName="Name3"  }
        };
    }
}
