using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace BloodDonorService
{
  
    public class Service1 : IBloodDonorService 
    {
        public string GetTopDonor(string GroupName, int PinCode)
        {
            var donorName = "V V S Laxman";
            var result = donorName + " with blood group " + GroupName + " is top donor in area " + PinCode;
            return result; 
        }

        public void SomeInternaFunction()
        {
            // No implemented 
        }
    }
}
