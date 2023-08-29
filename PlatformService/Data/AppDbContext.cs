using Microsoft.EntityFrameworkCore;
using PlatformService.Models;

namespace PlatformService.Data
{
    public class AppDbContext : DbContext
    {
        /*
         public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt): Este es el constructor de la clase AppDbContext. Toma un parámetro de tipo DbContextOptions<AppDbContext> llamado opt. 
        Este parámetro se pasa a la clase base (DbContext) usando base(opt), lo que permite que Entity Framework configure la conexión y el comportamiento del contexto de la base de datos. 
         */
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
        {
            
        }

        public DbSet<Platform> Platforms { get; set; }


    }
}
