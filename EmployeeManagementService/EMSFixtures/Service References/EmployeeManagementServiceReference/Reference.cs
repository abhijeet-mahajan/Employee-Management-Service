﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18063
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EMSFixtures.EmployeeManagementServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EmployeeDetails", Namespace="http://schemas.datacontract.org/2004/07/EmployeeManagementService")]
    [System.SerializableAttribute()]
    public partial class EmployeeDetails : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private EMSFixtures.EmployeeManagementServiceReference.Remark[] EmployeeRemarkField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
        public string EmailId {
            get {
                return this.EmailIdField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailIdField, value) != true)) {
                    this.EmailIdField = value;
                    this.RaisePropertyChanged("EmailId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public EMSFixtures.EmployeeManagementServiceReference.Remark[] EmployeeRemark {
            get {
                return this.EmployeeRemarkField;
            }
            set {
                if ((object.ReferenceEquals(this.EmployeeRemarkField, value) != true)) {
                    this.EmployeeRemarkField = value;
                    this.RaisePropertyChanged("EmployeeRemark");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Id {
            get {
                return this.IdField;
            }
            set {
                if ((object.ReferenceEquals(this.IdField, value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Remark", Namespace="http://schemas.datacontract.org/2004/07/EmployeeManagementService")]
    [System.SerializableAttribute()]
    public partial class Remark : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TextField;
        
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
        public System.DateTime DateTime {
            get {
                return this.DateTimeField;
            }
            set {
                if ((this.DateTimeField.Equals(value) != true)) {
                    this.DateTimeField = value;
                    this.RaisePropertyChanged("DateTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Text {
            get {
                return this.TextField;
            }
            set {
                if ((object.ReferenceEquals(this.TextField, value) != true)) {
                    this.TextField = value;
                    this.RaisePropertyChanged("Text");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EmployeeManagementServiceReference.ICreateEmployeeDetails")]
    public interface ICreateEmployeeDetails {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICreateEmployeeDetails/AddEmployeeDetails", ReplyAction="http://tempuri.org/ICreateEmployeeDetails/AddEmployeeDetailsResponse")]
        void AddEmployeeDetails(string employeeId, string name, string employeeEmailId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICreateEmployeeDetails/AddEmployeeDetails", ReplyAction="http://tempuri.org/ICreateEmployeeDetails/AddEmployeeDetailsResponse")]
        System.Threading.Tasks.Task AddEmployeeDetailsAsync(string employeeId, string name, string employeeEmailId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICreateEmployeeDetails/RemoveEmployeeDetails", ReplyAction="http://tempuri.org/ICreateEmployeeDetails/RemoveEmployeeDetailsResponse")]
        void RemoveEmployeeDetails(string employeeId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICreateEmployeeDetails/RemoveEmployeeDetails", ReplyAction="http://tempuri.org/ICreateEmployeeDetails/RemoveEmployeeDetailsResponse")]
        System.Threading.Tasks.Task RemoveEmployeeDetailsAsync(string employeeId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICreateEmployeeDetails/AddRemarkTOEmployee", ReplyAction="http://tempuri.org/ICreateEmployeeDetails/AddRemarkTOEmployeeResponse")]
        void AddRemarkTOEmployee(string employeeId, string text);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICreateEmployeeDetails/AddRemarkTOEmployee", ReplyAction="http://tempuri.org/ICreateEmployeeDetails/AddRemarkTOEmployeeResponse")]
        System.Threading.Tasks.Task AddRemarkTOEmployeeAsync(string employeeId, string text);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICreateEmployeeDetailsChannel : EMSFixtures.EmployeeManagementServiceReference.ICreateEmployeeDetails, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CreateEmployeeDetailsClient : System.ServiceModel.ClientBase<EMSFixtures.EmployeeManagementServiceReference.ICreateEmployeeDetails>, EMSFixtures.EmployeeManagementServiceReference.ICreateEmployeeDetails {
        
        public CreateEmployeeDetailsClient() {
        }
        
        public CreateEmployeeDetailsClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CreateEmployeeDetailsClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CreateEmployeeDetailsClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CreateEmployeeDetailsClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void AddEmployeeDetails(string employeeId, string name, string employeeEmailId) {
            base.Channel.AddEmployeeDetails(employeeId, name, employeeEmailId);
        }
        
        public System.Threading.Tasks.Task AddEmployeeDetailsAsync(string employeeId, string name, string employeeEmailId) {
            return base.Channel.AddEmployeeDetailsAsync(employeeId, name, employeeEmailId);
        }
        
        public void RemoveEmployeeDetails(string employeeId) {
            base.Channel.RemoveEmployeeDetails(employeeId);
        }
        
        public System.Threading.Tasks.Task RemoveEmployeeDetailsAsync(string employeeId) {
            return base.Channel.RemoveEmployeeDetailsAsync(employeeId);
        }
        
        public void AddRemarkTOEmployee(string employeeId, string text) {
            base.Channel.AddRemarkTOEmployee(employeeId, text);
        }
        
        public System.Threading.Tasks.Task AddRemarkTOEmployeeAsync(string employeeId, string text) {
            return base.Channel.AddRemarkTOEmployeeAsync(employeeId, text);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EmployeeManagementServiceReference.IRetrieveEmployeeDeatils")]
    public interface IRetrieveEmployeeDeatils {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRetrieveEmployeeDeatils/GetEmployeeDetails", ReplyAction="http://tempuri.org/IRetrieveEmployeeDeatils/GetEmployeeDetailsResponse")]
        EMSFixtures.EmployeeManagementServiceReference.EmployeeDetails GetEmployeeDetails(string employeeId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRetrieveEmployeeDeatils/GetEmployeeDetails", ReplyAction="http://tempuri.org/IRetrieveEmployeeDeatils/GetEmployeeDetailsResponse")]
        System.Threading.Tasks.Task<EMSFixtures.EmployeeManagementServiceReference.EmployeeDetails> GetEmployeeDetailsAsync(string employeeId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRetrieveEmployeeDeatils/GetAllEmployeeDetails", ReplyAction="http://tempuri.org/IRetrieveEmployeeDeatils/GetAllEmployeeDetailsResponse")]
        EMSFixtures.EmployeeManagementServiceReference.EmployeeDetails[] GetAllEmployeeDetails();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRetrieveEmployeeDeatils/GetAllEmployeeDetails", ReplyAction="http://tempuri.org/IRetrieveEmployeeDeatils/GetAllEmployeeDetailsResponse")]
        System.Threading.Tasks.Task<EMSFixtures.EmployeeManagementServiceReference.EmployeeDetails[]> GetAllEmployeeDetailsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRetrieveEmployeeDeatils/GetEmployeeDetailsByName", ReplyAction="http://tempuri.org/IRetrieveEmployeeDeatils/GetEmployeeDetailsByNameResponse")]
        EMSFixtures.EmployeeManagementServiceReference.EmployeeDetails[] GetEmployeeDetailsByName(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRetrieveEmployeeDeatils/GetEmployeeDetailsByName", ReplyAction="http://tempuri.org/IRetrieveEmployeeDeatils/GetEmployeeDetailsByNameResponse")]
        System.Threading.Tasks.Task<EMSFixtures.EmployeeManagementServiceReference.EmployeeDetails[]> GetEmployeeDetailsByNameAsync(string name);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IRetrieveEmployeeDeatilsChannel : EMSFixtures.EmployeeManagementServiceReference.IRetrieveEmployeeDeatils, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RetrieveEmployeeDeatilsClient : System.ServiceModel.ClientBase<EMSFixtures.EmployeeManagementServiceReference.IRetrieveEmployeeDeatils>, EMSFixtures.EmployeeManagementServiceReference.IRetrieveEmployeeDeatils {
        
        public RetrieveEmployeeDeatilsClient() {
        }
        
        public RetrieveEmployeeDeatilsClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public RetrieveEmployeeDeatilsClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RetrieveEmployeeDeatilsClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RetrieveEmployeeDeatilsClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public EMSFixtures.EmployeeManagementServiceReference.EmployeeDetails GetEmployeeDetails(string employeeId) {
            return base.Channel.GetEmployeeDetails(employeeId);
        }
        
        public System.Threading.Tasks.Task<EMSFixtures.EmployeeManagementServiceReference.EmployeeDetails> GetEmployeeDetailsAsync(string employeeId) {
            return base.Channel.GetEmployeeDetailsAsync(employeeId);
        }
        
        public EMSFixtures.EmployeeManagementServiceReference.EmployeeDetails[] GetAllEmployeeDetails() {
            return base.Channel.GetAllEmployeeDetails();
        }
        
        public System.Threading.Tasks.Task<EMSFixtures.EmployeeManagementServiceReference.EmployeeDetails[]> GetAllEmployeeDetailsAsync() {
            return base.Channel.GetAllEmployeeDetailsAsync();
        }
        
        public EMSFixtures.EmployeeManagementServiceReference.EmployeeDetails[] GetEmployeeDetailsByName(string name) {
            return base.Channel.GetEmployeeDetailsByName(name);
        }
        
        public System.Threading.Tasks.Task<EMSFixtures.EmployeeManagementServiceReference.EmployeeDetails[]> GetEmployeeDetailsByNameAsync(string name) {
            return base.Channel.GetEmployeeDetailsByNameAsync(name);
        }
    }
}
