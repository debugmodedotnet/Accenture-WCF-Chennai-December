using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace DataContractDemo.Data
{
    [DataContract]
    public class Product
    {
        public int Id { get; set; }
        [DataMember]
        public string  Name { get; set; }
        [DataMember]
        public double Price { get; set; }

        [OnDeserialized]
        void SetDefaultValue(StreamingContext context)
        {
            if (Price == 0 || Price == 98789)
             {
                Price = 100;
            }
        }

        [OnDeserialized]

        void DoFun(StreamingContext context)
        {
            Price = 98789;
        }
    }
    //[DataContract]
    //public class ProductType
    //{

    //    public int Id { get; set; }
    //    [DataMember]
    //    public string  TypeName { get; set; }
    //    [DataMember(IsRequired=true)]
    //    public double Price { get; set; }
    //}
}