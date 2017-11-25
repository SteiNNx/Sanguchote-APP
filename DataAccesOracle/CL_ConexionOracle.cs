using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Oracle.ManagedDataAccess.Client;

namespace DataAccesOracle
{
    public class CL_ConexionOracle
    {
        private OracleConnection cone;
        public CL_ConexionOracle()
        {
            try
            {
                String oradb = "Data Source=//localhost:1521/xe;User Id=sanguchote;Password=sanguchote;";
                cone = new OracleConnection(oradb);
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public OracleConnection obtenerConexion()
        {
            return cone;
        }

        public String estadoConexion()
        {
            return cone.ServerVersion;
        }

        public void cerrarConexion()
        {
            cone.Close();
        }
    }
}
