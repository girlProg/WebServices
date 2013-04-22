using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SpotREST
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        //[OperationContract]
        //[WebGet (UriTemplate = @"/json/register/{name}",
        //    ResponseFormat=WebMessageFormat.Json,
        //    RequestFormat=WebMessageFormat.Json)]
        //string GetData(string name, string username, string password, string companyName);


        [OperationContract]
        [WebGet(UriTemplate = @"/getallUsers",
            ResponseFormat = WebMessageFormat.Xml,
            RequestFormat = WebMessageFormat.Xml)]
        List<SpotREST.User> XGetAllUsers();

        [OperationContract]
        [WebInvoke (Method = "POST",
            UriTemplate = @"/adduser",
            ResponseFormat = WebMessageFormat.Xml,
            RequestFormat = WebMessageFormat.Xml)]
        void GetDataUsingDataContract(ReqData user);

        // TODO: Add your service operations here
    }

    [DataContract(Namespace = "http://tymahgalaudu.com")]
    public class ReqData
    {

        string username;
        string name;
        string password;
        string companyName;

        [DataMember]
        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        [DataMember]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        [DataMember]
        public string ComapnyName
        {
            get { return companyName; }
            set { companyName = value; }
        }

        [DataMember]
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract (Namespace = "http://tymahgalaudu.com")]
    public class MockUser
    {
        string username;
        string name;
        string password;
        string companyName;

        [DataMember]
        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        [DataMember]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        [DataMember]
        public string ComapnyName
        {
            get { return companyName; }
            set { companyName = value; }
        }

        [DataMember]
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
    }
}
