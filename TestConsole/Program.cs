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
