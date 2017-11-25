using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

using Model;
using DataAccesSQL;

namespace WS_SOAP
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        CL_Usuario Login(string nom,string pass);
        [OperationContract]
        List<CL_Producto> listaProductos();
        [OperationContract]
        bool insertarCompra(string xmlCompra);
        [OperationContract]
        List<CL_Compra> listaCompras();
        [OperationContract]
        bool insertarDetalleCompra(string xmlDetalleCompra);
        [OperationContract]
        List<CL_DetalleCompra> listaDetalleCompraXIdCompra(int cod);
    }

}
