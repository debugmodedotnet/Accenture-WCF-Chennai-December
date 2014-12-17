using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using DataContractDemo.Data;

namespace DataContractDemo
{
    [ServiceContract]
    public interface IProductService
    {
       // [OperationContract]
     //  List<Product> GetProducts();

        [OperationContract]
        Product EchoProduct(Product p);
       // [OperationContract]
       // ProductType EchoType(ProductType p);

    }
}
