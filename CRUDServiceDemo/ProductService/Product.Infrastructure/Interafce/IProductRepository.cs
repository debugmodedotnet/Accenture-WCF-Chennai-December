using System;
using Product.DataLayer;
using System.Collections.Generic;
namespace Product.Infrastructure.Interafce
{
   public interface IProductRepository
    {
        bool AddProduct(StudyProduct p);
        StudyProduct GetProduct(int PId);
        List<StudyProduct> GetProducts();
    }
}
