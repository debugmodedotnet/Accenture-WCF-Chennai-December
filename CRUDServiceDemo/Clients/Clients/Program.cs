using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clients.ServiceReference1;

namespace Clients
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductsCRUDServiceClient p = new ProductsCRUDServiceClient();
            StudyProductDTO produttoadd = new StudyProductDTO
            {
                ProductName = "Bat",
                ProductPrice = 346,
                ProductType = "Sport"
            };
          var result=  p.AddProduct(produttoadd);
          Console.WriteLine(result);

            //var result = p.GetAllProducts();
            //foreach(var r in result)
            //{
            //    Console.WriteLine(r.ProductName + " " + r.ProductPrice + " " + r.ProductType);
            //}

            Console.ReadKey(true);
        }
    }
}
