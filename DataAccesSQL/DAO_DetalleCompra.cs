using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using Model;


namespace DataAccesSQL
{
    public class DAO_DetalleCompra
    {
        private SqlConnection cone;

        public DAO_DetalleCompra()
        {
            cone = new CL_Conexion().obtenerConexion();
        }

        public List<CL_DetalleCompra> obtenerDetalleCompraXIdCompra(int id)
        {
            List<CL_DetalleCompra> lista = new List<CL_DetalleCompra>();
            try
            {
                string sql = "SELECT * FROM DetalleCompra as d INNER JOIN Compras as c ON(d.id_compra=c.id_compra) INNER JOIN Productos as p ON(D.id_producto=p.id_producto) INNER JOIN Usuarios as u ON(u.id_usuario=c.id_usuario) WHERE c.id_compra=" + id+" ";
                if (cone.State != System.Data.ConnectionState.Open) { cone.Open(); }
                SqlCommand cmd = new SqlCommand(sql, cone);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    CL_DetalleCompra det = new CL_DetalleCompra();
                    CL_Producto pro = new CL_Producto();
                    pro.Id_producto = Convert.ToInt32(dr["id_producto"].ToString());
                    pro.Nombre_producto = dr["nombre_producto"].ToString();
                    pro.Precio = Convert.ToInt32(dr["precio"].ToString());
                    pro.Stock = Convert.ToInt32(dr["stock"].ToString());
                    pro.Url_imagen = dr["url_imagen"].ToString();
                    det.Producto = pro;

                    CL_Compra com = new CL_Compra();
                    com.Id_compra = Convert.ToInt32(dr["id_compra"].ToString());
                    CL_Usuario user = new CL_Usuario();
                    user.Id_usuario = Convert.ToInt32(dr["id_usuario"].ToString());
                    user.User_ = dr["user_"].ToString();
                    user.Nombre = dr["nombres"].ToString();
                    user.Apellido = dr["apellidos"].ToString();
                    user.Tipo_Usuario = dr["tipo_usuario"].ToString();
                    com.Usuario = user;
                    com.Fecha_compra = Convert.ToDateTime(dr["fecha_compra"].ToString()).ToString("dd/MM/yyyy");
                    com.Total_Pago = Convert.ToInt32(dr["total_pago"].ToString());

                    det.Compra = com;
                    det.Cantidad = Convert.ToInt32(dr["cantidad"].ToString());
                    lista.Add(det);
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

        public bool insertarDetalleCompra(CL_DetalleCompra det)
        {
            bool resp = false;
            try
            {
                string sql = "INSERT INTO DetalleCompra VALUES("+det.Compra.Id_compra+","+det.Producto.Id_producto+","+det.Cantidad+")";
                if (cone.State != System.Data.ConnectionState.Open) { cone.Open(); }
                SqlCommand cmd = new SqlCommand(sql, cone);
                int cant = cmd.ExecuteNonQuery();
                if (cant > 0) { resp = true; }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cone.Close();
            }
            return resp;
        }


    }
}
