using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using DataContractDemo.Data;

namespace DataContractDemo
{
    public class Service1 :IProductService
    {

        //public List<Product> GetProducts()
        //{
        //    List<Product> p = new List<Product>()
        //    {
        //      new Product
        //    {
        //        Id = 1,
        //        Name = "Bat",
        //        //Price = 20.56
        //    },
        //    new Product
        //    {
        //        Id = 1,
        //        Name = "Bat",
        //      //  Price = 20.56
        //    }          
        //    };
        //    return p;
        //}




        public Product EchoProduct(Product p)
        {
            Product po = new Product
            {
                Id = 2,
                Name = p.Name,
                Price = p.Price
            };
            return po; 
        }

        //public ProductType EchoType(ProductType p)
        //{
        //    ProductType po = new ProductType
        //    {
        //        Id = 1,
        //        TypeName = p.TypeName
        //    };
        //    return po; 
        //}
    }
}
