using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace RESTDemo
{
    [DataContract]
    public class OrdersDTO
    {
        [DataMember]
        public int OrderID;

        [DataMember]
        public DateTime? OrderDate;

        [DataMember]
        public string ShipName;

        [DataMember]
        public string ShipCity;

        [DataMember]

        public string ShipPostalCode;
        [DataMember]

         string _ShipCountry;
    }
}