using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataContractDemo.Client.ServiceReference1;

namespace DataContractDemo.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductServiceClient client = new ProductServiceClient();
            //var result = client.GetProducts();
            //foreach (var p in result)
            //{
            //    Console.WriteLine(p.Name + " " + p.Price);
            //}

            Product p = new Product
            {
                Name = "Pencil",
               Price = 45.78
            };
            Product po = client.EchoProduct(p);
            Console.WriteLine(po.Name + " " + po.Price);


            //ProductType t = new ProductType
            //{
            //    TypeName = "Education",


            //};
            //ProductType to = client.EchoType(t);
            //Console.WriteLine(to.TypeName);

            Console.ReadKey(true);
        }
    }
}
