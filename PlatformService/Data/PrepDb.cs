using PlatformService.Models;

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
            if(!context.Platforms.Any())
            {
                Console.WriteLine("---> Enviando data"); //Seeding data

                context.Platforms.AddRange(
                    new Platform()
                    {
                        Name = "DotNet",
                        Publisher = "Microsoft",
                        Cost = "Free"
                    }
                );

            }
            else
            {
                Console.WriteLine("---> Ya tenemos data"); //we already have data...
            }
        }
    }
}
