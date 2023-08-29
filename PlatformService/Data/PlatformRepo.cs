using PlatformService.Models;
using System.Collections.Generic; //seems not using in net7 as a librery(bibliotecas)
using System.Linq;

namespace PlatformService.Data
{
    public class PlatformRepo : IPlatformRepo
    {
        private readonly AppDbContext _context;

        //Inyección de dependencias para proporcionar una instancia de AppDbContext
        public PlatformRepo(AppDbContext context)
        {
            //private field => _context es un campo privado que almacena una instancia de AppDbContext
            _context = context;
        }


        public void CreatePlatform(Platform plat)
        {
            throw new NotImplementedException();
        }



        public IEnumerable<Platform> GetAllPlatforms()
        {
            return _context.Platforms.ToList(); 
        }




        public Platform GetPlatformById(int id)
        {
            //lambdas
            return _context.Platforms.FirstOrDefault(p => p.Id == id);
        }



        //SaveChanges() en Entity Framework Core se utiliza para guardar los cambios realizados en las entidades que se han agregado, actualizado o eliminado en la base de datos
        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
