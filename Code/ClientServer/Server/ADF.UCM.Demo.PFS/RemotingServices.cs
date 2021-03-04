using System.Data;
using System.Collections;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System;
using ADF.Diagnostics;
using ADF.Messaging.Interfaces.Dispatcher;


namespace ADF.UCM.Demo.PFS
{
	public class RemotingServices : MarshalByRefObject, IRemotingService
	{
		public void Execute()
		{
			ProcessMessage();
		}
		public void Execute(string destination, string origin, string body)
		{
			ProcessMessage(destination, origin, body);
		}
		
		public virtual void ProcessMessage()
		{
			throw (new ADF.ExceptionHandling.GlobalExceptions.UnexpectedException("Remote Execute is not implemented!"));
		}
		public virtual void ProcessMessage(string destination, string origin, string body)
		{
			throw (new ADF.ExceptionHandling.GlobalExceptions.UnexpectedException("Remote Execute is not implemented!"));
		}
	}
}
