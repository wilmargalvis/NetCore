using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjemploProyectoVacio
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddMvcCore();
        }

        //MVC
        //Modelo: L�gica de negocio de la aplicaci�n + los datos
        //Controlador: Gesti�n de petici�n del usuario, comunica con el modelo, y luego con la vista para entregar lo que el modelo di�

        //Programaci�n asincr�nica con async y await: https://docs.microsoft.com/es-es/dotnet/csharp/programming-guide/concepts/async/
        //Middleware de ASP.NET Core: https://docs.microsoft.com/es-es/aspnet/core/fundamentals/middleware/?view=aspnetcore-6.0&viewFallbackFrom=aspnetcore-2.2


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                //DeveloperExceptionPageOptions e = new DeveloperExceptionPageOptions
                //{
                //    SourceCodeLineCount = 2 //mostrar 2 lineas por encima o debajo del error
                //};
                //app.UseDeveloperExceptionPage(); //app.UseDeveloperExceptionPage(e); para mostrar info de excepci�n
            }

            /*Si en las variables de entorno global no existier� la variable de ambiente de desarrollo, 
            "ASPNETCORE_ENVIRONMENT": "Development", el sistema asume que est� en producci�n*/
            //else if (env.IsProduction() || env.IsStaging()) { 
            //    app.UseExceptionHandler("/error");
            //}

            //Acceder a una p�gina est�tica concreta. P�ginas debajo de wwwroot
            //DefaultFilesOptions d = new DefaultFilesOptions();
            //d.DefaultFileNames.Clear();
            //d.DefaultFileNames.Add("nodefault.html");
            //app.UseDefaultFiles(d);

            //app.UseDefaultFiles(); // Definir iniciar con la p�gina por defecto. Dejar habilitado app.UseStaticFiles();

            app.UseStaticFiles(); //Habilitar el acceso a archivos. Ej: acceso a una p�gina est�tica o al archivo 360.png
            //app.UseMvcWithDefaultRoute();

            app.Run(async context =>
            {
                //throw new Exception("Error fatal");
                await context.Response.WriteAsync("M�todo run");
                //await context.Response.WriteAsync("Entorno" + env.EnvironmentName); para conocer en que ambiente de desarrollo estamos
            });

            //app.UseRouting();

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/", async context =>
            //    {
            //        await context.Response.WriteAsync("Hello World!");
            //    });
            //});
        }
    }
}
