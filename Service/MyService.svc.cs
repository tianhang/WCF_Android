using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;


namespace Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "MyService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select MyService.svc or MyService.svc.cs at the Solution Explorer and start debugging.
    public class MyService : IMyService
    {
        
        public string DoWork(string id)
        {
            return id;
        }
        public Customer GetCustomer(string id)
        {
            return Customer.Make("123","wlliam","wc","2"); 
                //.make("123","wlliam","wc",2);
        }
        public Customer PostCustomer(string id)
        {
            return Customer.Make("123", "wlliam", "wc", "3");
            //.make("123","wlliam","wc",2);
        }
        public Customer AddCustomer(Customer c)
        { 
            System.Console.WriteLine(c);
           // return c;
            return Customer.Make("123", "wlliam", "wc", "3");
        }
    }
}
