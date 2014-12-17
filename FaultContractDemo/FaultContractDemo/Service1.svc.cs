using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace FaultContractDemo
{
  
    public class Service1 : IService1
    {

        public double Div(double a, double b)
        {
            if (b == 0)
            {
                MyException ex = new MyException();
                ex.myReason = "Second number can not be zero buddy :)";
                throw new FaultException<MyException>(ex, "hahahahah");
            }
            else
            {
                return a % b;
            }
        }
    }
}
