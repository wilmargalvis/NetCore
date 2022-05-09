using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace LeerData
{    public class AppVentaCursosContext : DbContext
    {
        private const string conectionString = @"Data Source= localhost\sqlexpress;Initial Catalog=CursosOnline;Integrated Security=True";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            optionsBuilder.UseSqlServer(conectionString);
        }

        public DbSet<Curso> Curso {get;set;}
    }

}