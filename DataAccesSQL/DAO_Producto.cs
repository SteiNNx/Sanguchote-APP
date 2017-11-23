using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using Model;

namespace DataAccesSQL
{
    public class DAO_Producto
    {
        private SqlConnection cone;

        public DAO_Producto()
        {
            cone = new CL_Conexion().obtenerConexion();
        }

        public List<CL_Producto> obtenerProductos()
        {
            List<CL_Producto> lista = new List<CL_Producto>();
            try
            {
                string sql = "SELECT * From Productos";
                if (cone.State != System.Data.ConnectionState.Open) { cone.Open(); }
                SqlCommand cmd = new SqlCommand(sql, cone);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    CL_Producto pro = new CL_Producto();
                    pro.Id_producto = Convert.ToInt32(dr["id_producto"].ToString());
                    pro.Nombre_producto = dr["nombre_producto"].ToString();
                    pro.Stock = Convert.ToInt32(dr["stock"].ToString());
                    pro.Url_imagen = dr["url_imagen"].ToString();
                    pro.Precio = Convert.ToInt32(dr["precio"].ToString());
                    lista.Add(pro);
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cone.Close();
            }
            return lista;
        }
    }
}
