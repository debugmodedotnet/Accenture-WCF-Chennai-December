using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.ServiceReference1;
using System.ServiceModel;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {

            Service1Client p = new Service1Client();
            try
            {
                var result = p.Div(45, 10);
                var salary = result + 20;
                Console.WriteLine(result);
                Console.WriteLine(salary);
            }
            catch(FaultException<MyException> e)
            {
                Console.WriteLine(e.Detail.myReason);
                Console.WriteLine(e.Reason);
            }
            Console.ReadKey(true);

        }
    }
}
