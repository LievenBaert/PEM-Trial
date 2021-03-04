using ADF.UCM.Demo.WebServices.Proxy;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert; 

namespace ADF.UCM.Demo.Webservices.Tests
{
  [TestClass] //MSTest 
  public class ServicesWithNUnitTests
  {
    [TestMethod()]  //MSTest 
    [TestCategory("IntegrationTest")]
    public void WebServiceDemoServicesHelloWorldReturnMessageWithPatternMsTestAndNUnitTest()
    {
      var svs = new WebServices.Proxy.DemoServices();
      string msg = svs.HelloWorld();
      Assert.That(msg, 
                  Does.Match(@"^Hello\susers\sof\s(?<AppName>[A-Za-z]*){1};"), "Wrong string returned"); //NUnit  
    }

    [TestMethod()]  //MSTest 
    [TestCategory("IntegrationTest")]
    public void WebServiceDemoServicesGetCustomersThrowsPreconditionExceptionMsTestAndNUnitTest()
    {
      var svs = new WebServices.Proxy.DemoServices();
      Assert.That(svs.GetCustomers,
                  Throws.TypeOf(typeof(WebServiceException)).
                  With.Message.EqualTo("Error while getting customers!"), "Wrong exception or exception message returned!"); //NUnit 
    }
  }
}
