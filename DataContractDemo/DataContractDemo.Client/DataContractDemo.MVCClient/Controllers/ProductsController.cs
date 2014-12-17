using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataContractDemo.MVCClient.ServiceReference1;

namespace DataContractDemo.MVCClient.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            ProductServiceClient client = new ProductServiceClient();
            var result = client.GetProduct().ToList();
            return View(result);
        }
    }
}