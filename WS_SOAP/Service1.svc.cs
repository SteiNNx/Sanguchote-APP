using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

using Model;
using DataAccesSQL;
using DataAccesOracle;

namespace WS_SOAP
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {
        public bool insertarCompra(string p_xmlCompra)
        {
            bool resp = false;
            CL_Compra aux_comp =Util.DeserializeCompra<CL_Compra>(p_xmlCompra);
            DAO_Compra dao = new DAO_Compra();
            resp = dao.insertarCompra(aux_comp);
            return resp;
        }

        public bool insertarDetalleCompra(string p_xmlDetalleCompra)
        {
            bool resp = false;
            CL_DetalleCompra aux_det = Util.DeserializeDetalleCompra<CL_DetalleCompra>(p_xmlDetalleCompra);
            DAO_DetalleCompra dao = new DAO_DetalleCompra();
            resp = dao.insertarDetalleCompra(aux_det);
            return resp;
        }
        
        public List<CL_Compra> listaCompras()
        {
            return new DAO_Compra().obtenerCompras();
        }

        public List<CL_DetalleCompra> listaDetalleCompraXIdCompra(int cod)
        {
            return new DAO_DetalleCompra().obtenerDetalleCompraXIdCompra(cod);
        }

        public List<CL_RegistrarVentas> listaRegistrarVentas()
        {
            return new DAO_RegistrarVentas().obtenerListadoRegistrarVentas();
        }

        public CL_Usuario Login(string nom, string pass)
        {
            DAO_Usuario user = new DAO_Usuario();
            return user.login(nom,pass);
        }

        public bool insertarRegistrarVentas(string xmlRegistrarVenta)
        {
            bool resp = false;
            CL_RegistrarVentas registrarVentas = Util.DeserializeRegistrarVentas<CL_RegistrarVentas>(xmlRegistrarVenta);
            DAO_RegistrarVentas dao = new DAO_RegistrarVentas();
            resp = dao.insertarRegistrar(registrarVentas);
            return resp;
        }
        public List<CL_Producto> listaProductos()
        {
            return new DAO_Producto().obtenerProductos();
        }
    }
}
