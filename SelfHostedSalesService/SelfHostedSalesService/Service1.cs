using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SelfHostedSalesService
{
    
    public class Service1 : ISalesService
    {
        public List<string> GetNameofSalesMen()
        {
            List<string> lstSalesMen = new List<string>()
            {
                "Foo", "Moo", "Koo"
            };
            return lstSalesMen;
        }
    }
}
