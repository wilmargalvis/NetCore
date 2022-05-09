using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjemploProyectoVacio.Controllers
{
    public class HomeController:Controller
    {
        public JsonResult Index() {
            return Json(new {id="", Nombre="wilmar" });
        }
    }
}
