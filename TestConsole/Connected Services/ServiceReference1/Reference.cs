﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestConsole.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Login", ReplyAction="http://tempuri.org/IService1/LoginResponse")]
        Model.CL_Usuario Login(string nom, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Login", ReplyAction="http://tempuri.org/IService1/LoginResponse")]
        System.Threading.Tasks.Task<Model.CL_Usuario> LoginAsync(string nom, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/listaProductos", ReplyAction="http://tempuri.org/IService1/listaProductosResponse")]
        Model.CL_Producto[] listaProductos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/listaProductos", ReplyAction="http://tempuri.org/IService1/listaProductosResponse")]
        System.Threading.Tasks.Task<Model.CL_Producto[]> listaProductosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/insertarCompra", ReplyAction="http://tempuri.org/IService1/insertarCompraResponse")]
        bool insertarCompra(string xmlCompra);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/insertarCompra", ReplyAction="http://tempuri.org/IService1/insertarCompraResponse")]
        System.Threading.Tasks.Task<bool> insertarCompraAsync(string xmlCompra);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/listaCompras", ReplyAction="http://tempuri.org/IService1/listaComprasResponse")]
        Model.CL_Compra[] listaCompras();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/listaCompras", ReplyAction="http://tempuri.org/IService1/listaComprasResponse")]
        System.Threading.Tasks.Task<Model.CL_Compra[]> listaComprasAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/insertarDetalleCompra", ReplyAction="http://tempuri.org/IService1/insertarDetalleCompraResponse")]
        bool insertarDetalleCompra(string xmlDetalleCompra);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/insertarDetalleCompra", ReplyAction="http://tempuri.org/IService1/insertarDetalleCompraResponse")]
        System.Threading.Tasks.Task<bool> insertarDetalleCompraAsync(string xmlDetalleCompra);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/listaDetalleCompraXIdCompra", ReplyAction="http://tempuri.org/IService1/listaDetalleCompraXIdCompraResponse")]
        Model.CL_DetalleCompra[] listaDetalleCompraXIdCompra(int cod);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/listaDetalleCompraXIdCompra", ReplyAction="http://tempuri.org/IService1/listaDetalleCompraXIdCompraResponse")]
        System.Threading.Tasks.Task<Model.CL_DetalleCompra[]> listaDetalleCompraXIdCompraAsync(int cod);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : TestConsole.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<TestConsole.ServiceReference1.IService1>, TestConsole.ServiceReference1.IService1 {
        
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
        
        public Model.CL_Usuario Login(string nom, string pass) {
            return base.Channel.Login(nom, pass);
        }
        
        public System.Threading.Tasks.Task<Model.CL_Usuario> LoginAsync(string nom, string pass) {
            return base.Channel.LoginAsync(nom, pass);
        }
        
        public Model.CL_Producto[] listaProductos() {
            return base.Channel.listaProductos();
        }
        
        public System.Threading.Tasks.Task<Model.CL_Producto[]> listaProductosAsync() {
            return base.Channel.listaProductosAsync();
        }
        
        public bool insertarCompra(string xmlCompra) {
            return base.Channel.insertarCompra(xmlCompra);
        }
        
        public System.Threading.Tasks.Task<bool> insertarCompraAsync(string xmlCompra) {
            return base.Channel.insertarCompraAsync(xmlCompra);
        }
        
        public Model.CL_Compra[] listaCompras() {
            return base.Channel.listaCompras();
        }
        
        public System.Threading.Tasks.Task<Model.CL_Compra[]> listaComprasAsync() {
            return base.Channel.listaComprasAsync();
        }
        
        public bool insertarDetalleCompra(string xmlDetalleCompra) {
            return base.Channel.insertarDetalleCompra(xmlDetalleCompra);
        }
        
        public System.Threading.Tasks.Task<bool> insertarDetalleCompraAsync(string xmlDetalleCompra) {
            return base.Channel.insertarDetalleCompraAsync(xmlDetalleCompra);
        }
        
        public Model.CL_DetalleCompra[] listaDetalleCompraXIdCompra(int cod) {
            return base.Channel.listaDetalleCompraXIdCompra(cod);
        }
        
        public System.Threading.Tasks.Task<Model.CL_DetalleCompra[]> listaDetalleCompraXIdCompraAsync(int cod) {
            return base.Channel.listaDetalleCompraXIdCompraAsync(cod);
        }
    }
}
