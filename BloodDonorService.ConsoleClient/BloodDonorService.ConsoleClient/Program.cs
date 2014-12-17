using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BloodDonorService.ConsoleClient.ServiceReference1;

namespace BloodDonorService.ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            BloodDonorServiceClient client = new BloodDonorServiceClient("ep1");
            var result = client.GetTopDonor("A+", 831003);
            Console.WriteLine(result);
            Console.ReadKey(true);
        }
    }
}
