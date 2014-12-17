using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace RESTDemo
{
    
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        [WebGet(UriTemplate = "/GetOrdersJson",
            RequestFormat=WebMessageFormat.Json,
            ResponseFormat=WebMessageFormat.Json)]
        List<OrdersDTO> GetOrdersJSON();


        [OperationContract]
        [WebGet(UriTemplate = "/GetOrdersXml",
            RequestFormat = WebMessageFormat.Xml,
            ResponseFormat = WebMessageFormat.Xml)]
        List<OrdersDTO> GetOrdersXML();
     
    }


}
