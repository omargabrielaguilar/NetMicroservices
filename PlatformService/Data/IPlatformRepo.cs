using PlatformService.Models;
using System.Collections.Generic;

namespace PlatformService.Data
{
    public interface IPlatformRepo
    {
        //metodos a usar | repositorio => conjunto de métodos que representan operaciones que se pueden realizar en una fuente de datos relacionada con la entidad Platform
        bool SaveChanges();

        IEnumerable<Platform> GetAllPlatforms();
        Platform GetPlatformById(int id);
        void CreatePlatform(Platform plat);
    }
}
