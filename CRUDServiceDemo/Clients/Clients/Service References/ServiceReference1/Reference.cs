﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Clients.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="StudyProductDTO", Namespace="http://schemas.datacontract.org/2004/07/ProductService.DTO")]
    [System.SerializableAttribute()]
    public partial class StudyProductDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProductNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal ProductPriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProductTypeField;
        
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
        public string ProductName {
            get {
                return this.ProductNameField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductNameField, value) != true)) {
                    this.ProductNameField = value;
                    this.RaisePropertyChanged("ProductName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal ProductPrice {
            get {
                return this.ProductPriceField;
            }
            set {
                if ((this.ProductPriceField.Equals(value) != true)) {
                    this.ProductPriceField = value;
                    this.RaisePropertyChanged("ProductPrice");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductType {
            get {
                return this.ProductTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductTypeField, value) != true)) {
                    this.ProductTypeField = value;
                    this.RaisePropertyChanged("ProductType");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IProductsCRUDService")]
    public interface IProductsCRUDService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductsCRUDService/GetAllProducts", ReplyAction="http://tempuri.org/IProductsCRUDService/GetAllProductsResponse")]
        System.Collections.Generic.List<Clients.ServiceReference1.StudyProductDTO> GetAllProducts();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductsCRUDService/GetAllProducts", ReplyAction="http://tempuri.org/IProductsCRUDService/GetAllProductsResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Clients.ServiceReference1.StudyProductDTO>> GetAllProductsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductsCRUDService/GetProduct", ReplyAction="http://tempuri.org/IProductsCRUDService/GetProductResponse")]
        Clients.ServiceReference1.StudyProductDTO GetProduct(int ProductId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductsCRUDService/GetProduct", ReplyAction="http://tempuri.org/IProductsCRUDService/GetProductResponse")]
        System.Threading.Tasks.Task<Clients.ServiceReference1.StudyProductDTO> GetProductAsync(int ProductId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductsCRUDService/AddProduct", ReplyAction="http://tempuri.org/IProductsCRUDService/AddProductResponse")]
        bool AddProduct(Clients.ServiceReference1.StudyProductDTO Product);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductsCRUDService/AddProduct", ReplyAction="http://tempuri.org/IProductsCRUDService/AddProductResponse")]
        System.Threading.Tasks.Task<bool> AddProductAsync(Clients.ServiceReference1.StudyProductDTO Product);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IProductsCRUDServiceChannel : global::Clients.ServiceReference1.IProductsCRUDService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ProductsCRUDServiceClient : System.ServiceModel.ClientBase<global::Clients.ServiceReference1.IProductsCRUDService>, global::Clients.ServiceReference1.IProductsCRUDService {
        
        public ProductsCRUDServiceClient() {
        }
        
        public ProductsCRUDServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProductsCRUDServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductsCRUDServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductsCRUDServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<Clients.ServiceReference1.StudyProductDTO> GetAllProducts() {
            return base.Channel.GetAllProducts();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Clients.ServiceReference1.StudyProductDTO>> GetAllProductsAsync() {
            return base.Channel.GetAllProductsAsync();
        }
        
        public Clients.ServiceReference1.StudyProductDTO GetProduct(int ProductId) {
            return base.Channel.GetProduct(ProductId);
        }
        
        public System.Threading.Tasks.Task<Clients.ServiceReference1.StudyProductDTO> GetProductAsync(int ProductId) {
            return base.Channel.GetProductAsync(ProductId);
        }
        
        public bool AddProduct(Clients.ServiceReference1.StudyProductDTO Product) {
            return base.Channel.AddProduct(Product);
        }
        
        public System.Threading.Tasks.Task<bool> AddProductAsync(Clients.ServiceReference1.StudyProductDTO Product) {
            return base.Channel.AddProductAsync(Product);
        }
    }
}
