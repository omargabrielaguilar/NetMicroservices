using PlatformService.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace PlatformService.Data
{
    public static class PrepDb
    {
        //two methods : public - private => no podemos usar constructor inyección de dependecia porque es un static
        //reason for dbcontext -> use this class to create migrations to directory a sqlserver

        public static void PrepPopulation(IApplicationBuilder app)
        {
            using (var servicesScope = app.ApplicationServices.CreateScope())
            {
                SeedData(servicesScope.ServiceProvider.GetService<AppDbContext>());
            }
        }

        private static void SeedData(AppDbContext context)
        {
            //Clase que nos permite "test" para enviar datos desde consola, pero solo como test", igual ya habrá una interfaz para el trabajo
            if(!context.Platforms.Any())
            {
                Console.WriteLine("---> Enviando data..."); //Seeding data

                context.Platforms.AddRange(
                    new Platform() { Name = "DotNet", Publisher = "Microsoft", Cost = "Free" },
                    new Platform() { Name = "Laravel", Publisher = "TylorOtwell", Cost = "Free" },
                    new Platform() { Name = "Angular", Publisher = "Google", Cost = "Free" }
                );

                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("---> Ya tenemos data"); //we already have data...
            }
        }
    }
}