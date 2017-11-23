using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using Model;

namespace DataAccesSQL
{
    public class DAO_Usuario
    {
        private SqlConnection cone;

        public DAO_Usuario()
        {
            cone = new CL_Conexion().obtenerConexion();
        }

        public CL_Usuario login(string user,string pass)
        {
            CL_Usuario usuario = null;
            try
            {
                string sql = "SELECT * From Usuarios WHERE user_='"+user+"' AND pass_='"+pass+"'";
                if (cone.State!=System.Data.ConnectionState.Open){cone.Open();}
                SqlCommand cmd = new SqlCommand(sql, cone);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    usuario = new CL_Usuario();
                    usuario.Id_usuario = Convert.ToInt32(dr["id_usuario"].ToString());
                    usuario.User_ = dr["user_"].ToString();
                    usuario.Nombre = dr["nombres"].ToString();
                    usuario.Apellido = dr["apellidos"].ToString();
                    usuario.Tipo_Usuario = dr["tipo_usuario"].ToString();
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
            return usuario;
        }

    }
}
