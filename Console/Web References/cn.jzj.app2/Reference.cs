﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

// 
// 此源代码是由 Microsoft.VSDesigner 4.0.30319.42000 版自动生成。
// 
#pragma warning disable 1591

namespace ConsoleHydee.cn.jzj.app2 {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="JzJInfoSoap", Namespace="http://tempuri.org/")]
    public partial class JzJInfo : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback SetPrescriptionInfoOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetAuditStateOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetAssocioterOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetIntrgralOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetChangeIntrgralDetailOperationCompleted;
        
        private System.Threading.SendOrPostCallback YzToJzjSetChangeIntrgralOperationCompleted;
        
        private System.Threading.SendOrPostCallback YzToJzjUpdateAssocioterOperationCompleted;
        
        private System.Threading.SendOrPostCallback YzToJzjSetVoucherStateOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetPrescriptionLabelOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public JzJInfo() {
            this.Url = global::ConsoleHydee.Properties.Settings.Default.ConsoleHydee_cn_jzj_app2_JzJInfo;
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
        public event SetPrescriptionInfoCompletedEventHandler SetPrescriptionInfoCompleted;
        
        /// <remarks/>
        public event GetAuditStateCompletedEventHandler GetAuditStateCompleted;
        
        /// <remarks/>
        public event GetAssocioterCompletedEventHandler GetAssocioterCompleted;
        
        /// <remarks/>
        public event GetIntrgralCompletedEventHandler GetIntrgralCompleted;
        
        /// <remarks/>
        public event GetChangeIntrgralDetailCompletedEventHandler GetChangeIntrgralDetailCompleted;
        
        /// <remarks/>
        public event YzToJzjSetChangeIntrgralCompletedEventHandler YzToJzjSetChangeIntrgralCompleted;
        
        /// <remarks/>
        public event YzToJzjUpdateAssocioterCompletedEventHandler YzToJzjUpdateAssocioterCompleted;
        
        /// <remarks/>
        public event YzToJzjSetVoucherStateCompletedEventHandler YzToJzjSetVoucherStateCompleted;
        
        /// <remarks/>
        public event GetPrescriptionLabelCompletedEventHandler GetPrescriptionLabelCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/SetPrescriptionInfo", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string SetPrescriptionInfo(string json) {
            object[] results = this.Invoke("SetPrescriptionInfo", new object[] {
                        json});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void SetPrescriptionInfoAsync(string json) {
            this.SetPrescriptionInfoAsync(json, null);
        }
        
        /// <remarks/>
        public void SetPrescriptionInfoAsync(string json, object userState) {
            if ((this.SetPrescriptionInfoOperationCompleted == null)) {
                this.SetPrescriptionInfoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSetPrescriptionInfoOperationCompleted);
            }
            this.InvokeAsync("SetPrescriptionInfo", new object[] {
                        json}, this.SetPrescriptionInfoOperationCompleted, userState);
        }
        
        private void OnSetPrescriptionInfoOperationCompleted(object arg) {
            if ((this.SetPrescriptionInfoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SetPrescriptionInfoCompleted(this, new SetPrescriptionInfoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetAuditState", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetAuditState(string json) {
            object[] results = this.Invoke("GetAuditState", new object[] {
                        json});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetAuditStateAsync(string json) {
            this.GetAuditStateAsync(json, null);
        }
        
        /// <remarks/>
        public void GetAuditStateAsync(string json, object userState) {
            if ((this.GetAuditStateOperationCompleted == null)) {
                this.GetAuditStateOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetAuditStateOperationCompleted);
            }
            this.InvokeAsync("GetAuditState", new object[] {
                        json}, this.GetAuditStateOperationCompleted, userState);
        }
        
        private void OnGetAuditStateOperationCompleted(object arg) {
            if ((this.GetAuditStateCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetAuditStateCompleted(this, new GetAuditStateCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetAssocioter", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetAssocioter(string json) {
            object[] results = this.Invoke("GetAssocioter", new object[] {
                        json});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetAssocioterAsync(string json) {
            this.GetAssocioterAsync(json, null);
        }
        
        /// <remarks/>
        public void GetAssocioterAsync(string json, object userState) {
            if ((this.GetAssocioterOperationCompleted == null)) {
                this.GetAssocioterOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetAssocioterOperationCompleted);
            }
            this.InvokeAsync("GetAssocioter", new object[] {
                        json}, this.GetAssocioterOperationCompleted, userState);
        }
        
        private void OnGetAssocioterOperationCompleted(object arg) {
            if ((this.GetAssocioterCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetAssocioterCompleted(this, new GetAssocioterCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetIntrgral", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetIntrgral(string json) {
            object[] results = this.Invoke("GetIntrgral", new object[] {
                        json});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetIntrgralAsync(string json) {
            this.GetIntrgralAsync(json, null);
        }
        
        /// <remarks/>
        public void GetIntrgralAsync(string json, object userState) {
            if ((this.GetIntrgralOperationCompleted == null)) {
                this.GetIntrgralOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetIntrgralOperationCompleted);
            }
            this.InvokeAsync("GetIntrgral", new object[] {
                        json}, this.GetIntrgralOperationCompleted, userState);
        }
        
        private void OnGetIntrgralOperationCompleted(object arg) {
            if ((this.GetIntrgralCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetIntrgralCompleted(this, new GetIntrgralCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetChangeIntrgralDetail", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetChangeIntrgralDetail(string json) {
            object[] results = this.Invoke("GetChangeIntrgralDetail", new object[] {
                        json});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetChangeIntrgralDetailAsync(string json) {
            this.GetChangeIntrgralDetailAsync(json, null);
        }
        
        /// <remarks/>
        public void GetChangeIntrgralDetailAsync(string json, object userState) {
            if ((this.GetChangeIntrgralDetailOperationCompleted == null)) {
                this.GetChangeIntrgralDetailOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetChangeIntrgralDetailOperationCompleted);
            }
            this.InvokeAsync("GetChangeIntrgralDetail", new object[] {
                        json}, this.GetChangeIntrgralDetailOperationCompleted, userState);
        }
        
        private void OnGetChangeIntrgralDetailOperationCompleted(object arg) {
            if ((this.GetChangeIntrgralDetailCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetChangeIntrgralDetailCompleted(this, new GetChangeIntrgralDetailCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/YzToJzjSetChangeIntrgral", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string YzToJzjSetChangeIntrgral(string json) {
            object[] results = this.Invoke("YzToJzjSetChangeIntrgral", new object[] {
                        json});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void YzToJzjSetChangeIntrgralAsync(string json) {
            this.YzToJzjSetChangeIntrgralAsync(json, null);
        }
        
        /// <remarks/>
        public void YzToJzjSetChangeIntrgralAsync(string json, object userState) {
            if ((this.YzToJzjSetChangeIntrgralOperationCompleted == null)) {
                this.YzToJzjSetChangeIntrgralOperationCompleted = new System.Threading.SendOrPostCallback(this.OnYzToJzjSetChangeIntrgralOperationCompleted);
            }
            this.InvokeAsync("YzToJzjSetChangeIntrgral", new object[] {
                        json}, this.YzToJzjSetChangeIntrgralOperationCompleted, userState);
        }
        
        private void OnYzToJzjSetChangeIntrgralOperationCompleted(object arg) {
            if ((this.YzToJzjSetChangeIntrgralCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.YzToJzjSetChangeIntrgralCompleted(this, new YzToJzjSetChangeIntrgralCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/YzToJzjUpdateAssocioter", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string YzToJzjUpdateAssocioter(string json) {
            object[] results = this.Invoke("YzToJzjUpdateAssocioter", new object[] {
                        json});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void YzToJzjUpdateAssocioterAsync(string json) {
            this.YzToJzjUpdateAssocioterAsync(json, null);
        }
        
        /// <remarks/>
        public void YzToJzjUpdateAssocioterAsync(string json, object userState) {
            if ((this.YzToJzjUpdateAssocioterOperationCompleted == null)) {
                this.YzToJzjUpdateAssocioterOperationCompleted = new System.Threading.SendOrPostCallback(this.OnYzToJzjUpdateAssocioterOperationCompleted);
            }
            this.InvokeAsync("YzToJzjUpdateAssocioter", new object[] {
                        json}, this.YzToJzjUpdateAssocioterOperationCompleted, userState);
        }
        
        private void OnYzToJzjUpdateAssocioterOperationCompleted(object arg) {
            if ((this.YzToJzjUpdateAssocioterCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.YzToJzjUpdateAssocioterCompleted(this, new YzToJzjUpdateAssocioterCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/YzToJzjSetVoucherState", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string YzToJzjSetVoucherState(string json) {
            object[] results = this.Invoke("YzToJzjSetVoucherState", new object[] {
                        json});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void YzToJzjSetVoucherStateAsync(string json) {
            this.YzToJzjSetVoucherStateAsync(json, null);
        }
        
        /// <remarks/>
        public void YzToJzjSetVoucherStateAsync(string json, object userState) {
            if ((this.YzToJzjSetVoucherStateOperationCompleted == null)) {
                this.YzToJzjSetVoucherStateOperationCompleted = new System.Threading.SendOrPostCallback(this.OnYzToJzjSetVoucherStateOperationCompleted);
            }
            this.InvokeAsync("YzToJzjSetVoucherState", new object[] {
                        json}, this.YzToJzjSetVoucherStateOperationCompleted, userState);
        }
        
        private void OnYzToJzjSetVoucherStateOperationCompleted(object arg) {
            if ((this.YzToJzjSetVoucherStateCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.YzToJzjSetVoucherStateCompleted(this, new YzToJzjSetVoucherStateCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetPrescriptionLabel", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetPrescriptionLabel(string json) {
            object[] results = this.Invoke("GetPrescriptionLabel", new object[] {
                        json});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetPrescriptionLabelAsync(string json) {
            this.GetPrescriptionLabelAsync(json, null);
        }
        
        /// <remarks/>
        public void GetPrescriptionLabelAsync(string json, object userState) {
            if ((this.GetPrescriptionLabelOperationCompleted == null)) {
                this.GetPrescriptionLabelOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetPrescriptionLabelOperationCompleted);
            }
            this.InvokeAsync("GetPrescriptionLabel", new object[] {
                        json}, this.GetPrescriptionLabelOperationCompleted, userState);
        }
        
        private void OnGetPrescriptionLabelOperationCompleted(object arg) {
            if ((this.GetPrescriptionLabelCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetPrescriptionLabelCompleted(this, new GetPrescriptionLabelCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void SetPrescriptionInfoCompletedEventHandler(object sender, SetPrescriptionInfoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SetPrescriptionInfoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SetPrescriptionInfoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void GetAuditStateCompletedEventHandler(object sender, GetAuditStateCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetAuditStateCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetAuditStateCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void GetAssocioterCompletedEventHandler(object sender, GetAssocioterCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetAssocioterCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetAssocioterCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void GetIntrgralCompletedEventHandler(object sender, GetIntrgralCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetIntrgralCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetIntrgralCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void GetChangeIntrgralDetailCompletedEventHandler(object sender, GetChangeIntrgralDetailCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetChangeIntrgralDetailCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetChangeIntrgralDetailCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void YzToJzjSetChangeIntrgralCompletedEventHandler(object sender, YzToJzjSetChangeIntrgralCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class YzToJzjSetChangeIntrgralCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal YzToJzjSetChangeIntrgralCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void YzToJzjUpdateAssocioterCompletedEventHandler(object sender, YzToJzjUpdateAssocioterCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class YzToJzjUpdateAssocioterCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal YzToJzjUpdateAssocioterCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void YzToJzjSetVoucherStateCompletedEventHandler(object sender, YzToJzjSetVoucherStateCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class YzToJzjSetVoucherStateCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal YzToJzjSetVoucherStateCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void GetPrescriptionLabelCompletedEventHandler(object sender, GetPrescriptionLabelCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetPrescriptionLabelCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetPrescriptionLabelCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
}

#pragma warning restore 1591