using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Product.Infrastructure.Interafce;
using Product.Infrastructure.Repository;

namespace Product.Test
{
    [TestClass]
    public class ProductRepositoryShould
    {
        IProductRepository repo;
        private int _productCount = 2; 
        [TestInitialize]
        public void TestSetup()
        {
            repo = new ProductRepository();
        }
        [TestMethod]
        public void ReturnListOfProducts()
        {

            var resultCount = repo.GetProducts().Count;
            Assert.AreEqual(_productCount, resultCount);
        }
    }
}
