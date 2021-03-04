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
	public class DownloadDemo
	{
		private string _MsgXML; //Bericht na preprocess-stap
		
		private string _PathMapFile;
		private string _MapFile;	
        
        public DownloadDemo()
		{
			_PathMapFile = XML.Path.Maps;
			_MapFile = _PathMapFile + "DownloadDemoMap.xsl";	
		}
        	
        //public DownloadDemoData Receive()
        //{
        //    try
        //    {
        //        Receiver Receiver = new Receiver("DownloadDemoQueue");
        //        Receiver.Receive();
				
        //        //Dim ds As DataSet = New DownloadDemoData
        //        //_MsgXML = Transformation.PreProcessSegmentedMessage(Receiver.Data, "DownloadDemo")
        //        //Transformation.Transform(_MsgXML, _MapFile, ds)
				
        //        DownloadDemoData ds = new DownloadDemoData();
				
        //        ds.DownloadDemo.AddDownloadDemoRow("DEST", Receiver.Destination);
        //        ds.DownloadDemo.AddDownloadDemoRow("ORIG", Receiver.Origin);
        //        ds.DownloadDemo.AddDownloadDemoRow("DATA", Receiver.Data);
        //        ds.AcceptChanges();
				
        //        return ds;
        //    }
        //    catch (Exception ex)
        //    {
        //        ADF.ExceptionHandling.BusinessExceptions.MessagingException exc = new ADF.ExceptionHandling.BusinessExceptions.MessagingException("Error while downloading demo data.", ex);
        //        exc.AdditionalInformation.Add("Message (XML format): ", _MsgXML);
        //        throw (exc);
        //    }
        //}
	}
}
