using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace MoreThanOneServiceContractDemo.ServiceContracts
{
    [ServiceContract]
  public interface IBankCal
    {
        [OperationContract]
        double GetBalanace(string accountid);
    }
}
