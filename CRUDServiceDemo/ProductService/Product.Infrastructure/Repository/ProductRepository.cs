using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Product.DataLayer;
using Product.Infrastructure.Interafce;
namespace Product.Infrastructure.Repository
{
    public class ProductRepository : IProductRepository
    {
        ProductEntities entities;
        public ProductRepository()
        {
            entities = new ProductEntities();
        }

        public bool AddProduct(StudyProduct p)
        {
            try
            {
                entities.StudyProducts.Add(p);
                entities.SaveChanges();
                return true;
            }
            catch
            {
                return false; 
            }
        }

        public StudyProduct GetProduct(int PId)
        {
            var product = (from r in entities.StudyProducts
                           where r.Id==PId select r).FirstOrDefault();
            return product;
        }

        public List<StudyProduct> GetProducts()
        {
            var products = from r in entities.StudyProducts select r;
            return products.ToList(); 
        }
    }
}