using System.Data;
using System.Collections;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System;
using ADF.ExceptionHandling;
using System.Runtime.Serialization;



namespace ADF.UCM.Demo.PFS
{
	[Serializable()]public class ProcessException : BaseApplicationException
	{
		
		
		public override ReturnCodes ReturnCode
		{
			get
			{
				return ReturnCodes.UnexpectedError;
			}
		}
		
		public ProcessException()
		{
		}
		
		public ProcessException(string message) : base(message)
		{
		}
		
		public ProcessException(string message, Exception inner) : base(message, inner)
		{
		}
		
		public ProcessException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
	
}
