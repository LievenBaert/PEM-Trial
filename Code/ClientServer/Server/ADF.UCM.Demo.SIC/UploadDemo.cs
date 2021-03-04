using System.Data;
using System.Collections;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System;
using ADF.Messaging;
using ADF.ExceptionHandling;
using ADF.Configuration.ConfigurationSettings;


namespace ADF.UCM.Demo.SIC
{
	public class UploadDemo
	{
		private string _MsgXML; //Bericht na preprocess-stap
		private string _Msg;
		
		private string _PathMapFile;
		private string _MapFile;		
        
        public UploadDemo()
		{
			_PathMapFile = XML.Path.Maps;
			_MapFile = _PathMapFile + "UploadDemoMap.xsl";
		}	
	
        //public void Send(UploadDemoData ds)
        //{
        //    try
        //    {
        //        //_MsgXML = Transformation.Transform(ds, _MapFile)
        //        //_Msg = Transformation.PostProcessSegmentedMessage(_MsgXML)
				
        //        Sender Sender = new Sender("UploadDemoQueue");
        //        Sender.Send(ds.UploadDemo.FindByKey("DEST").Value, ds.UploadDemo.FindByKey("DATA").Value);
				
        //    }
        //    catch (Exception ex)
        //    {
        //        ADF.ExceptionHandling.BusinessExceptions.MessagingException exc = new ADF.ExceptionHandling.BusinessExceptions.MessagingException("Error while uploading demo data.", ex);
        //        exc.AdditionalInformation.Add("Message (XML format): ", _MsgXML);
        //        throw (exc);
        //    }
        //}
	}
}
