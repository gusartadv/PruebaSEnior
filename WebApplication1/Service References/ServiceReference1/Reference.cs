﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="misDatos", Namespace="http://schemas.datacontract.org/2004/07/WcfService")]
    [System.SerializableAttribute()]
    public partial class misDatos : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescripcionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TipoField;
        
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
        public string Descripcion {
            get {
                return this.DescripcionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescripcionField, value) != true)) {
                    this.DescripcionField = value;
                    this.RaisePropertyChanged("Descripcion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Tipo {
            get {
                return this.TipoField;
            }
            set {
                if ((this.TipoField.Equals(value) != true)) {
                    this.TipoField = value;
                    this.RaisePropertyChanged("Tipo");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/consultar", ReplyAction="http://tempuri.org/IService1/consultarResponse")]
        WebApplication1.ServiceReference1.misDatos consultar(int id, string descripcion, int tipo, int tipoConsulta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/insertar", ReplyAction="http://tempuri.org/IService1/insertarResponse")]
        int insertar(int id, string descripcion, int tipo, int tipoConsulta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/modificar", ReplyAction="http://tempuri.org/IService1/modificarResponse")]
        int modificar(int id, string descripcion, int tipo, int tipoConsulta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/eliminar", ReplyAction="http://tempuri.org/IService1/eliminarResponse")]
        int eliminar(int id, string descripcion, int tipo, int tipoConsulta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/mostrarTodos", ReplyAction="http://tempuri.org/IService1/mostrarTodosResponse")]
        WebApplication1.ServiceReference1.misDatos[] mostrarTodos(int id, string descripcion, int tipo, int tipoConsulta);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : WebApplication1.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<WebApplication1.ServiceReference1.IService1>, WebApplication1.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WebApplication1.ServiceReference1.misDatos consultar(int id, string descripcion, int tipo, int tipoConsulta) {
            return base.Channel.consultar(id, descripcion, tipo, tipoConsulta);
        }
        
        public int insertar(int id, string descripcion, int tipo, int tipoConsulta) {
            return base.Channel.insertar(id, descripcion, tipo, tipoConsulta);
        }
        
        public int modificar(int id, string descripcion, int tipo, int tipoConsulta) {
            return base.Channel.modificar(id, descripcion, tipo, tipoConsulta);
        }
        
        public int eliminar(int id, string descripcion, int tipo, int tipoConsulta) {
            return base.Channel.eliminar(id, descripcion, tipo, tipoConsulta);
        }
        
        public WebApplication1.ServiceReference1.misDatos[] mostrarTodos(int id, string descripcion, int tipo, int tipoConsulta) {
            return base.Channel.mostrarTodos(id, descripcion, tipo, tipoConsulta);
        }
    }
}
