using Product.DataLayer;
using Product.Infrastructure.Interafce;
using Product.Infrastructure.Repository;
using ProductService.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ProductService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 :IProductsCRUDService
    {

        public List<DTO.StudyProductDTO> GetAllProducts()
        {
            IProductRepository repo = new ProductRepository();
            var result = repo.GetProducts();
            var result1 = ConverterDTO.ListStudyProducttoStudyProductDTO(result.ToList());
            return result1; 
        }

        public DTO.StudyProductDTO GetProduct(int ProductId)
        {
            IProductRepository repo = new ProductRepository();
            var result = repo.GetProduct(ProductId);
            var result1 = ConverterDTO.StudyProducttoStudyProductDTO(result);
            return result1; 
        }

        public bool AddProduct(DTO.StudyProductDTO Product)
        {
            IProductRepository repo = new ProductRepository();
            StudyProduct p = ConverterDTO.StudyProductDTOtoStudyProduct(Product);
            p.Id = 9;
            var result = repo.AddProduct(p);
            
            return result; 
        }
    }
}
