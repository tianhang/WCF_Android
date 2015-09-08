using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Web;

namespace Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IMyService" in both code and config file together.
    [ServiceContract]
    public interface IMyService
    {
        [OperationContract]
        [WebGet(UriTemplate = "/test/{id}", ResponseFormat = WebMessageFormat.Json)]
        string DoWork(string id);

        [OperationContract]
        [WebGet(UriTemplate = "/customer/{id}", ResponseFormat = WebMessageFormat.Json)]
        Customer GetCustomer(string id);

        [OperationContract]
        [WebInvoke(UriTemplate = "/post/{id}", Method = "POST",
        RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        Customer PostCustomer(string id);

        [OperationContract]
        [WebInvoke(UriTemplate = "/add", Method = "POST",
        RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        Customer AddCustomer(Customer c);
    }
    [DataContract] 
    public class Customer
    {
        string id;  
        string name;
        string address;
        string credit;

        public static Customer Make(string id, string name, string address, string credit)
        {
            Customer c = new Customer();
            c.id = id;
            c.name = name;
            c.address = address;
            c.credit = credit;
            return c;
        }

        [DataMember]
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        [DataMember]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        [DataMember]
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        
        [DataMember]
        public string Credit
        {
            get { return credit; }
            set { credit = value; }
        }
    }
}
