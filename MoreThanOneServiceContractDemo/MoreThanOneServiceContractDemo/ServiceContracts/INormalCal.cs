using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace MoreThanOneServiceContractDemo.ServiceContracts
{
    [ServiceContract]
   public interface INormalCal
    {
        [OperationContract(Name="AddInt")]
        int Add(int a, int b);
        [OperationContract(Name="AddString")]
        string Add(string a, string b);
    }
}
