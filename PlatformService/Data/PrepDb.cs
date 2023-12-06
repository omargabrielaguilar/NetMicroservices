
using PlatformService.Models;

namespace PlatformService.Data
{
    public static class PrepDB
    {
        public static void PrepPopulation(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                SeedData(serviceScope.ServiceProvider.GetService<AppDbContext>());
            }
        }

        private static void SeedData(AppDbContext? context)
        {
            if (!context.Platforms.Any())
            {
                Console.WriteLine("----> Enviando data ...");

                context.Platforms.AddRange(
                    new Platform(){Name="Laravel", Publisher="Tylor Otwell", Cost="Free"},
                    new Platform(){Name="Laravel", Publisher="Tylor Otwell", Cost="Free"},
                    new Platform(){Name="Laravel", Publisher="Tylor Otwell", Cost="Free"}
                );

            }
            else
            {
                Console.WriteLine("----> Ya se tiene datos");
            }
        }
    }
}