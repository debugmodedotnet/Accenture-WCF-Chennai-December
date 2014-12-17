using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace SelfHostedSalesService
{
    [ServiceContract]
  public  interface ISalesService
    {
        [OperationContract]
        List<string> GetNameofSalesMen();
    }
}
