using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace LeerData
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            using(var db = new AppVentaCursosContext()){
                var cursos=db.Curso.AsNoTracking(); // Arreglo de tipo YQueryable
                foreach (var curso in cursos)
                {
                    Console.WriteLine(curso.Titulo);
                }
            }
        }
    }
}
