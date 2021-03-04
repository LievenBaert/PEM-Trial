using System.Data;
using System.Collections;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System;
using ADF.ExceptionHandling;
using System.Runtime.Serialization;



namespace ADF.UCM.Demo.WebServices.Proxy
{
	[Serializable()]public class WebServiceException : BaseApplicationException
	{
		
		
		public override ReturnCodes ReturnCode
		{
			get
			{
				return ReturnCodes.OperationNotAvailable;
			}
		}
		
		public WebServiceException()
		{
		}
		
		public WebServiceException(string message) : base(message)
		{
		}
		
		public WebServiceException(string message, Exception inner) : base(message, inner)
		{
		}
		
		public WebServiceException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
	
}
