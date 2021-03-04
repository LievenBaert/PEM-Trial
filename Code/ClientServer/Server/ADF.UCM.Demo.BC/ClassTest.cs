using System.Collections;

namespace ADF.UCM.Demo.BC
{
	public class ClassTest
	{
        public string HelloWorld()
        {
            {
                return "Hello users of " + 
                        ADF.Configuration.ConfigurationSettings.Application.Name + 
                        "; Your are working with version " + 
                        ADF.Configuration.ConfigurationSettings.Application.Version + 
                        " from " + 
                        ADF.Configuration.ConfigurationSettings.Instrumentation.Stage;
            }

        }
        public ArrayList GetCustomers()
        {
          var con = ADF.Configuration.ConfigurationSettings.Databases.get_Item("mySQLDatabase").ConnectionString;
          var cust = new ArrayList(); 
            
          // ...
          return cust;
        }
  	}
	
}
