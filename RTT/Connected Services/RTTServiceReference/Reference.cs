﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RTT.RTTServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Client", Namespace="http://schemas.datacontract.org/2004/07/RTTWcfService.Models")]
    [System.SerializableAttribute()]
    public partial class Client : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ClientIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GenderField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NationalityField;
        
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
        public int ClientID {
            get {
                return this.ClientIDField;
            }
            set {
                if ((this.ClientIDField.Equals(value) != true)) {
                    this.ClientIDField = value;
                    this.RaisePropertyChanged("ClientID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Gender {
            get {
                return this.GenderField;
            }
            set {
                if ((object.ReferenceEquals(this.GenderField, value) != true)) {
                    this.GenderField = value;
                    this.RaisePropertyChanged("Gender");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdNumber {
            get {
                return this.IdNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.IdNumberField, value) != true)) {
                    this.IdNumberField = value;
                    this.RaisePropertyChanged("IdNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nationality {
            get {
                return this.NationalityField;
            }
            set {
                if ((object.ReferenceEquals(this.NationalityField, value) != true)) {
                    this.NationalityField = value;
                    this.RaisePropertyChanged("Nationality");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Address", Namespace="http://schemas.datacontract.org/2004/07/RTTWcfService.Models")]
    [System.SerializableAttribute()]
    public partial class Address : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AddressIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ClientIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PostalAddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ResidentialAddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string WorkAddressField;
        
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
        public int AddressID {
            get {
                return this.AddressIDField;
            }
            set {
                if ((this.AddressIDField.Equals(value) != true)) {
                    this.AddressIDField = value;
                    this.RaisePropertyChanged("AddressID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ClientID {
            get {
                return this.ClientIDField;
            }
            set {
                if ((this.ClientIDField.Equals(value) != true)) {
                    this.ClientIDField = value;
                    this.RaisePropertyChanged("ClientID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PostalAddress {
            get {
                return this.PostalAddressField;
            }
            set {
                if ((object.ReferenceEquals(this.PostalAddressField, value) != true)) {
                    this.PostalAddressField = value;
                    this.RaisePropertyChanged("PostalAddress");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ResidentialAddress {
            get {
                return this.ResidentialAddressField;
            }
            set {
                if ((object.ReferenceEquals(this.ResidentialAddressField, value) != true)) {
                    this.ResidentialAddressField = value;
                    this.RaisePropertyChanged("ResidentialAddress");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string WorkAddress {
            get {
                return this.WorkAddressField;
            }
            set {
                if ((object.ReferenceEquals(this.WorkAddressField, value) != true)) {
                    this.WorkAddressField = value;
                    this.RaisePropertyChanged("WorkAddress");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Contact", Namespace="http://schemas.datacontract.org/2004/07/RTTWcfService.Models")]
    [System.SerializableAttribute()]
    public partial class Contact : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CellPhoneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ClientIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ContactIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HomePhoneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string WorkPhoneField;
        
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
        public string CellPhone {
            get {
                return this.CellPhoneField;
            }
            set {
                if ((object.ReferenceEquals(this.CellPhoneField, value) != true)) {
                    this.CellPhoneField = value;
                    this.RaisePropertyChanged("CellPhone");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ClientID {
            get {
                return this.ClientIDField;
            }
            set {
                if ((this.ClientIDField.Equals(value) != true)) {
                    this.ClientIDField = value;
                    this.RaisePropertyChanged("ClientID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ContactID {
            get {
                return this.ContactIDField;
            }
            set {
                if ((this.ContactIDField.Equals(value) != true)) {
                    this.ContactIDField = value;
                    this.RaisePropertyChanged("ContactID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string HomePhone {
            get {
                return this.HomePhoneField;
            }
            set {
                if ((object.ReferenceEquals(this.HomePhoneField, value) != true)) {
                    this.HomePhoneField = value;
                    this.RaisePropertyChanged("HomePhone");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string WorkPhone {
            get {
                return this.WorkPhoneField;
            }
            set {
                if ((object.ReferenceEquals(this.WorkPhoneField, value) != true)) {
                    this.WorkPhoneField = value;
                    this.RaisePropertyChanged("WorkPhone");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="RTTServiceReference.IClient")]
    public interface IClient {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClient/InsertClient", ReplyAction="http://tempuri.org/IClient/InsertClientResponse")]
        string InsertClient(RTT.RTTServiceReference.Client client, RTT.RTTServiceReference.Address address, RTT.RTTServiceReference.Contact contact);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClient/InsertClient", ReplyAction="http://tempuri.org/IClient/InsertClientResponse")]
        System.Threading.Tasks.Task<string> InsertClientAsync(RTT.RTTServiceReference.Client client, RTT.RTTServiceReference.Address address, RTT.RTTServiceReference.Contact contact);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClient/GetClient", ReplyAction="http://tempuri.org/IClient/GetClientResponse")]
        System.Data.DataSet GetClient(int clientID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClient/GetClient", ReplyAction="http://tempuri.org/IClient/GetClientResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetClientAsync(int clientID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClient/GetClients", ReplyAction="http://tempuri.org/IClient/GetClientsResponse")]
        System.Data.DataSet GetClients();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClient/GetClients", ReplyAction="http://tempuri.org/IClient/GetClientsResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetClientsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClient/UpdateClient", ReplyAction="http://tempuri.org/IClient/UpdateClientResponse")]
        int UpdateClient(int clientID, RTT.RTTServiceReference.Client client, RTT.RTTServiceReference.Address address, RTT.RTTServiceReference.Contact contact);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClient/UpdateClient", ReplyAction="http://tempuri.org/IClient/UpdateClientResponse")]
        System.Threading.Tasks.Task<int> UpdateClientAsync(int clientID, RTT.RTTServiceReference.Client client, RTT.RTTServiceReference.Address address, RTT.RTTServiceReference.Contact contact);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClient/DeleteteClient", ReplyAction="http://tempuri.org/IClient/DeleteteClientResponse")]
        int DeleteteClient(int clientID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClient/DeleteteClient", ReplyAction="http://tempuri.org/IClient/DeleteteClientResponse")]
        System.Threading.Tasks.Task<int> DeleteteClientAsync(int clientID);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IClientChannel : RTT.RTTServiceReference.IClient, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ClientClient : System.ServiceModel.ClientBase<RTT.RTTServiceReference.IClient>, RTT.RTTServiceReference.IClient {
        
        public ClientClient() {
        }
        
        public ClientClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ClientClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ClientClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ClientClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string InsertClient(RTT.RTTServiceReference.Client client, RTT.RTTServiceReference.Address address, RTT.RTTServiceReference.Contact contact) {
            return base.Channel.InsertClient(client, address, contact);
        }
        
        public System.Threading.Tasks.Task<string> InsertClientAsync(RTT.RTTServiceReference.Client client, RTT.RTTServiceReference.Address address, RTT.RTTServiceReference.Contact contact) {
            return base.Channel.InsertClientAsync(client, address, contact);
        }
        
        public System.Data.DataSet GetClient(int clientID) {
            return base.Channel.GetClient(clientID);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetClientAsync(int clientID) {
            return base.Channel.GetClientAsync(clientID);
        }
        
        public System.Data.DataSet GetClients() {
            return base.Channel.GetClients();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetClientsAsync() {
            return base.Channel.GetClientsAsync();
        }
        
        public int UpdateClient(int clientID, RTT.RTTServiceReference.Client client, RTT.RTTServiceReference.Address address, RTT.RTTServiceReference.Contact contact) {
            return base.Channel.UpdateClient(clientID, client, address, contact);
        }
        
        public System.Threading.Tasks.Task<int> UpdateClientAsync(int clientID, RTT.RTTServiceReference.Client client, RTT.RTTServiceReference.Address address, RTT.RTTServiceReference.Contact contact) {
            return base.Channel.UpdateClientAsync(clientID, client, address, contact);
        }
        
        public int DeleteteClient(int clientID) {
            return base.Channel.DeleteteClient(clientID);
        }
        
        public System.Threading.Tasks.Task<int> DeleteteClientAsync(int clientID) {
            return base.Channel.DeleteteClientAsync(clientID);
        }
    }
}
