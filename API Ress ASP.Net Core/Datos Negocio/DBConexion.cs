using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Datos_Negocio
{
    
    public class DBConexion
    {

        private SqlConnection Conexion = new SqlConnection("Server=.\\SQLEXPRESS;DataBase=practica1;Integrated Security=true;Encrypt=False");
        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }
        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }



    }
}
