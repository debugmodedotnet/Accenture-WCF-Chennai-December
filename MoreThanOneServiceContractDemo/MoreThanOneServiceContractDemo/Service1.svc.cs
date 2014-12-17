using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using MoreThanOneServiceContractDemo.ServiceContracts;

namespace MoreThanOneServiceContractDemo
{

    public class Service1 : INormalCal , IBankCal
    {

        public int Add(int a, int b)
        {
            return a + b; 
        }

        public string Add(string a, string b)
        {
            return a + b; 
        }

        public double GetBalanace(string accountid)
        {
            return 2000; 
        }
    }  
}
