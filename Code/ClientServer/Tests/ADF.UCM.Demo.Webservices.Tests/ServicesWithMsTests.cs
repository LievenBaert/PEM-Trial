using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ADF.UCM.Demo.Webservices.Tests
{
    [TestClass]
  public class ServicesWithMsTests
  {
    [TestMethod()]
    [TestCategory("IntegrationTest")]
    public void WebServiceDemoServicesHelloWorldReturnNotEmptyMsTestTest()
    {
      var svs = new WebServices.Proxy.DemoServices();
      string actual = svs.HelloWorld();
      Assert.IsTrue(!string.IsNullOrEmpty(actual), "Empty string returned");
    }

    [TestMethod()]
    [TestCategory("IntegrationTest")]
    public void WebServiceDemoServicesHelloWorldReturnHelloUsersMessageMsTestTest()
    {
      var svs = new WebServices.Proxy.DemoServices();
      string msg = svs.HelloWorld();
      Assert.IsTrue(msg.StartsWith(@"Hello users of"), "Wrong string returned");
    }

    //[TestCategory("IntegrationTest")]
    //public void TestSimpleWindowsService()
    //{
    //    // This value is updated by the build workflow
    //    string hostName = ConfigurationManager.AppSettings["TestEnvironment"];

    //    TestWindowsService("SimpleWindowsService", hostName);
    //}

    //private void TestWindowsService(string serviceName, string hostName)
    //{
    //    using (ServiceController sc = new ServiceController(serviceName, hostName))
    //    {
    //        // Ensure the service is running
    //        if (!(sc.Status == ServiceControllerStatus.Running))
    //        {
    //            WindowsServiceHelper.StartService(serviceName, hostName); 

    //            // This will wait up to a minute for the service to be started
    //            bool isRunning = WindowsServiceHelper.PollServiceStatus(serviceName, hostName, 60, 1000, ServiceControllerStatus.Running); 

    //            if(!isRunning)
    //                throw new AssertFailedException(string.Format("Service {0} is not running and cannot be started", serviceName));
    //        }
    //    }
    //}
  }
}
