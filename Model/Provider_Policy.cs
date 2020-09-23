using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Policy_Microservice.Model
{
    public class Provider_Policy
    {
        public string HospitalID { get; set; }
       
        public string PolicyID { get; set; }
        public string MemberID { get; set; }
        public int AmbulanceCharges { get; set; }
        public int MedicineCharges { get; set; }
        public int OperationCharges { get; set; }
        public int StayingCharges { get; set; }
        public string Hospitalname { get; set; }
        public string Location { get; set; }
    }
}
