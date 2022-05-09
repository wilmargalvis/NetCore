using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Reglas_Negocio;
using Newtonsoft.Json;
using Entidades_Negocio;

namespace API_Ress_ASP.Net_Core.NewFolder
{
    

    //[Route("api/[controller]")] es requerido para trabajar con POST
    //Si el controlador o ruta está entre [], ej: ("api/[controller]")], quiere decir que la ruta que tomará será el nombre de la clase(sin la palabra controller) https://localhost:44337/api/Values?id=1
    //[Route("api/controller")] dará https://localhost:44337/api/controller/2 para la consulta get, porque está sin los []

    //Para acceder con POST y GET
    [Route("api/[controller]")] //Ruta solo para método POST https://localhost:44337/api/controller, para POST NO se utilizar la ruta de [HttpGet()]


    [ApiController]
    public class ValuesController : ControllerBase //Values es parte de la URL
    {

        clsRBUsuarios clsRBUsuarios = new clsRBUsuarios();
        //SI UTILIZA SOLO GET (sin tener el método Post), PODRÍA:
        //Omitir del namespace esto: [Route("api/[controller]")] y usar en la clase [HttpGet("datos/{id}")] resultado https://localhost:44337/datos/1
        //usar unicamente en el namespace esto: [Route("api/[controller]")] resultado https://localhost:44337/api/Values?id=1

        //Para acceder solo con método GET. La ruta de GET puede usar tambien la de POST unida con la de GET
        [HttpGet("datos/{id}")] //https://localhost:44337/api/controller/datos/2, teniendo habilitado [Route("api/controller")] en el namespace
        public string get(int id)
        {

            //Leer datos de usuario de la base de datos
            return id switch
            {
                1 => "wilmar",
                2 => "Norbey",
                 _=> throw new NotSupportedException("el id no es válido")

            };


        }

        [HttpGet("lista/{id}")]
        public string obtener(int id)
        {
            //string nombre = "mar";
            IDataReader datos = clsRBUsuarios.obtenerUsuarios(id);

            List<clsEBUusuarios> lista = new List<clsEBUusuarios>();

            while (datos.Read())
            {
                clsEBUusuarios _objEBUsuarios = new clsEBUusuarios();
                _objEBUsuarios.nombre = datos["nombre"].ToString();
                _objEBUsuarios.apellido = datos["apellido"].ToString();
                lista.Add(_objEBUsuarios);
            }

            string json = JsonConvert.SerializeObject(lista);
            return json;
            // {
            //   "Name": "Apple",
            //   "Expiry": "2008-12-28T00:00:00",
            //   "Sizes": [
            //     "Small"
            //   ]
            // }
            //Leer datos de usuario de la base de datos
            //string hola = "Hola";
            //return hola;


        }

        public string post(datosPersona objDatosPersona)
        {
            //Guardar datos de la persona en la base de datos
            return objDatosPersona.nombre;
        }
    }
}
