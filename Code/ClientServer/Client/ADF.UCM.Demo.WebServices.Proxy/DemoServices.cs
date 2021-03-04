using System.Data;
using System.Collections;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System;
using ADF;


namespace ADF.UCM.Demo.WebServices.Proxy
{
  public class DemoServices
  {

    #region "Webservice Proxies"
    private class DemoWSProxy : DemoService.Services
    {


      protected override System.Net.WebRequest GetWebRequest(System.Uri uri)
      {
        System.Net.WebRequest wr;
        wr = base.GetWebRequest(uri);
        string language = System.Threading.Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName;
        wr.Headers.Add("Accept-Language", language);
        //wr.Headers.Add("UserName", ADF.Windows.Forms.UserControls.SecurityProvider.Current.GetUserId)
        return wr;
      }
    }
    #endregion

    #region "Service Proxies"
    private class DemoProxy : ADF.RemoteServices.WebServiceProxyBase
    {

      #region " Declarations "

      private DemoWSProxy _webservice;

      #endregion

      #region " Constructor "

      public DemoProxy()
      {
        this.LogicalName = "AUT Training Services";
        this._webservice = new DemoWSProxy();
        this._webservice.Url = this.Url;
      }

      #endregion

      #region " Properties "

      public DemoWSProxy WebService
      {
        get
        {
          return this._webservice;
        }
      }

      #endregion

    }
    #endregion

    #region " Declarations "

    DemoProxy _proxy = new DemoProxy();

    #endregion

    #region " Methods "
    public string HelloWorld()
    {
      try
      {
        do
        {
          try
          {
            return this._proxy.WebService.HelloWorld();
          }
          catch (Exception ex)
          {
            this._proxy.HandleException(ex);
          }
        } while (!this._proxy.Finished);
      }
      catch (Exception ex)
      {
        throw (new WebServiceException("Error while saying hello.", ex));
      }
      return "NOK";
    }

    public ArrayList GetCustomers()
    {
      try
      {
        do
        {
          try
          {
            return new ArrayList { this._proxy.WebService.GetCustomers() };
          }
          catch (Exception ex)
          {
            this._proxy.HandleException(ex);
          }
        } while (!this._proxy.Finished);
      }
      catch (Exception ex)
      {
        throw (new WebServiceException("Error while getting customers!", ex));
      }
      return null;
    }

    public string HelloWorlWithoutGen()
    {
      DemoService.Services _proxy = new DemoService.Services();
      _proxy.Url = ADF.Configuration.ConfigurationSettings.UsedWebServices.get_Item("UCM Training Services").URL;
      return _proxy.HelloWorld();
    }

    public void SendMessage()
    {
      try
      {
        {
          try
          {
            this._proxy.WebService.SendNewMessage();
          }
          catch (Exception ex)
          {
            this._proxy.HandleException(ex);
          }
        } while (!this._proxy.Finished) ;
      }
      catch (Exception ex)
      {
        throw (new WebServiceException("Error while sending a message.", ex));
      }
    }
    #endregion

  }


}
