using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Model;
using DataAccesSQL;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestLogin();

            //TestListarProductos();

            //TestListarCompras();

            //TestInsertarComprar();

            //TestListarDetalleCompraPorId(1);

            //TestInsertarCompraWS();

            //TestInsertarDetalleCompraWS();

            //TestListarProductosWS();
        }

        private static void TestListarProductosWS()
        {
            ServiceReference1.Service1Client serv = new ServiceReference1.Service1Client();
            foreach (CL_Producto item in serv.listaProductos())
            {
                Console.WriteLine("Nombre Producto: " + item.Nombre_producto);
            }
            Console.ReadKey();
        }

        private static void TestInsertarDetalleCompraWS()
        {
            ServiceReference1.Service1Client serv = new ServiceReference1.Service1Client();
            CL_Producto pro = new CL_Producto();
            pro.Id_producto = 3;
            CL_DetalleCompra det = new CL_DetalleCompra();
            det.Producto = pro;
            det.Cantidad = 11;
            serv.insertarDetalleCompra(Util.SerializeDetalleCompra<CL_DetalleCompra>(det));
        }

        private static void TestInsertarCompraWS()
        {
            ServiceReference1.Service1Client serv = new ServiceReference1.Service1Client();
            CL_Compra comp = new CL_Compra();
            CL_Usuario us = new CL_Usuario();
            us.Id_usuario = 1;
            comp.Usuario = us;
            comp.Total_Pago = 100;
            comp.Fecha_compra = "2017-11-24";
            serv.insertarCompra(Util.SerializeCompra<CL_Compra>(comp));
        }

        private static void TestListarDetalleCompraPorId(int id_compra)
        {
            foreach (CL_DetalleCompra item in new DAO_DetalleCompra().obtenerDetalleCompraXIdCompra(id_compra))
            {
                Console.WriteLine("Id Compra: " + item.Compra.Id_compra);
                Console.WriteLine("Producto: " + item.Producto.Nombre_producto);
                Console.WriteLine("Cantidad: " + item.Cantidad);
                Console.WriteLine("*************************");
            }
            Console.ReadKey();
        }

        private static void TestInsertarComprar()
        {
            CL_Compra com = new CL_Compra();
            CL_Usuario user = new CL_Usuario();
            user.Id_usuario = 1;
            com.Usuario = user;
            com.Fecha_compra = "2017-11-23";
            com.Total_Pago = 1000;

            DAO_Compra dao = new DAO_Compra();
            dao.insertarCompra(com);
        }

        private static void TestListarCompras()
        {
            foreach (CL_Compra item in new DAO_Compra().obtenerCompras())
            {
                Console.WriteLine("Id Compra: "+item.Id_compra);
            }
            Console.ReadKey();
        }

        private static void TestListarProductos()
        {
            foreach (CL_Producto item in new DAO_Producto().obtenerProductos())
            {
                Console.WriteLine("Nombre Producto: " + item.Nombre_producto);
            }
            Console.ReadKey();
        }

        private static void TestLogin()
        {
            CL_Usuario user = new DAO_Usuario().login("jora", "1234");
            Console.WriteLine("Nombre: " + user.Nombre);
            Console.ReadKey();
        }
    }
}
