using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using ProductService.DTO;

namespace ProductService
{
    [ServiceContract]
   public interface IProductsCRUDService
    {
        [OperationContract]
        List<StudyProductDTO> GetAllProducts();
        [OperationContract]
        StudyProductDTO GetProduct(int ProductId);
        [OperationContract]
        bool AddProduct(StudyProductDTO Product);
    }
}
