using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace PerCallDemo
{
    [ServiceBehavior(InstanceContextMode= InstanceContextMode.PerSession)]
    public class Service1 : IService1, IDisposable
    {
        static int _counter = 0;
        public Service1()
        {
            _counter = _counter + 1; 
        }
        public int Counter()
        {
            return _counter; 
        }

        public void Dispose()
        {
           // _counter = _counter - 1; 
        }
    }
}
