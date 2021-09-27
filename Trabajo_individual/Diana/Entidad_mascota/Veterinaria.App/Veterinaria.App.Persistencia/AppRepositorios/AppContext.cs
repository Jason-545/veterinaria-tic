using Microsoft.EntityFrameworkCore;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Persistencia
{
    public class AppContext : DbContext
    {

        
        public DbSet<EntidadMascota> Mascotas {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            
            if(!optionsBuilder.IsConfigured) {
                optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog =VeterinariaProject");
            }

        }
        

    }
    
}