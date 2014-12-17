using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace RESTDemo
{
    
    public class Service1 : IService1
    {

        List<OrdersDTO> GetOrders()
        {
            DataClasses1DataContext context = new DataClasses1DataContext();
            List<Order> orders = (from r in context.Orders select r).ToList();
            List<OrdersDTO> ordersDto = orders.ConvertAll
                (x => new OrdersDTO
                {
                    OrderDate = x.OrderDate,
                    OrderID = x.OrderID,
                    ShipCity = x.ShipCity,
                    ShipName = x.ShipName,
                    ShipPostalCode = x.ShipPostalCode
                });
            return ordersDto; 

        }



        public List<OrdersDTO> GetOrdersJSON()
        {
           return GetOrders();
        }

        public List<OrdersDTO> GetOrdersXML()
        {
            return GetOrders();
        }
    }
}
