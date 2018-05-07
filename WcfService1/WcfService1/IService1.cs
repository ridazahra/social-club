using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        void add(string name,string password,string question,string answer);
        [OperationContract]
        bool search(string name, string password);
        [OperationContract]
        bool change_password(string q, string a, string p);
        [OperationContract]
        void add_category(string name,string cat,string q,string cn,string working,string g);
        [OperationContract]
        string GetData(int value);
        [OperationContract]
        bool change(string name,string password, string key);
        [OperationContract]
        bool isadmin(string name, string password);
        [OperationContract]
        List<club> search_servant(string category);
        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
