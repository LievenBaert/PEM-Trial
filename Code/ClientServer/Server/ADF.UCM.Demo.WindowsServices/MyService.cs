using System;
using System.ServiceProcess;
using Common.Logging;

namespace ADF.UCM.Demo.WindowsServices
{
    public partial class MyService : ServiceBase
    {
        private ILog _logger;

        public MyService()
        {
            InitializeComponent();
            _logger = LogManager.GetLogger("AUT.WindowsService");
        }

        protected override void OnStart(string[] args)
        {
            // Log service started.
            _logger.Info("AUT windows service started.");
            if (Environment.Is64BitProcess)
                _logger.Info("64-bit process");
            else
                _logger.Info("32-bit process");
        }

        protected override void OnStop()
        {
            // Log service stopped.
            _logger.Info("AUT windows service stopped.");
        }


    }
}
