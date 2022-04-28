﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsPrinter.ServiceReferencePrinter {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/DTO")]
    [System.SerializableAttribute()]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int userAmountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int userIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string userNameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int userAmount {
            get {
                return this.userAmountField;
            }
            set {
                if ((this.userAmountField.Equals(value) != true)) {
                    this.userAmountField = value;
                    this.RaisePropertyChanged("userAmount");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int userId {
            get {
                return this.userIdField;
            }
            set {
                if ((this.userIdField.Equals(value) != true)) {
                    this.userIdField = value;
                    this.RaisePropertyChanged("userId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string userName {
            get {
                return this.userNameField;
            }
            set {
                if ((object.ReferenceEquals(this.userNameField, value) != true)) {
                    this.userNameField = value;
                    this.RaisePropertyChanged("userName");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferencePrinter.IPrinter")]
    public interface IPrinter {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPrinter/GetAmountByUserId", ReplyAction="http://tempuri.org/IPrinter/GetAmountByUserIdResponse")]
        int GetAmountByUserId(int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPrinter/GetAmountByUserId", ReplyAction="http://tempuri.org/IPrinter/GetAmountByUserIdResponse")]
        System.Threading.Tasks.Task<int> GetAmountByUserIdAsync(int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPrinter/GetAmountByUsername", ReplyAction="http://tempuri.org/IPrinter/GetAmountByUsernameResponse")]
        int GetAmountByUsername(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPrinter/GetAmountByUsername", ReplyAction="http://tempuri.org/IPrinter/GetAmountByUsernameResponse")]
        System.Threading.Tasks.Task<int> GetAmountByUsernameAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPrinter/AddAmountByUserId", ReplyAction="http://tempuri.org/IPrinter/AddAmountByUserIdResponse")]
        WindowsFormsPrinter.ServiceReferencePrinter.User AddAmountByUserId(int userId, int amount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPrinter/AddAmountByUserId", ReplyAction="http://tempuri.org/IPrinter/AddAmountByUserIdResponse")]
        System.Threading.Tasks.Task<WindowsFormsPrinter.ServiceReferencePrinter.User> AddAmountByUserIdAsync(int userId, int amount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPrinter/AddAmountByUsername", ReplyAction="http://tempuri.org/IPrinter/AddAmountByUsernameResponse")]
        WindowsFormsPrinter.ServiceReferencePrinter.User AddAmountByUsername(string username, int amount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPrinter/AddAmountByUsername", ReplyAction="http://tempuri.org/IPrinter/AddAmountByUsernameResponse")]
        System.Threading.Tasks.Task<WindowsFormsPrinter.ServiceReferencePrinter.User> AddAmountByUsernameAsync(string username, int amount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPrinter/Conversion", ReplyAction="http://tempuri.org/IPrinter/ConversionResponse")]
        int Conversion(int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPrinter/Conversion", ReplyAction="http://tempuri.org/IPrinter/ConversionResponse")]
        System.Threading.Tasks.Task<int> ConversionAsync(int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPrinter/ConversionByUsername", ReplyAction="http://tempuri.org/IPrinter/ConversionByUsernameResponse")]
        int ConversionByUsername(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPrinter/ConversionByUsername", ReplyAction="http://tempuri.org/IPrinter/ConversionByUsernameResponse")]
        System.Threading.Tasks.Task<int> ConversionByUsernameAsync(string username);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPrinterChannel : WindowsFormsPrinter.ServiceReferencePrinter.IPrinter, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PrinterClient : System.ServiceModel.ClientBase<WindowsFormsPrinter.ServiceReferencePrinter.IPrinter>, WindowsFormsPrinter.ServiceReferencePrinter.IPrinter {
        
        public PrinterClient() {
        }
        
        public PrinterClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PrinterClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PrinterClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PrinterClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int GetAmountByUserId(int userId) {
            return base.Channel.GetAmountByUserId(userId);
        }
        
        public System.Threading.Tasks.Task<int> GetAmountByUserIdAsync(int userId) {
            return base.Channel.GetAmountByUserIdAsync(userId);
        }
        
        public int GetAmountByUsername(string username) {
            return base.Channel.GetAmountByUsername(username);
        }
        
        public System.Threading.Tasks.Task<int> GetAmountByUsernameAsync(string username) {
            return base.Channel.GetAmountByUsernameAsync(username);
        }
        
        public WindowsFormsPrinter.ServiceReferencePrinter.User AddAmountByUserId(int userId, int amount) {
            return base.Channel.AddAmountByUserId(userId, amount);
        }
        
        public System.Threading.Tasks.Task<WindowsFormsPrinter.ServiceReferencePrinter.User> AddAmountByUserIdAsync(int userId, int amount) {
            return base.Channel.AddAmountByUserIdAsync(userId, amount);
        }
        
        public WindowsFormsPrinter.ServiceReferencePrinter.User AddAmountByUsername(string username, int amount) {
            return base.Channel.AddAmountByUsername(username, amount);
        }
        
        public System.Threading.Tasks.Task<WindowsFormsPrinter.ServiceReferencePrinter.User> AddAmountByUsernameAsync(string username, int amount) {
            return base.Channel.AddAmountByUsernameAsync(username, amount);
        }
        
        public int Conversion(int userId) {
            return base.Channel.Conversion(userId);
        }
        
        public System.Threading.Tasks.Task<int> ConversionAsync(int userId) {
            return base.Channel.ConversionAsync(userId);
        }
        
        public int ConversionByUsername(string username) {
            return base.Channel.ConversionByUsername(username);
        }
        
        public System.Threading.Tasks.Task<int> ConversionByUsernameAsync(string username) {
            return base.Channel.ConversionByUsernameAsync(username);
        }
    }
}
