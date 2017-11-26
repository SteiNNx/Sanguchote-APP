using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Oracle.ManagedDataAccess.Client;
using System.Data;
using Model;

namespace DataAccesOracle
{
    public class DAO_RegistrarVentas
    {
        private OracleConnection cone;
        public DAO_RegistrarVentas()
        {
            try
            {
                //instancio conexion
                cone = new CL_ConexionOracle().obtenerConexion();

            }
            catch (Exception err)
            {

                throw new Exception("Error Crear Dao: " + err.ToString());
            }
        }

        public bool insertarRegistrar(CL_RegistrarVentas reg)
        {
            bool resp = false;
            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = cone;
                cmd.CommandText = "INSERT INTO REGISTROVENTAS VALUES(SEQ_REG.NEXTVAL," + reg.id_compra + "," + reg.total + "," + reg.propitna + ")";
                cmd.CommandType = CommandType.Text;
                if (cone.State.Equals(ConnectionState.Closed))
                {
                    cone.Open();
                }

                int res = cmd.ExecuteNonQuery();
                if (res > 0) { resp = true; }
            }
            catch (Exception ex)
            {
                throw new Exception("Insertar error: " + ex.Message);
            }
            return resp;
        }

        public List<CL_RegistrarVentas> obtenerListadoRegistrarVentas()
        {
            List<CL_RegistrarVentas> lista = new List<CL_RegistrarVentas>();
            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = cone;
                cmd.CommandText = "SELECT * FROM REGISTROVENTAS";
                cmd.CommandType = CommandType.Text;
                if (cone.State.Equals(ConnectionState.Closed))
                {
                    cone.Open();
                }
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    CL_RegistrarVentas aux_ventas = new CL_RegistrarVentas();
                    aux_ventas.id_compra = Convert.ToInt32(dr["ID_COMPRA"].ToString());
                    aux_ventas.id_registrar = Convert.ToInt32(dr["ID_REGISTRO_VENTAS"].ToString());
                    aux_ventas.propitna = Convert.ToInt32(dr["PROPINA"].ToString());
                    aux_ventas.total = Convert.ToInt32(dr["TOTAL"].ToString());
                    lista.Add(aux_ventas);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return lista;
        }
    }
}
