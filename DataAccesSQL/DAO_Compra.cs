using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using Model;

namespace DataAccesSQL
{
    public class DAO_Compra
    {
        private SqlConnection cone;

        public DAO_Compra()
        {
            cone = new CL_Conexion().obtenerConexion();
        }

        public List<CL_Compra> obtenerCompras()
        {
            List<CL_Compra> lista = new List<CL_Compra>();
            try
            {
                string sql = "Select * from Compras as c INNER JOIN Usuarios as u on(c.id_usuario=u.id_usuario)";
                if (cone.State != System.Data.ConnectionState.Open) { cone.Open(); }
                SqlCommand cmd = new SqlCommand(sql, cone);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
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
                    lista.Add(com);
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


        public bool insertarCompra(CL_Compra comp)
        {
            bool resp = false;
            try
            {
                string sql = "INSERT INTO Compras VALUES (" + comp.Usuario.Id_usuario + ",'" + comp.Fecha_compra + "'," + comp.Total_Pago + ");";
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

        public int maxIdCompra()
        {
            int max = 0;
            try
            {
                string sql = "SELECT MAX(id_compra) as maximo FROM Compras;";
                if (cone.State != System.Data.ConnectionState.Open) { cone.Open(); }
                SqlCommand cmd = new SqlCommand(sql, cone);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    max = Convert.ToInt32(dr["maximo"].ToString());
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
            return max;
        }
    }
}
