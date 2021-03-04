using ADF.UCM.Demo.WebServices.Proxy;
using NUnit.Framework;

namespace ADF.UCM.Demo.Webservices.Tests
{
  [TestFixture]
  public class ServicesWithNUnitTests
  {
    [Test]
    [Category("IntegrationTest")]
    public void WebServiceDemoServicesHelloWorldReturnMessageWithPatternNUnitTest()
    {
      var svs = new WebServices.Proxy.DemoServices();
      string msg = svs.HelloWorld();
      Assert.That(msg, 
                  Does.Match(@"^Hello\susers\sof\s(?<AppName>[A-Za-z]*){1};"), "Wrong string returned"); //NUnit  
    }

    [Test]
    [Category("IntegrationTest")]
    public void WebServiceDemoServicesGetCustomersThrowsPreconditionExceptionNUnitTest()
    {
      var svs = new WebServices.Proxy.DemoServices();
      Assert.That(svs.GetCustomers,
                  Throws.TypeOf(typeof(WebServiceException)).
                  With.Message.EqualTo("Error while getting customers!"), "Wrong exception or exception message returned!"); //NUnit 
    }
  }
}
