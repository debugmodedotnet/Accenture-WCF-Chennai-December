using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.ServiceReference1;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Service1Client proxy = new Service1Client();
            proxy.Close();
            Console.WriteLine(proxy.Counter().ToString());
            Service1Client proxy1 = new Service1Client();
            Console.WriteLine(proxy1.Counter().ToString());
            Console.WriteLine(proxy.Counter().ToString());
           
            Console.WriteLine(proxy1.Counter().ToString());
            Console.ReadKey(true);
        }
    }
}
