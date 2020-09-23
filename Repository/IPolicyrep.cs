using Policy_Microservice.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Policy_Microservice.Repository
{
    public interface IPolicyrep
    {
        public List<string> GetChainProvider(string pid);
        public List<int> GetEligibleBenefits(string mid,string pid);

    }
}
