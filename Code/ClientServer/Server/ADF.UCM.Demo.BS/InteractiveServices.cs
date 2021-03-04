using System.Data;
using System.Collections;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System;
using ADF.UCM.Demo;
using ADF.ExceptionHandling;
using System.Reflection;


namespace ADF.UCM.Demo.BS
{
	public class Services
	{
		public string HelloWorld()
		{
            string msg = string.Empty;
            try
            {
                msg = new ADF.UCM.Demo.BC.ClassTest().HelloWorld();
            }
            catch (Exception ex)
            {
                ExceptionManager.Publish(ex, new Method(MethodBase.GetCurrentMethod()), ReThrowOptions.RethrowAsBusinessException );
            }
            return msg;
		}

    public ArrayList GetCustomers()
    {
      var customers = new ArrayList();
      try
      {
        throw new ExceptionHandling.BusinessExceptions.PreconditionException("You are not autorized to perform this action!");

        //...
      }
      catch (Exception ex)
      {
        ExceptionManager.Publish(ex, new Method(MethodBase.GetCurrentMethod()), ReThrowOptions.RethrowAsBusinessException);
      }
      return customers;
    }
	}
}
