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
