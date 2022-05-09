using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Datos_Negocio
{
    public class clsDBUsuarios
    {
        DBConexion conexion = new DBConexion();
        public IDataReader obtenerUsuarios(int nombre) {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "spEmpleado_Buscar";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@parametro", nombre);
            return comando.ExecuteReader();
        }
    }
}
