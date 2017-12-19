using ODCMailTask.Helper;
using ODCMailTask.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace ODCMailTask
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isvalid = false;
            string mail = "";

            #region Mail validation
            do
            {
                Console.Clear();
                Console.WriteLine("Lütfen alıcının mail adresini giriniz");
                mail = Console.ReadLine();
                if (MailValidator.IsValidEmail(mail) == true)
                {
                    isvalid = true;
                }
                else
                {
                    Console.WriteLine(ApiConstants.INPUT_VALIDATION_ERROR);
                    System.Threading.Thread.Sleep(1000);
                } 
             
            } while (isvalid == false);
            #endregion

            Console.WriteLine("Lütfen gidecek metni yazınız");
            string content = Console.ReadLine();
            Console.WriteLine(ApiConstants.INPUT_VALIDATION);

            var sendXmlRequest = new XMLRequest(content,mail);
            var XmlResponse = SendRequest(sendXmlRequest).Result;
            #region api response and save

            //Response save
            Audit.WriteTextToFile("Date : " + DateTime.Now + "\t response : " + XmlResponse, Audit.AuiditFileName.XMLResponse);

            XmlDocument xDoc = new XmlDocument();
            xDoc.LoadXml(XmlResponse);
            var exp = xDoc.GetElementsByTagName(ApiConstants.EXP)[0].InnerText;

            if (exp == HttpStatusCode.OK.ToString())
            {
                Console.WriteLine(exp);
                System.Threading.Thread.Sleep(1000);
            }
            else
            {
                Console.WriteLine("Mesaj gönderilemedi.Dönen hata : " + exp);
                System.Threading.Thread.Sleep(1000);
            }

            #endregion

        }
        private static async Task<string> SendRequest(XMLRequest sendxmlRequest)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(ApiConstants.apiURL);

                XDocument doc = new XDocument(new XElement(ApiConstants.SENDEML,
                                               new XElement(ApiConstants.USR, XMLRequest.USR),
                                               new XElement(ApiConstants.PWD, XMLRequest.PWD),
                                               new XElement(ApiConstants.JID, XMLRequest.JID),
                                               new XElement(ApiConstants.CG, XMLRequest.CG),
                                               new XElement(ApiConstants.SBJ, XMLRequest.SBJ),
                                                    new XElement(ApiConstants.RCPT_LIST,
                                                        new XElement(ApiConstants.RCPT,
                                                        new XElement(ApiConstants.MSG, sendxmlRequest.MSG),
                                                        new XElement(ApiConstants.TA, sendxmlRequest.TO)))));
                var req = "data=" + doc;

                // request save
                Audit.WriteTextToFile("Date : " + DateTime.Now + "\t request : " + req, Audit.AuiditFileName.XMLRequest);

                var result = client.PostAsync(ApiConstants.apiPATH, new StringContent(req, Encoding.UTF8, ApiConstants.CONTENT_TYPE));
                return await result.Result.Content.ReadAsStringAsync();
            }
        }





    }
}
