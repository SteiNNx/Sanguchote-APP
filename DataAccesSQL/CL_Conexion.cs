﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;


namespace DataAccesSQL
{
    public class CL_Conexion
    {
        private SqlConnection cone;

        //BD DUOC
        private String cadena = @"Data Source=LC1301308;Initial Catalog=sanguchote; integrated Security =True";
        //BD MI CASA STEINNXLABS-PC\SQLEXPRESS
        //private String cadena = @"Data Source=STEINNXLABS-PC\SQLEXPRESS;Initial Catalog=sanguchote; integrated Security =True";


        public CL_Conexion()
        {
            if (cone==null)
            {
                cone = new SqlConnection();
                cone.ConnectionString = cadena;
            }
        }

        public SqlConnection obtenerConexion()
        {
            return cone;
        }
    }
}
