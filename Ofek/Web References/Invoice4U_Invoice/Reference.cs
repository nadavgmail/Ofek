﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace Ofek.Invoice4U_Invoice {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Data;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="w_invoiceSoap", Namespace="http://tempuri.org/BillWebService/w_invoice")]
    public partial class w_invoice : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback SENDOperationCompleted;
        
        private System.Threading.SendOrPostCallback CREATEOperationCompleted;
        
        private System.Threading.SendOrPostCallback CREATE101OperationCompleted;
        
        private System.Threading.SendOrPostCallback CREATE102OperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public w_invoice() {
            this.Url = global::Ofek.Properties.Settings.Default.Ofek_Invoice4U_Invoice_w_invoice;
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
        public event SENDCompletedEventHandler SENDCompleted;
        
        /// <remarks/>
        public event CREATECompletedEventHandler CREATECompleted;
        
        /// <remarks/>
        public event CREATE101CompletedEventHandler CREATE101Completed;
        
        /// <remarks/>
        public event CREATE102CompletedEventHandler CREATE102Completed;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/BillWebService/w_invoice/SEND", RequestNamespace="http://tempuri.org/BillWebService/w_invoice", ResponseNamespace="http://tempuri.org/BillWebService/w_invoice", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet SEND(string Username, string Key, string InvoiceNumber, string MailTo) {
            object[] results = this.Invoke("SEND", new object[] {
                        Username,
                        Key,
                        InvoiceNumber,
                        MailTo});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void SENDAsync(string Username, string Key, string InvoiceNumber, string MailTo) {
            this.SENDAsync(Username, Key, InvoiceNumber, MailTo, null);
        }
        
        /// <remarks/>
        public void SENDAsync(string Username, string Key, string InvoiceNumber, string MailTo, object userState) {
            if ((this.SENDOperationCompleted == null)) {
                this.SENDOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSENDOperationCompleted);
            }
            this.InvokeAsync("SEND", new object[] {
                        Username,
                        Key,
                        InvoiceNumber,
                        MailTo}, this.SENDOperationCompleted, userState);
        }
        
        private void OnSENDOperationCompleted(object arg) {
            if ((this.SENDCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SENDCompleted(this, new SENDCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/BillWebService/w_invoice/CREATE", RequestNamespace="http://tempuri.org/BillWebService/w_invoice", ResponseNamespace="http://tempuri.org/BillWebService/w_invoice", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet CREATE(
                    string CurrencyTarget, 
                    string Username, 
                    string Key, 
                    string InvoiceSubject, 
                    string InvoiceDiscount, 
                    string InvoiceDiscountRate, 
                    string InvoiceItemCode, 
                    string InvoiceItemDescription, 
                    string InvoiceItemQuantity, 
                    string InvoiceItemPrice, 
                    string InvoiceTaxRate, 
                    string InvoiceComments, 
                    string InvoiceInternalComment, 
                    string InvoicePayByDate, 
                    string CompanyCode, 
                    string MailTo, 
                    string IsItemPriceWithTax) {
            object[] results = this.Invoke("CREATE", new object[] {
                        CurrencyTarget,
                        Username,
                        Key,
                        InvoiceSubject,
                        InvoiceDiscount,
                        InvoiceDiscountRate,
                        InvoiceItemCode,
                        InvoiceItemDescription,
                        InvoiceItemQuantity,
                        InvoiceItemPrice,
                        InvoiceTaxRate,
                        InvoiceComments,
                        InvoiceInternalComment,
                        InvoicePayByDate,
                        CompanyCode,
                        MailTo,
                        IsItemPriceWithTax});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void CREATEAsync(
                    string CurrencyTarget, 
                    string Username, 
                    string Key, 
                    string InvoiceSubject, 
                    string InvoiceDiscount, 
                    string InvoiceDiscountRate, 
                    string InvoiceItemCode, 
                    string InvoiceItemDescription, 
                    string InvoiceItemQuantity, 
                    string InvoiceItemPrice, 
                    string InvoiceTaxRate, 
                    string InvoiceComments, 
                    string InvoiceInternalComment, 
                    string InvoicePayByDate, 
                    string CompanyCode, 
                    string MailTo, 
                    string IsItemPriceWithTax) {
            this.CREATEAsync(CurrencyTarget, Username, Key, InvoiceSubject, InvoiceDiscount, InvoiceDiscountRate, InvoiceItemCode, InvoiceItemDescription, InvoiceItemQuantity, InvoiceItemPrice, InvoiceTaxRate, InvoiceComments, InvoiceInternalComment, InvoicePayByDate, CompanyCode, MailTo, IsItemPriceWithTax, null);
        }
        
        /// <remarks/>
        public void CREATEAsync(
                    string CurrencyTarget, 
                    string Username, 
                    string Key, 
                    string InvoiceSubject, 
                    string InvoiceDiscount, 
                    string InvoiceDiscountRate, 
                    string InvoiceItemCode, 
                    string InvoiceItemDescription, 
                    string InvoiceItemQuantity, 
                    string InvoiceItemPrice, 
                    string InvoiceTaxRate, 
                    string InvoiceComments, 
                    string InvoiceInternalComment, 
                    string InvoicePayByDate, 
                    string CompanyCode, 
                    string MailTo, 
                    string IsItemPriceWithTax, 
                    object userState) {
            if ((this.CREATEOperationCompleted == null)) {
                this.CREATEOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCREATEOperationCompleted);
            }
            this.InvokeAsync("CREATE", new object[] {
                        CurrencyTarget,
                        Username,
                        Key,
                        InvoiceSubject,
                        InvoiceDiscount,
                        InvoiceDiscountRate,
                        InvoiceItemCode,
                        InvoiceItemDescription,
                        InvoiceItemQuantity,
                        InvoiceItemPrice,
                        InvoiceTaxRate,
                        InvoiceComments,
                        InvoiceInternalComment,
                        InvoicePayByDate,
                        CompanyCode,
                        MailTo,
                        IsItemPriceWithTax}, this.CREATEOperationCompleted, userState);
        }
        
        private void OnCREATEOperationCompleted(object arg) {
            if ((this.CREATECompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CREATECompleted(this, new CREATECompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/BillWebService/w_invoice/CREATE101", RequestNamespace="http://tempuri.org/BillWebService/w_invoice", ResponseNamespace="http://tempuri.org/BillWebService/w_invoice", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet CREATE101(
                    string CurrencyTarget, 
                    string Username, 
                    string Key, 
                    string InvoiceSubject, 
                    string InvoiceDiscount, 
                    string InvoiceDiscountRate, 
                    string InvoiceItemCode, 
                    string InvoiceItemDescription, 
                    string InvoiceItemQuantity, 
                    string InvoiceItemPrice, 
                    string InvoiceTaxRate, 
                    string InvoiceComments, 
                    string InvoiceInternalComment, 
                    string InvoicePayByDate, 
                    string CompanyCode, 
                    string MailTo, 
                    string IsItemPriceWithTax, 
                    string InvoiceDate) {
            object[] results = this.Invoke("CREATE101", new object[] {
                        CurrencyTarget,
                        Username,
                        Key,
                        InvoiceSubject,
                        InvoiceDiscount,
                        InvoiceDiscountRate,
                        InvoiceItemCode,
                        InvoiceItemDescription,
                        InvoiceItemQuantity,
                        InvoiceItemPrice,
                        InvoiceTaxRate,
                        InvoiceComments,
                        InvoiceInternalComment,
                        InvoicePayByDate,
                        CompanyCode,
                        MailTo,
                        IsItemPriceWithTax,
                        InvoiceDate});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void CREATE101Async(
                    string CurrencyTarget, 
                    string Username, 
                    string Key, 
                    string InvoiceSubject, 
                    string InvoiceDiscount, 
                    string InvoiceDiscountRate, 
                    string InvoiceItemCode, 
                    string InvoiceItemDescription, 
                    string InvoiceItemQuantity, 
                    string InvoiceItemPrice, 
                    string InvoiceTaxRate, 
                    string InvoiceComments, 
                    string InvoiceInternalComment, 
                    string InvoicePayByDate, 
                    string CompanyCode, 
                    string MailTo, 
                    string IsItemPriceWithTax, 
                    string InvoiceDate) {
            this.CREATE101Async(CurrencyTarget, Username, Key, InvoiceSubject, InvoiceDiscount, InvoiceDiscountRate, InvoiceItemCode, InvoiceItemDescription, InvoiceItemQuantity, InvoiceItemPrice, InvoiceTaxRate, InvoiceComments, InvoiceInternalComment, InvoicePayByDate, CompanyCode, MailTo, IsItemPriceWithTax, InvoiceDate, null);
        }
        
        /// <remarks/>
        public void CREATE101Async(
                    string CurrencyTarget, 
                    string Username, 
                    string Key, 
                    string InvoiceSubject, 
                    string InvoiceDiscount, 
                    string InvoiceDiscountRate, 
                    string InvoiceItemCode, 
                    string InvoiceItemDescription, 
                    string InvoiceItemQuantity, 
                    string InvoiceItemPrice, 
                    string InvoiceTaxRate, 
                    string InvoiceComments, 
                    string InvoiceInternalComment, 
                    string InvoicePayByDate, 
                    string CompanyCode, 
                    string MailTo, 
                    string IsItemPriceWithTax, 
                    string InvoiceDate, 
                    object userState) {
            if ((this.CREATE101OperationCompleted == null)) {
                this.CREATE101OperationCompleted = new System.Threading.SendOrPostCallback(this.OnCREATE101OperationCompleted);
            }
            this.InvokeAsync("CREATE101", new object[] {
                        CurrencyTarget,
                        Username,
                        Key,
                        InvoiceSubject,
                        InvoiceDiscount,
                        InvoiceDiscountRate,
                        InvoiceItemCode,
                        InvoiceItemDescription,
                        InvoiceItemQuantity,
                        InvoiceItemPrice,
                        InvoiceTaxRate,
                        InvoiceComments,
                        InvoiceInternalComment,
                        InvoicePayByDate,
                        CompanyCode,
                        MailTo,
                        IsItemPriceWithTax,
                        InvoiceDate}, this.CREATE101OperationCompleted, userState);
        }
        
        private void OnCREATE101OperationCompleted(object arg) {
            if ((this.CREATE101Completed != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CREATE101Completed(this, new CREATE101CompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/BillWebService/w_invoice/CREATE102", RequestNamespace="http://tempuri.org/BillWebService/w_invoice", ResponseNamespace="http://tempuri.org/BillWebService/w_invoice", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet CREATE102(
                    string CurrencyTarget, 
                    string Username, 
                    string Key, 
                    string InvoiceSubject, 
                    string InvoiceDiscount, 
                    string InvoiceDiscountRate, 
                    string InvoiceItemCode, 
                    string InvoiceItemDescription, 
                    string InvoiceItemQuantity, 
                    string InvoiceItemPrice, 
                    string InvoiceTaxRate, 
                    string InvoiceComments, 
                    string InvoiceInternalComment, 
                    string InvoicePayByDate, 
                    string CompanyCode, 
                    string MailTo, 
                    string IsItemPriceWithTax, 
                    string InvoiceDate, 
                    string InvoiceNumber) {
            object[] results = this.Invoke("CREATE102", new object[] {
                        CurrencyTarget,
                        Username,
                        Key,
                        InvoiceSubject,
                        InvoiceDiscount,
                        InvoiceDiscountRate,
                        InvoiceItemCode,
                        InvoiceItemDescription,
                        InvoiceItemQuantity,
                        InvoiceItemPrice,
                        InvoiceTaxRate,
                        InvoiceComments,
                        InvoiceInternalComment,
                        InvoicePayByDate,
                        CompanyCode,
                        MailTo,
                        IsItemPriceWithTax,
                        InvoiceDate,
                        InvoiceNumber});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void CREATE102Async(
                    string CurrencyTarget, 
                    string Username, 
                    string Key, 
                    string InvoiceSubject, 
                    string InvoiceDiscount, 
                    string InvoiceDiscountRate, 
                    string InvoiceItemCode, 
                    string InvoiceItemDescription, 
                    string InvoiceItemQuantity, 
                    string InvoiceItemPrice, 
                    string InvoiceTaxRate, 
                    string InvoiceComments, 
                    string InvoiceInternalComment, 
                    string InvoicePayByDate, 
                    string CompanyCode, 
                    string MailTo, 
                    string IsItemPriceWithTax, 
                    string InvoiceDate, 
                    string InvoiceNumber) {
            this.CREATE102Async(CurrencyTarget, Username, Key, InvoiceSubject, InvoiceDiscount, InvoiceDiscountRate, InvoiceItemCode, InvoiceItemDescription, InvoiceItemQuantity, InvoiceItemPrice, InvoiceTaxRate, InvoiceComments, InvoiceInternalComment, InvoicePayByDate, CompanyCode, MailTo, IsItemPriceWithTax, InvoiceDate, InvoiceNumber, null);
        }
        
        /// <remarks/>
        public void CREATE102Async(
                    string CurrencyTarget, 
                    string Username, 
                    string Key, 
                    string InvoiceSubject, 
                    string InvoiceDiscount, 
                    string InvoiceDiscountRate, 
                    string InvoiceItemCode, 
                    string InvoiceItemDescription, 
                    string InvoiceItemQuantity, 
                    string InvoiceItemPrice, 
                    string InvoiceTaxRate, 
                    string InvoiceComments, 
                    string InvoiceInternalComment, 
                    string InvoicePayByDate, 
                    string CompanyCode, 
                    string MailTo, 
                    string IsItemPriceWithTax, 
                    string InvoiceDate, 
                    string InvoiceNumber, 
                    object userState) {
            if ((this.CREATE102OperationCompleted == null)) {
                this.CREATE102OperationCompleted = new System.Threading.SendOrPostCallback(this.OnCREATE102OperationCompleted);
            }
            this.InvokeAsync("CREATE102", new object[] {
                        CurrencyTarget,
                        Username,
                        Key,
                        InvoiceSubject,
                        InvoiceDiscount,
                        InvoiceDiscountRate,
                        InvoiceItemCode,
                        InvoiceItemDescription,
                        InvoiceItemQuantity,
                        InvoiceItemPrice,
                        InvoiceTaxRate,
                        InvoiceComments,
                        InvoiceInternalComment,
                        InvoicePayByDate,
                        CompanyCode,
                        MailTo,
                        IsItemPriceWithTax,
                        InvoiceDate,
                        InvoiceNumber}, this.CREATE102OperationCompleted, userState);
        }
        
        private void OnCREATE102OperationCompleted(object arg) {
            if ((this.CREATE102Completed != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CREATE102Completed(this, new CREATE102CompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void SENDCompletedEventHandler(object sender, SENDCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SENDCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SENDCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void CREATECompletedEventHandler(object sender, CREATECompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CREATECompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal CREATECompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void CREATE101CompletedEventHandler(object sender, CREATE101CompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CREATE101CompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal CREATE101CompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void CREATE102CompletedEventHandler(object sender, CREATE102CompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CREATE102CompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal CREATE102CompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591