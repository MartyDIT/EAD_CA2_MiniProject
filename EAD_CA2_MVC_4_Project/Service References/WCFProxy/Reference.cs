﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCGridView.WCFProxy {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="StudentContract", Namespace="http://schemas.datacontract.org/2004/07/EAD_WCF_Webservice")]
    [System.SerializableAttribute()]
    public partial class StudentContract : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> DateOfBirthField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal HeightField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OtherDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] PhotoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private MVCGridView.WCFProxy.StandardContract StandardField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int StudentIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StudentNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float WeightField;
        
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
        public System.Nullable<System.DateTime> DateOfBirth {
            get {
                return this.DateOfBirthField;
            }
            set {
                if ((this.DateOfBirthField.Equals(value) != true)) {
                    this.DateOfBirthField = value;
                    this.RaisePropertyChanged("DateOfBirth");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Height {
            get {
                return this.HeightField;
            }
            set {
                if ((this.HeightField.Equals(value) != true)) {
                    this.HeightField = value;
                    this.RaisePropertyChanged("Height");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string OtherData {
            get {
                return this.OtherDataField;
            }
            set {
                if ((object.ReferenceEquals(this.OtherDataField, value) != true)) {
                    this.OtherDataField = value;
                    this.RaisePropertyChanged("OtherData");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] Photo {
            get {
                return this.PhotoField;
            }
            set {
                if ((object.ReferenceEquals(this.PhotoField, value) != true)) {
                    this.PhotoField = value;
                    this.RaisePropertyChanged("Photo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public MVCGridView.WCFProxy.StandardContract Standard {
            get {
                return this.StandardField;
            }
            set {
                if ((object.ReferenceEquals(this.StandardField, value) != true)) {
                    this.StandardField = value;
                    this.RaisePropertyChanged("Standard");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int StudentID {
            get {
                return this.StudentIDField;
            }
            set {
                if ((this.StudentIDField.Equals(value) != true)) {
                    this.StudentIDField = value;
                    this.RaisePropertyChanged("StudentID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StudentName {
            get {
                return this.StudentNameField;
            }
            set {
                if ((object.ReferenceEquals(this.StudentNameField, value) != true)) {
                    this.StudentNameField = value;
                    this.RaisePropertyChanged("StudentName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float Weight {
            get {
                return this.WeightField;
            }
            set {
                if ((this.WeightField.Equals(value) != true)) {
                    this.WeightField = value;
                    this.RaisePropertyChanged("Weight");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="StandardContract", Namespace="http://schemas.datacontract.org/2004/07/EAD_WCF_Webservice")]
    [System.SerializableAttribute()]
    public partial class StandardContract : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int StandardIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StandardNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<MVCGridView.WCFProxy.StudentContract> StudentsField;
        
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
        public int StandardId {
            get {
                return this.StandardIdField;
            }
            set {
                if ((this.StandardIdField.Equals(value) != true)) {
                    this.StandardIdField = value;
                    this.RaisePropertyChanged("StandardId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StandardName {
            get {
                return this.StandardNameField;
            }
            set {
                if ((object.ReferenceEquals(this.StandardNameField, value) != true)) {
                    this.StandardNameField = value;
                    this.RaisePropertyChanged("StandardName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<MVCGridView.WCFProxy.StudentContract> Students {
            get {
                return this.StudentsField;
            }
            set {
                if ((object.ReferenceEquals(this.StudentsField, value) != true)) {
                    this.StudentsField = value;
                    this.RaisePropertyChanged("Students");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WCFProxy.IEADService")]
    public interface IEADService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEADService/FetchAllStudents", ReplyAction="http://tempuri.org/IEADService/FetchAllStudentsResponse")]
        System.Collections.Generic.List<MVCGridView.WCFProxy.StudentContract> FetchAllStudents();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEADService/FetchAllStudents", ReplyAction="http://tempuri.org/IEADService/FetchAllStudentsResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<MVCGridView.WCFProxy.StudentContract>> FetchAllStudentsAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEADServiceChannel : MVCGridView.WCFProxy.IEADService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EADServiceClient : System.ServiceModel.ClientBase<MVCGridView.WCFProxy.IEADService>, MVCGridView.WCFProxy.IEADService {
        
        public EADServiceClient() {
        }
        
        public EADServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EADServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EADServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EADServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<MVCGridView.WCFProxy.StudentContract> FetchAllStudents() {
            return base.Channel.FetchAllStudents();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<MVCGridView.WCFProxy.StudentContract>> FetchAllStudentsAsync() {
            return base.Channel.FetchAllStudentsAsync();
        }
    }
}
