using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Xml2CSharp;

namespace ConsoleSOAP
{
    class Program
    {
        //public static void Main(string[] args)
        //{
        //    // OK, this is not a WCF web service, but that should not matter :D
        //    //string endpoint = "http://www.html2xml.nl/Services/Calculator/Version1/Calculator.asmx";
        //    string endpoint = "http://172.36.0.141/asdkws/Calculator.asmx";

        //    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(endpoint);

        //    request.ContentType = "text/xml"; // or application/soap+xml for SOAP 1.2
        //    request.Method = "POST";
        //    request.KeepAlive = false;

        //    ////In case you have a proxy to resolve the server name also add these lines
        //    //var proxyServer = new WebProxy("XX.XX.XX.XX", 1234);

        //    //proxyServer.Credentials = CredentialCache.DefaultCredentials; // or username + password

        //    //request.Proxy = proxyServer;

        //    // you can read these from files
        //    string payload = @"<soapenv:Envelope xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:tem=""http://tempuri.org/"">
        //                       <soapenv:Header/>
        //                       <soapenv:Body>
        //                          <tem:Add>
        //                             <tem:a>1</tem:a>
        //                             <tem:b>2</tem:b>
        //                          </tem:Add>
        //                       </soapenv:Body>
        //                    </soapenv:Envelope>";

        //    byte[] byteArray = Encoding.UTF8.GetBytes(payload);

        //    request.ContentLength = byteArray.Length;

        //    Stream requestStream = request.GetRequestStream();

        //    requestStream.Write(byteArray, 0, byteArray.Length);
        //    requestStream.Close();

        //    HttpWebResponse response = null;
        //    try
        //    {
        //        response = (HttpWebResponse)request.GetResponse();
        //    }
        //    catch (WebException ex)
        //    {
        //        response = (HttpWebResponse)ex.Response;
        //    }

        //    Console.WriteLine(string.Format("HTTP/{0} {1} {2}\n", response.ProtocolVersion, (int)response.StatusCode, response.StatusDescription));

        //    // you can write this to files
        //    Stream responseStream = response.GetResponseStream();
        //    StreamReader reader = new StreamReader(responseStream);
        //    Console.WriteLine(reader.ReadToEnd());

        //    // cleanp
        //    reader.Close();
        //    requestStream.Close();
        //    responseStream.Close();
        //    response.Close();
        //}


        static void Main(string[] args)
        {
            //creating object of program class to access methods    
            Program obj = new Program();
            //Console.WriteLine("Please Enter Input values..");
            ////Reading input values from console    
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //Calling InvokeService method    
            obj.InvokeService();
        }


        public HttpWebRequest CreateSOAPWebRequest()
        {
            //Making Web Request    
            HttpWebRequest Req = (HttpWebRequest)WebRequest.Create(@"http://172.36.0.141/asdkws/User.asmx");
            //SOAPAction    
            Req.Headers.Add(@"SOAPAction:http://tempuri.org/ListPerfiles");
            //Content_type    
            Req.ContentType = "text/xml;charset=\"utf-8\"";
            Req.Accept = "text/xml";
            //HTTP method    
            Req.Method = "POST";
            //return HttpWebRequest    
            return Req;
        }


        public void InvokeService()
        {
            //Calling CreateSOAPWebRequest method    
            HttpWebRequest request = CreateSOAPWebRequest();

            XmlDocument SOAPReqBody = new XmlDocument();
            //SOAP Body Request    
            SOAPReqBody.LoadXml(@"<?xml version=""1.0"" encoding=""utf-8""?>
            <soap:Envelope xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:soap=""http://schemas.xmlsoap.org/soap/envelope/"">
                <soap:Body>
                    <ListPerfiles xmlns=""http://tempuri.org/"" />
                </soap:Body>
            </soap:Envelope>");    



        using (Stream stream = request.GetRequestStream())
            {
                SOAPReqBody.Save(stream);
            }
            //Geting response from request    
            using (WebResponse Serviceres = request.GetResponse())
            {
                using (StreamReader rd = new StreamReader(Serviceres.GetResponseStream()))
                {
                    //reading stream    
                    var ServiceResult = rd.ReadToEnd();

                    //XmlSerializer serializer
                    XmlDocument xml = new XmlDocument();
                    xml.LoadXml(ServiceResult);

                    XmlNodeList xnList = xml.GetElementsByTagName("User");

                    foreach (XmlNode xn in xnList)
                    {
                        string firstName = xn["Uname"].InnerText;
                        string lastName = xn["UserActive"].InnerText;
                        Console.WriteLine("Perfil: {0} {1}", firstName, lastName);
                    }



                    Console.WriteLine("Listo!");

                    Console.ReadLine();
                }
            }



        }


    }
}
