using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ConsoleApplicationClient.ServiceReference1;
using System.Web;
using System.Net;
using System.Xml.Linq;

namespace ConsoleApplicationClient
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClient client = new WebClient();
            string uri = "http://localhost:57350/Service1.svc/adduser";
            string data = "<ReqData xmlns = \"http://tymahgalaudu.com\"><User><CompanyName>heather</CompanyName><Name>heather Galaudu</Name><Password>cardie</Password><Username>foodie</Username></User></ReqData>";
            //var res = client.UploadString(uri, "POST", data);

            //create the xml request document
            XNamespace ns = "http://tymahgalaudu.com";
            XDocument doc = new XDocument(new XElement(ns + "User", new XElement(ns + "CompanyName", "2147483647"),
                new XElement(ns + "Name", "String content"),
                new XElement(ns + "Password", "String content"),
                new XElement(ns + "Username", "thats")));
            
            var res = client.UploadString(uri, "POST", data);
            //Console.WriteLine(res);
        }
    }
}
