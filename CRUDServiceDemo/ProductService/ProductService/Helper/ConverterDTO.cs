using Product.DataLayer;
using ProductService.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductService.Helper
{
    public static class ConverterDTO
    {
        public static StudyProduct StudyProductDTOtoStudyProduct(StudyProductDTO d)
        {

            StudyProduct p = new StudyProduct
            {
                Name = d.ProductName,
                Price = d.ProductPrice,
                Type = d.ProductType
            };
            return p; 
        }

        public static StudyProductDTO StudyProducttoStudyProductDTO(StudyProduct d)
        {

            StudyProductDTO p = new StudyProductDTO
            {
                ProductName = d.Name,
                ProductPrice = d.Price,
                ProductType =d.Type
            };
            return p;
        }

        public static List<StudyProductDTO> ListStudyProducttoStudyProductDTO(List<StudyProduct> d)
        {

            //List<StudyProductDTO> p = new List<StudyProductDTO>
            //{
            //    ProductName = d.Name,
            //    ProductPrice = d.Price,
            //    ProductType = d.Type
            //};
            //return p;

            List<StudyProductDTO> lstStudyProuductDTO = d.ConvertAll(x => new StudyProductDTO
            {
                ProductName = x.Name,
                ProductType =x.Type,
                ProductPrice=x.Price
            });

            return lstStudyProuductDTO;
        }
    }
}