using Policy_Microservice.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Policy_Microservice.Repository
{
    public class Provider_Policyrep : IPolicyrep
    {
        public static List<Provider_Policy> ProviderPol = new List<Provider_Policy>
        {
            new Provider_Policy{ PolicyID="P1", MemberID="M1",AmbulanceCharges=11000,MedicineCharges=2500,OperationCharges=150000,StayingCharges=20000,Hospitalname="Amri",HospitalID="H1",Location="Saltlake" },
            new Provider_Policy{ PolicyID="P2", MemberID="M2",AmbulanceCharges=12000,MedicineCharges=3500,OperationCharges=250000,StayingCharges=30000,Hospitalname="SSKM",HospitalID="H2",Location="Dum Dum" },
            new Provider_Policy{ PolicyID="P3", MemberID="M3",AmbulanceCharges=13000,MedicineCharges=4500,OperationCharges=350000,StayingCharges=40000,Hospitalname="ECO Hospital",HospitalID="H3",Location="Garia"}
        };

        public List<string> GetChainProvider(string pid)
        {
            
            var result = from p in ProviderPol where p.PolicyID==pid select p;
            List<string> ls = new List<string>();
            foreach(var id in result)
            {
                ls.Add(id.HospitalID);
                ls.Add(id.Hospitalname);
                ls.Add(id.Location);
            }
            return ls;

        }
        public List<int> GetEligibleBenefits(string mid,string pid)
        {
            var im = from p in ProviderPol where p.MemberID == mid select p;
            var result = from i in im where i.PolicyID == pid select i;
            List<int> ls = new List<int>();
            foreach (var id in result)
            {
                ls.Add(id.AmbulanceCharges);
                ls.Add(id.MedicineCharges);
                ls.Add(id.OperationCharges);
                ls.Add(id.StayingCharges);
            }
            return ls;

        }


    }
}
