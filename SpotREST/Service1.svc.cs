using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SpotREST
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    //[ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class Service1 : IService1
    {
        public UsersTableDataClassesDataContext data { get; set; }
        //public string GetData(string name, string username, string password, string companyName)
        //{
        //    try
        //    {
        //        data = new UsersTableDataClassesDataContext();
        //        User u = new User();
        //        u.Name = name;
        //        u.Password = password;
        //        u.Username = username;
        //        u.CompanyName = companyName;
        //        data.SubmitChanges();
        //        return "done?";
        //    }
        //    catch
        //    {
        //        return "unable to add user";
        //    }
        //}

        public List<SpotREST.User> XGetAllUsers()
        {
            data = new UsersTableDataClassesDataContext();
            return data.Users.ToList();
        }
        

        public void GetDataUsingDataContract(ReqData user)
        {
            try
            {
                User usr = new User();

                //user.Name = "Myname";
                //user.Password = "hisiss";
                //user.ComapnyName = "Attires";
                //user.Username = "passsa";

                usr.Name =      user.Name ;
                usr.Password =user.Password;
                usr.CompanyName=user.ComapnyName;
                usr.Username =user.Username;

                data = new UsersTableDataClassesDataContext();
                data.Users.InsertOnSubmit(usr);
                data.SubmitChanges();
                //User u = new User();
                //u.Name = user.Name;
                //u.Password = user.Password;
                //u.Username = user.Username;
                //u.CompanyName = user.ComapnyName;
                //data.SubmitChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
