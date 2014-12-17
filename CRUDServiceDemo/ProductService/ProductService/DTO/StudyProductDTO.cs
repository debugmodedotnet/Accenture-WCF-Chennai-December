using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace ProductService.DTO
{
    [DataContract]
    public class StudyProductDTO
    {
        [DataMember]
        public string ProductName { get; set; }
        [DataMember]
        public decimal ProductPrice { get; set; }
        [DataMember]
        public string ProductType { get; set; }
    }
}