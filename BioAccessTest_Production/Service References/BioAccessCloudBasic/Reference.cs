﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BioAccessTest_Production.BioAccessCloudBasic {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DataStructures.LoginResponse", Namespace="http://schemas.datacontract.org/2004/07/WCFServiceWebRole1")]
    [System.SerializableAttribute()]
    public partial class DataStructuresLoginResponse : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CustomerIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ErrorMessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool LoginSuccessfulField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime RequestCompletedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SessionIdField;
        
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
        public int CustomerId {
            get {
                return this.CustomerIdField;
            }
            set {
                if ((this.CustomerIdField.Equals(value) != true)) {
                    this.CustomerIdField = value;
                    this.RaisePropertyChanged("CustomerId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ErrorMessage {
            get {
                return this.ErrorMessageField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorMessageField, value) != true)) {
                    this.ErrorMessageField = value;
                    this.RaisePropertyChanged("ErrorMessage");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool LoginSuccessful {
            get {
                return this.LoginSuccessfulField;
            }
            set {
                if ((this.LoginSuccessfulField.Equals(value) != true)) {
                    this.LoginSuccessfulField = value;
                    this.RaisePropertyChanged("LoginSuccessful");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime RequestCompleted {
            get {
                return this.RequestCompletedField;
            }
            set {
                if ((this.RequestCompletedField.Equals(value) != true)) {
                    this.RequestCompletedField = value;
                    this.RaisePropertyChanged("RequestCompleted");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SessionId {
            get {
                return this.SessionIdField;
            }
            set {
                if ((object.ReferenceEquals(this.SessionIdField, value) != true)) {
                    this.SessionIdField = value;
                    this.RaisePropertyChanged("SessionId");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="DataStructures.TemplateTypeBac", Namespace="http://schemas.datacontract.org/2004/07/WCFServiceWebRole1")]
    [System.SerializableAttribute()]
    public partial class DataStructuresTemplateTypeBac : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TemplateTypeIdField;
        
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
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TemplateTypeId {
            get {
                return this.TemplateTypeIdField;
            }
            set {
                if ((this.TemplateTypeIdField.Equals(value) != true)) {
                    this.TemplateTypeIdField = value;
                    this.RaisePropertyChanged("TemplateTypeId");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="DataStructures.SiteBac", Namespace="http://schemas.datacontract.org/2004/07/WCFServiceWebRole1")]
    [System.SerializableAttribute()]
    public partial class DataStructuresSiteBac : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.Guid> BioAccessIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CustomerIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LatitudeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LongitudeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SiteIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SiteNameField;
        
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
        public System.Nullable<System.Guid> BioAccessId {
            get {
                return this.BioAccessIdField;
            }
            set {
                if ((this.BioAccessIdField.Equals(value) != true)) {
                    this.BioAccessIdField = value;
                    this.RaisePropertyChanged("BioAccessId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CustomerId {
            get {
                return this.CustomerIdField;
            }
            set {
                if ((this.CustomerIdField.Equals(value) != true)) {
                    this.CustomerIdField = value;
                    this.RaisePropertyChanged("CustomerId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Latitude {
            get {
                return this.LatitudeField;
            }
            set {
                if ((object.ReferenceEquals(this.LatitudeField, value) != true)) {
                    this.LatitudeField = value;
                    this.RaisePropertyChanged("Latitude");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Longitude {
            get {
                return this.LongitudeField;
            }
            set {
                if ((object.ReferenceEquals(this.LongitudeField, value) != true)) {
                    this.LongitudeField = value;
                    this.RaisePropertyChanged("Longitude");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int SiteId {
            get {
                return this.SiteIdField;
            }
            set {
                if ((this.SiteIdField.Equals(value) != true)) {
                    this.SiteIdField = value;
                    this.RaisePropertyChanged("SiteId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SiteName {
            get {
                return this.SiteNameField;
            }
            set {
                if ((object.ReferenceEquals(this.SiteNameField, value) != true)) {
                    this.SiteNameField = value;
                    this.RaisePropertyChanged("SiteName");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="DataStructures.EmployeeBac", Namespace="http://schemas.datacontract.org/2004/07/WCFServiceWebRole1")]
    [System.SerializableAttribute()]
    public partial class DataStructuresEmployeeBac : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool ActiveField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.Guid> BioAccessIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CustomerIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int EmployeeIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RsaIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SurnameField;
        
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
        public bool Active {
            get {
                return this.ActiveField;
            }
            set {
                if ((this.ActiveField.Equals(value) != true)) {
                    this.ActiveField = value;
                    this.RaisePropertyChanged("Active");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.Guid> BioAccessId {
            get {
                return this.BioAccessIdField;
            }
            set {
                if ((this.BioAccessIdField.Equals(value) != true)) {
                    this.BioAccessIdField = value;
                    this.RaisePropertyChanged("BioAccessId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CustomerId {
            get {
                return this.CustomerIdField;
            }
            set {
                if ((this.CustomerIdField.Equals(value) != true)) {
                    this.CustomerIdField = value;
                    this.RaisePropertyChanged("CustomerId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int EmployeeId {
            get {
                return this.EmployeeIdField;
            }
            set {
                if ((this.EmployeeIdField.Equals(value) != true)) {
                    this.EmployeeIdField = value;
                    this.RaisePropertyChanged("EmployeeId");
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RsaId {
            get {
                return this.RsaIdField;
            }
            set {
                if ((object.ReferenceEquals(this.RsaIdField, value) != true)) {
                    this.RsaIdField = value;
                    this.RaisePropertyChanged("RsaId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Surname {
            get {
                return this.SurnameField;
            }
            set {
                if ((object.ReferenceEquals(this.SurnameField, value) != true)) {
                    this.SurnameField = value;
                    this.RaisePropertyChanged("Surname");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BioAccessCloudBasic.IBioAccessCloudBasic")]
    public interface IBioAccessCloudBasic {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBioAccessCloudBasic/Login", ReplyAction="http://tempuri.org/IBioAccessCloudBasic/LoginResponse")]
        BioAccessTest_Production.BioAccessCloudBasic.DataStructuresLoginResponse Login(string userName, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBioAccessCloudBasic/Login", ReplyAction="http://tempuri.org/IBioAccessCloudBasic/LoginResponse")]
        System.Threading.Tasks.Task<BioAccessTest_Production.BioAccessCloudBasic.DataStructuresLoginResponse> LoginAsync(string userName, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBioAccessCloudBasic/GetTemplateTypes", ReplyAction="http://tempuri.org/IBioAccessCloudBasic/GetTemplateTypesResponse")]
        BioAccessTest_Production.BioAccessCloudBasic.DataStructuresTemplateTypeBac[] GetTemplateTypes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBioAccessCloudBasic/GetTemplateTypes", ReplyAction="http://tempuri.org/IBioAccessCloudBasic/GetTemplateTypesResponse")]
        System.Threading.Tasks.Task<BioAccessTest_Production.BioAccessCloudBasic.DataStructuresTemplateTypeBac[]> GetTemplateTypesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBioAccessCloudBasic/GetSitesPerCustomer", ReplyAction="http://tempuri.org/IBioAccessCloudBasic/GetSitesPerCustomerResponse")]
        BioAccessTest_Production.BioAccessCloudBasic.DataStructuresSiteBac[] GetSitesPerCustomer(int customerId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBioAccessCloudBasic/GetSitesPerCustomer", ReplyAction="http://tempuri.org/IBioAccessCloudBasic/GetSitesPerCustomerResponse")]
        System.Threading.Tasks.Task<BioAccessTest_Production.BioAccessCloudBasic.DataStructuresSiteBac[]> GetSitesPerCustomerAsync(int customerId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBioAccessCloudBasic/GetEmployeesPerSite", ReplyAction="http://tempuri.org/IBioAccessCloudBasic/GetEmployeesPerSiteResponse")]
        BioAccessTest_Production.BioAccessCloudBasic.DataStructuresEmployeeBac[] GetEmployeesPerSite(int siteId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBioAccessCloudBasic/GetEmployeesPerSite", ReplyAction="http://tempuri.org/IBioAccessCloudBasic/GetEmployeesPerSiteResponse")]
        System.Threading.Tasks.Task<BioAccessTest_Production.BioAccessCloudBasic.DataStructuresEmployeeBac[]> GetEmployeesPerSiteAsync(int siteId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBioAccessCloudBasic/CreateUpdateSites", ReplyAction="http://tempuri.org/IBioAccessCloudBasic/CreateUpdateSitesResponse")]
        string CreateUpdateSites(BioAccessTest_Production.BioAccessCloudBasic.DataStructuresSiteBac[] sites);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBioAccessCloudBasic/CreateUpdateSites", ReplyAction="http://tempuri.org/IBioAccessCloudBasic/CreateUpdateSitesResponse")]
        System.Threading.Tasks.Task<string> CreateUpdateSitesAsync(BioAccessTest_Production.BioAccessCloudBasic.DataStructuresSiteBac[] sites);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBioAccessCloudBasicChannel : BioAccessTest_Production.BioAccessCloudBasic.IBioAccessCloudBasic, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BioAccessCloudBasicClient : System.ServiceModel.ClientBase<BioAccessTest_Production.BioAccessCloudBasic.IBioAccessCloudBasic>, BioAccessTest_Production.BioAccessCloudBasic.IBioAccessCloudBasic {
        
        public BioAccessCloudBasicClient() {
        }
        
        public BioAccessCloudBasicClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BioAccessCloudBasicClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BioAccessCloudBasicClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BioAccessCloudBasicClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public BioAccessTest_Production.BioAccessCloudBasic.DataStructuresLoginResponse Login(string userName, string password) {
            return base.Channel.Login(userName, password);
        }
        
        public System.Threading.Tasks.Task<BioAccessTest_Production.BioAccessCloudBasic.DataStructuresLoginResponse> LoginAsync(string userName, string password) {
            return base.Channel.LoginAsync(userName, password);
        }
        
        public BioAccessTest_Production.BioAccessCloudBasic.DataStructuresTemplateTypeBac[] GetTemplateTypes() {
            return base.Channel.GetTemplateTypes();
        }
        
        public System.Threading.Tasks.Task<BioAccessTest_Production.BioAccessCloudBasic.DataStructuresTemplateTypeBac[]> GetTemplateTypesAsync() {
            return base.Channel.GetTemplateTypesAsync();
        }
        
        public BioAccessTest_Production.BioAccessCloudBasic.DataStructuresSiteBac[] GetSitesPerCustomer(int customerId) {
            return base.Channel.GetSitesPerCustomer(customerId);
        }
        
        public System.Threading.Tasks.Task<BioAccessTest_Production.BioAccessCloudBasic.DataStructuresSiteBac[]> GetSitesPerCustomerAsync(int customerId) {
            return base.Channel.GetSitesPerCustomerAsync(customerId);
        }
        
        public BioAccessTest_Production.BioAccessCloudBasic.DataStructuresEmployeeBac[] GetEmployeesPerSite(int siteId) {
            return base.Channel.GetEmployeesPerSite(siteId);
        }
        
        public System.Threading.Tasks.Task<BioAccessTest_Production.BioAccessCloudBasic.DataStructuresEmployeeBac[]> GetEmployeesPerSiteAsync(int siteId) {
            return base.Channel.GetEmployeesPerSiteAsync(siteId);
        }
        
        public string CreateUpdateSites(BioAccessTest_Production.BioAccessCloudBasic.DataStructuresSiteBac[] sites) {
            return base.Channel.CreateUpdateSites(sites);
        }
        
        public System.Threading.Tasks.Task<string> CreateUpdateSitesAsync(BioAccessTest_Production.BioAccessCloudBasic.DataStructuresSiteBac[] sites) {
            return base.Channel.CreateUpdateSitesAsync(sites);
        }
    }
}