using System.Data;
using System.Collections;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System;

using ADF;
using ADF.Diagnostics;
using ADF.Messaging.Interfaces.Dispatcher;


namespace ADF.UCM.Demo.PFS
{
    public class CommunicationServices : RemotingServices
    {
        //public override void ProcessMessage()
        //{
        //    try
        //    {
        //        ADF.EnterpriseServices.DistributedTransaction.Start(ADF.EnterpriseServices.TxConfig.NewTransaction);

        //        SIC.DownloadDemo sic = new SIC.DownloadDemo();
        //        SIC.DownloadDemoData dsDemo;

        //        dsDemo = sic.Receive();

        //        TextFileTracer.Write("Message received from " + dsDemo.DownloadDemo.FindByKey("DEST").Value);

        //        //...  do your busines stuff

        //        ADF.EnterpriseServices.DistributedTransaction.Commit();
        //    }
        //    catch (Exception ex)
        //    {
        //        ADF.EnterpriseServices.DistributedTransaction.Abort();
        //        ADF.ExceptionHandling.ExceptionManager.Publish(ex, ADF.ExceptionHandling.ReThrowOptions.RethrowAsBusinessException);
        //    }
        //}
        //public override void ProcessMessage(string d, string o, string b)
        //{
        //    try
        //    {
        //        ADF.EnterpriseServices.DistributedTransaction.Start(ADF.EnterpriseServices.TxConfig.NewTransaction);

        //        TextFileTracer.Write("Message received from " + d);

        //        //...  do your busines stuff
        //        ADF.EnterpriseServices.DistributedTransaction.Commit();
        //    }
        //    catch (Exception ex)
        //    {
        //        ADF.EnterpriseServices.DistributedTransaction.Abort();

        //        System.Collections.Specialized.NameValueCollection additionalInfo = new System.Collections.Specialized.NameValueCollection();
        //        additionalInfo.Add("Destination", d);
        //        additionalInfo.Add("Origin", o);
        //        additionalInfo.Add("Body", b);

        //        ADF.ExceptionHandling.ExceptionManager.Publish(ex, additionalInfo, ADF.ExceptionHandling.ReThrowOptions.RethrowAsBusinessException);
        //    }
        //}

        //public void SendMessage()
        //{
        //    try
        //    {
        //        ADF.EnterpriseServices.DistributedTransaction.Start(ADF.EnterpriseServices.TxConfig.NewTransaction);

        //        SIC.UploadDemo sic = new SIC.UploadDemo();
        //        SIC.UploadDemoData dsDemo = new SIC.UploadDemoData();

        //        //...  do your busines stuff
        //        dsDemo.UploadDemo.AddUploadDemoRow("DEST", "CCxyz");
        //        dsDemo.UploadDemo.AddUploadDemoRow("ORIG", "DotNet");
        //        dsDemo.UploadDemo.AddUploadDemoRow("DATA", "hello there");
        //        dsDemo.AcceptChanges();

        //        sic.Send(dsDemo);

        //        //...  do your busines stuff

        //        ADF.EnterpriseServices.DistributedTransaction.Commit();
        //    }
        //    catch (Exception ex)
        //    {
        //        ADF.EnterpriseServices.DistributedTransaction.Abort();
        //        ADF.ExceptionHandling.ExceptionManager.Publish(ex, ADF.ExceptionHandling.ReThrowOptions.RethrowAsBusinessException);
        //    }

        //}
    }
}
