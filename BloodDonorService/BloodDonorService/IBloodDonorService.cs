using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace BloodDonorService
{
    [ServiceContract]
   public interface IBloodDonorService
    {
        [OperationContract]
       string GetTopDonor(string GroupName, int PinCode);
       void SomeInternaFunction();
    }
}
