using System;
using System.Web;
using System.Web.SessionState;

namespace ADF.UCM.Demo.Webservices
{
    public class Global : System.Web.HttpApplication
    {
        public Global()
        {
            InitializeComponent();
        }
        private System.ComponentModel.IContainer components;

        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
        }

        void Application_Start(object sender, EventArgs e)
        {
        }

        void Session_Start(object sender, EventArgs e)
        {
        }

        void Application_BeginRequest(object sender, EventArgs e)
        {
        }

        void Application_AuthenticateRequest(object sender, EventArgs e)
        {
        }

        void Application_Error(object sender, EventArgs e)
        {
        }

        void Session_End(object sender, EventArgs e)
        {
        }

        void Application_End(object sender, EventArgs e)
        {
        }
    }
}
