using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCoreApi.Controllers
{
    
    [ApiController]
    [Route("api/personas")]
    public class PersonaController : Controller
    {
        //Códigos: https://diego.com.es/codigos-de-estado-http
        [HttpGet]
        public IActionResult GetPersons()
        {
            //DTO: Transferencia de Datos
            PersonaDTO entidad = new PersonaDTO();

            List<PersonaDTO> listaData = new List<PersonaDTO>();
            listaData.Add(new PersonaDTO
            {
                NombreCompleto = "Sebas"
            });

            listaData.Add(new PersonaDTO
            {
                NombreCompleto = "Wilmar"
            });

            //if (listaData.Count == 2) {
            //    return NotFound();
            //}

            return Ok(listaData);
        }


        [HttpGet("{id}")]
        public IActionResult GetConsulta( int id)
        {
            PersonaDTO entidad = new PersonaDTO();

            List<PersonaDTO> listaData = new List<PersonaDTO>();
            listaData.Add(new PersonaDTO
            {
                NombreCompleto = "María" + id
            });

            return Ok(listaData);
        }
    }
}
