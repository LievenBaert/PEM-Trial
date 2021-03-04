using System;
using System.Collections;
using System.Web.Services;
using System.ComponentModel;
using ADF.ExceptionHandling;

namespace  ADF.UCM.Demo.Webservices
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    public class Services : System.Web.Services.WebService
    {
        [WebMethod()]
        public string HelloWorld()
        {
            try
            {
                return (new BS.Services()).HelloWorld();
            }
            catch (Exception ex)
            {
                ExceptionManager.Rethrow (ex, ReThrowOptions.RethrowAsSoapException);
            }
            return string.Empty;
        }

        [WebMethod()]
        public ArrayList GetCustomers()
        {
          try
          {
            return (new BS.Services()).GetCustomers();
          }
          catch (Exception ex)
          {
            ExceptionManager.Rethrow(ex, ReThrowOptions.RethrowAsSoapException);
          }
          return null;
        }

        [WebMethod()]
        public void ProcessMessage()
        {
            try
            {
                PFS.CommunicationServices svs = new PFS.CommunicationServices();
                svs.ProcessMessage();
            }
            catch (Exception ex)
            {
                ExceptionManager.Rethrow(ex, ReThrowOptions.RethrowAsSoapException);
            }
        }
        [WebMethod()]
        public void ProcessMessageWithParams(string destination, string origin, string body)
        {
            try
            {
                PFS.CommunicationServices svs = new PFS.CommunicationServices();
                svs.ProcessMessage(destination, origin, body);
            }
            catch (Exception ex)
            {
                ExceptionManager.Rethrow(ex, ReThrowOptions.RethrowAsSoapException);
            }
        }

        // Don't use method name "SendMessage" because this is a reserved word in Biztalk
        [WebMethod()]
        public void SendNewMessage()
        {
            try
            {
                PFS.CommunicationServices svs = new PFS.CommunicationServices();
                //svs.SendMessage();
            }
            catch (Exception ex)
            {
                ExceptionManager.Rethrow(ex, ReThrowOptions.RethrowAsSoapException);
            }
        }
    }
}
