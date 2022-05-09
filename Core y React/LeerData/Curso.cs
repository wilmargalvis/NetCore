using System.ComponentModel.DataAnnotations;

namespace LeerData
{
    public class Curso
    {
        [Key]
        public int CursosId {get;set;} 
        public string Titulo {get;set;}
        public string Descripcion {get;set;}

        public System.DateTime FechaPublicacion {get;set;}
    }
}