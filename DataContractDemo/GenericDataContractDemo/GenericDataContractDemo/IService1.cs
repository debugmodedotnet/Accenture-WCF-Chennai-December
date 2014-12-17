using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace GenericDataContractDemo
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        Parent  GetParent(Parent p);

        
    }


 [DataContract]
    public class Parent
    {
     [DataMember]
        public string  Name { get; set; }
    }

    [DataContract]
   // [KnownType(typeof(Parent))]
    public class Child
    {
        [DataMember]
        public string CName { get; set; }
    }
}
