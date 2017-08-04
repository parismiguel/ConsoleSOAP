using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSOAP
{
    class Program
    {
        public static void Main(string[] args)
        {
            // OK, this is not a WCF web service, but that should not matter :D
            string endpoint = "http://www.html2xml.nl/Services/Calculator/Version1/Calculator.asmx";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(endpoint);
            request.ContentType = "text/xml"; // or application/soap+xml for SOAP 1.2
            request.Method = "POST";
            request.KeepAlive = false;

            //In case you have a proxy to resolve the server name also add these lines
            var proxyServer = new WebProxy("XX.XX.XX.XX", 1234);
            proxyServer.Credentials = CredentialCache.DefaultCredentials; // or username + password
            request.Proxy = proxyServer;

            // you can read these from files
            string payload = @"<soapenv:Envelope xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:tem=""http://tempuri.org/"">
                               <soapenv:Header/>
                               <soapenv:Body>
                                  <tem:Add>
                                     <tem:a>1</tem:a>
                                     <tem:b>2</tem:b>
                                  </tem:Add>
                               </soapenv:Body>
                            </soapenv:Envelope>";

            byte[] byteArray = Encoding.UTF8.GetBytes(payload);
            request.ContentLength = byteArray.Length;

            Stream requestStream = request.GetRequestStream();
            requestStream.Write(byteArray, 0, byteArray.Length);
            requestStream.Close();

            HttpWebResponse response = null;
            try
            {
                response = (HttpWebResponse)request.GetResponse();
            }
            catch (WebException ex)
            {
                response = (HttpWebResponse)ex.Response;
            }

            Console.WriteLine(string.Format("HTTP/{0} {1} {2}\n", response.ProtocolVersion, (int)response.StatusCode, response.StatusDescription));

            // you can write this to files
            Stream responseStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(responseStream);
            Console.WriteLine(reader.ReadToEnd());

            // cleanp
            reader.Close();
            requestStream.Close();
            responseStream.Close();
            response.Close();
        }
    }
}
