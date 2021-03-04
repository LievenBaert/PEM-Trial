﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.18444.
// 
#pragma warning disable 1591

namespace ADF.UCM.Demo.WebServices.Proxy.DemoService {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="ServicesSoap", Namespace="http://tempuri.org/")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(object[]))]
    public partial class Services : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback HelloWorldOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetCustomersOperationCompleted;
        
        private System.Threading.SendOrPostCallback ProcessMessageOperationCompleted;
        
        private System.Threading.SendOrPostCallback ProcessMessageWithParamsOperationCompleted;
        
        private System.Threading.SendOrPostCallback SendNewMessageOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public Services() {
            this.Url = "http://localhost/AUTServices.CSDemo/Services.asmx";
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event HelloWorldCompletedEventHandler HelloWorldCompleted;
        
        /// <remarks/>
        public event GetCustomersCompletedEventHandler GetCustomersCompleted;
        
        /// <remarks/>
        public event ProcessMessageCompletedEventHandler ProcessMessageCompleted;
        
        /// <remarks/>
        public event ProcessMessageWithParamsCompletedEventHandler ProcessMessageWithParamsCompleted;
        
        /// <remarks/>
        public event SendNewMessageCompletedEventHandler SendNewMessageCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/HelloWorld", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string HelloWorld() {
            object[] results = this.Invoke("HelloWorld", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginHelloWorld(System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("HelloWorld", new object[0], callback, asyncState);
        }
        
        /// <remarks/>
        public string EndHelloWorld(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void HelloWorldAsync() {
            this.HelloWorldAsync(null);
        }
        
        /// <remarks/>
        public void HelloWorldAsync(object userState) {
            if ((this.HelloWorldOperationCompleted == null)) {
                this.HelloWorldOperationCompleted = new System.Threading.SendOrPostCallback(this.OnHelloWorldOperationCompleted);
            }
            this.InvokeAsync("HelloWorld", new object[0], this.HelloWorldOperationCompleted, userState);
        }
        
        private void OnHelloWorldOperationCompleted(object arg) {
            if ((this.HelloWorldCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.HelloWorldCompleted(this, new HelloWorldCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetCustomers", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public object[] GetCustomers() {
            object[] results = this.Invoke("GetCustomers", new object[0]);
            return ((object[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetCustomers(System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetCustomers", new object[0], callback, asyncState);
        }
        
        /// <remarks/>
        public object[] EndGetCustomers(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((object[])(results[0]));
        }
        
        /// <remarks/>
        public void GetCustomersAsync() {
            this.GetCustomersAsync(null);
        }
        
        /// <remarks/>
        public void GetCustomersAsync(object userState) {
            if ((this.GetCustomersOperationCompleted == null)) {
                this.GetCustomersOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetCustomersOperationCompleted);
            }
            this.InvokeAsync("GetCustomers", new object[0], this.GetCustomersOperationCompleted, userState);
        }
        
        private void OnGetCustomersOperationCompleted(object arg) {
            if ((this.GetCustomersCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetCustomersCompleted(this, new GetCustomersCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ProcessMessage", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void ProcessMessage() {
            this.Invoke("ProcessMessage", new object[0]);
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginProcessMessage(System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("ProcessMessage", new object[0], callback, asyncState);
        }
        
        /// <remarks/>
        public void EndProcessMessage(System.IAsyncResult asyncResult) {
            this.EndInvoke(asyncResult);
        }
        
        /// <remarks/>
        public void ProcessMessageAsync() {
            this.ProcessMessageAsync(null);
        }
        
        /// <remarks/>
        public void ProcessMessageAsync(object userState) {
            if ((this.ProcessMessageOperationCompleted == null)) {
                this.ProcessMessageOperationCompleted = new System.Threading.SendOrPostCallback(this.OnProcessMessageOperationCompleted);
            }
            this.InvokeAsync("ProcessMessage", new object[0], this.ProcessMessageOperationCompleted, userState);
        }
        
        private void OnProcessMessageOperationCompleted(object arg) {
            if ((this.ProcessMessageCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ProcessMessageCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ProcessMessageWithParams", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void ProcessMessageWithParams(string destination, string origin, string body) {
            this.Invoke("ProcessMessageWithParams", new object[] {
                        destination,
                        origin,
                        body});
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginProcessMessageWithParams(string destination, string origin, string body, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("ProcessMessageWithParams", new object[] {
                        destination,
                        origin,
                        body}, callback, asyncState);
        }
        
        /// <remarks/>
        public void EndProcessMessageWithParams(System.IAsyncResult asyncResult) {
            this.EndInvoke(asyncResult);
        }
        
        /// <remarks/>
        public void ProcessMessageWithParamsAsync(string destination, string origin, string body) {
            this.ProcessMessageWithParamsAsync(destination, origin, body, null);
        }
        
        /// <remarks/>
        public void ProcessMessageWithParamsAsync(string destination, string origin, string body, object userState) {
            if ((this.ProcessMessageWithParamsOperationCompleted == null)) {
                this.ProcessMessageWithParamsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnProcessMessageWithParamsOperationCompleted);
            }
            this.InvokeAsync("ProcessMessageWithParams", new object[] {
                        destination,
                        origin,
                        body}, this.ProcessMessageWithParamsOperationCompleted, userState);
        }
        
        private void OnProcessMessageWithParamsOperationCompleted(object arg) {
            if ((this.ProcessMessageWithParamsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ProcessMessageWithParamsCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/SendNewMessage", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void SendNewMessage() {
            this.Invoke("SendNewMessage", new object[0]);
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginSendNewMessage(System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("SendNewMessage", new object[0], callback, asyncState);
        }
        
        /// <remarks/>
        public void EndSendNewMessage(System.IAsyncResult asyncResult) {
            this.EndInvoke(asyncResult);
        }
        
        /// <remarks/>
        public void SendNewMessageAsync() {
            this.SendNewMessageAsync(null);
        }
        
        /// <remarks/>
        public void SendNewMessageAsync(object userState) {
            if ((this.SendNewMessageOperationCompleted == null)) {
                this.SendNewMessageOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSendNewMessageOperationCompleted);
            }
            this.InvokeAsync("SendNewMessage", new object[0], this.SendNewMessageOperationCompleted, userState);
        }
        
        private void OnSendNewMessageOperationCompleted(object arg) {
            if ((this.SendNewMessageCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SendNewMessageCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void HelloWorldCompletedEventHandler(object sender, HelloWorldCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class HelloWorldCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal HelloWorldCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void GetCustomersCompletedEventHandler(object sender, GetCustomersCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetCustomersCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetCustomersCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public object[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((object[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void ProcessMessageCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void ProcessMessageWithParamsCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void SendNewMessageCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
}

#pragma warning restore 1591