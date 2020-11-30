﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ImdbClient.ImdbServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Movies", Namespace="http://schemas.datacontract.org/2004/07/ImdbServiceApp")]
    [System.SerializableAttribute()]
    public partial class Movies : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<short> endYearField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string genresField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<bool> isAdultField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string originalTitleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string primaryTitleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> runtimeMinutesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<short> startYearField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string tconstField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string titleTypeField;
        
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
        public System.Nullable<short> endYear {
            get {
                return this.endYearField;
            }
            set {
                if ((this.endYearField.Equals(value) != true)) {
                    this.endYearField = value;
                    this.RaisePropertyChanged("endYear");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string genres {
            get {
                return this.genresField;
            }
            set {
                if ((object.ReferenceEquals(this.genresField, value) != true)) {
                    this.genresField = value;
                    this.RaisePropertyChanged("genres");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<bool> isAdult {
            get {
                return this.isAdultField;
            }
            set {
                if ((this.isAdultField.Equals(value) != true)) {
                    this.isAdultField = value;
                    this.RaisePropertyChanged("isAdult");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string originalTitle {
            get {
                return this.originalTitleField;
            }
            set {
                if ((object.ReferenceEquals(this.originalTitleField, value) != true)) {
                    this.originalTitleField = value;
                    this.RaisePropertyChanged("originalTitle");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string primaryTitle {
            get {
                return this.primaryTitleField;
            }
            set {
                if ((object.ReferenceEquals(this.primaryTitleField, value) != true)) {
                    this.primaryTitleField = value;
                    this.RaisePropertyChanged("primaryTitle");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> runtimeMinutes {
            get {
                return this.runtimeMinutesField;
            }
            set {
                if ((this.runtimeMinutesField.Equals(value) != true)) {
                    this.runtimeMinutesField = value;
                    this.RaisePropertyChanged("runtimeMinutes");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<short> startYear {
            get {
                return this.startYearField;
            }
            set {
                if ((this.startYearField.Equals(value) != true)) {
                    this.startYearField = value;
                    this.RaisePropertyChanged("startYear");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string tconst {
            get {
                return this.tconstField;
            }
            set {
                if ((object.ReferenceEquals(this.tconstField, value) != true)) {
                    this.tconstField = value;
                    this.RaisePropertyChanged("tconst");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string titleType {
            get {
                return this.titleTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.titleTypeField, value) != true)) {
                    this.titleTypeField = value;
                    this.RaisePropertyChanged("titleType");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ImdbServiceReference.IImdbService")]
    public interface IImdbService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IImdbService/DoWork", ReplyAction="http://tempuri.org/IImdbService/DoWorkResponse")]
        void DoWork();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IImdbService/DoWork", ReplyAction="http://tempuri.org/IImdbService/DoWorkResponse")]
        System.Threading.Tasks.Task DoWorkAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IImdbService/GetAllMovies", ReplyAction="http://tempuri.org/IImdbService/GetAllMoviesResponse")]
        ImdbClient.ImdbServiceReference.Movies[] GetAllMovies();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IImdbService/GetAllMovies", ReplyAction="http://tempuri.org/IImdbService/GetAllMoviesResponse")]
        System.Threading.Tasks.Task<ImdbClient.ImdbServiceReference.Movies[]> GetAllMoviesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IImdbService/AddMovie", ReplyAction="http://tempuri.org/IImdbService/AddMovieResponse")]
        int AddMovie(string Name, string Email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IImdbService/AddMovie", ReplyAction="http://tempuri.org/IImdbService/AddMovieResponse")]
        System.Threading.Tasks.Task<int> AddMovieAsync(string Name, string Email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IImdbService/GetAllMoviesById", ReplyAction="http://tempuri.org/IImdbService/GetAllMoviesByIdResponse")]
        ImdbClient.ImdbServiceReference.Movies GetAllMoviesById(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IImdbService/GetAllMoviesById", ReplyAction="http://tempuri.org/IImdbService/GetAllMoviesByIdResponse")]
        System.Threading.Tasks.Task<ImdbClient.ImdbServiceReference.Movies> GetAllMoviesByIdAsync(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IImdbService/UpdateMovie", ReplyAction="http://tempuri.org/IImdbService/UpdateMovieResponse")]
        int UpdateMovie(int Id, string Name, string Email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IImdbService/UpdateMovie", ReplyAction="http://tempuri.org/IImdbService/UpdateMovieResponse")]
        System.Threading.Tasks.Task<int> UpdateMovieAsync(int Id, string Name, string Email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IImdbService/DeleteMovieById", ReplyAction="http://tempuri.org/IImdbService/DeleteMovieByIdResponse")]
        int DeleteMovieById(string Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IImdbService/DeleteMovieById", ReplyAction="http://tempuri.org/IImdbService/DeleteMovieByIdResponse")]
        System.Threading.Tasks.Task<int> DeleteMovieByIdAsync(string Id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IImdbServiceChannel : ImdbClient.ImdbServiceReference.IImdbService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ImdbServiceClient : System.ServiceModel.ClientBase<ImdbClient.ImdbServiceReference.IImdbService>, ImdbClient.ImdbServiceReference.IImdbService {
        
        public ImdbServiceClient() {
        }
        
        public ImdbServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ImdbServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ImdbServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ImdbServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void DoWork() {
            base.Channel.DoWork();
        }
        
        public System.Threading.Tasks.Task DoWorkAsync() {
            return base.Channel.DoWorkAsync();
        }
        
        public ImdbClient.ImdbServiceReference.Movies[] GetAllMovies() {
            return base.Channel.GetAllMovies();
        }
        
        public System.Threading.Tasks.Task<ImdbClient.ImdbServiceReference.Movies[]> GetAllMoviesAsync() {
            return base.Channel.GetAllMoviesAsync();
        }
        
        public int AddMovie(string Name, string Email) {
            return base.Channel.AddMovie(Name, Email);
        }
        
        public System.Threading.Tasks.Task<int> AddMovieAsync(string Name, string Email) {
            return base.Channel.AddMovieAsync(Name, Email);
        }
        
        public ImdbClient.ImdbServiceReference.Movies GetAllMoviesById(string id) {
            return base.Channel.GetAllMoviesById(id);
        }
        
        public System.Threading.Tasks.Task<ImdbClient.ImdbServiceReference.Movies> GetAllMoviesByIdAsync(string id) {
            return base.Channel.GetAllMoviesByIdAsync(id);
        }
        
        public int UpdateMovie(int Id, string Name, string Email) {
            return base.Channel.UpdateMovie(Id, Name, Email);
        }
        
        public System.Threading.Tasks.Task<int> UpdateMovieAsync(int Id, string Name, string Email) {
            return base.Channel.UpdateMovieAsync(Id, Name, Email);
        }
        
        public int DeleteMovieById(string Id) {
            return base.Channel.DeleteMovieById(Id);
        }
        
        public System.Threading.Tasks.Task<int> DeleteMovieByIdAsync(string Id) {
            return base.Channel.DeleteMovieByIdAsync(Id);
        }
    }
}
