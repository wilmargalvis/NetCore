using System;
using Datos_Negocio;
using System.Data;

//using System.Data

namespace Reglas_Negocio
{
    public class clsRBUsuarios
    {
        //clsDBUsuarios clsDBUsuarios = new clsDBUsuarios();
        
        public IDataReader obtenerUsuarios(int nombre)
        {
            return new clsDBUsuarios().obtenerUsuarios(nombre);
        }
    }
}
