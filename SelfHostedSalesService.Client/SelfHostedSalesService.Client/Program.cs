using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SelfHostedSalesService.Client.ServiceReference1;

namespace SelfHostedSalesService.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            SalesServiceClient proxy = new SalesServiceClient("tep");
            var result = proxy.GetNameofSalesMen();
            foreach(var r in result)
            {
                Console.WriteLine(r);
            }
            Console.ReadKey(true);
        }
    }
}
