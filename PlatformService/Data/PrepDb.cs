
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
                    new Platform(){Name="Kubernetes", Publisher="Cloud Native Computing Foundation", Cost="Free"},
                    new Platform(){Name="Ruby on Rails", Publisher="DHH", Cost="Free"}
                );

                context.SaveChanges();

            }
            else
            {
                Console.WriteLine("----> Ya se tiene datos");
            }
        }
    }
}