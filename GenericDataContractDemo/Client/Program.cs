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
            Service1Client p = new Service1Client();
            FooOfstring foo = p.GetFoo();
            Console.WriteLine(foo.Name + foo.Age);
            Console.ReadKey(true);
        }
    }
}
