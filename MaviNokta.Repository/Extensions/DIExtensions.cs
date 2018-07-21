using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace MaviNokta.Repository.Extensions
{
    public static class DIExtensions
    {
        public static void AddRepository(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<MaviNoktaDbContext>(options =>
            {
                options.UseSqlServer(connectionString, builder => builder.MigrationsAssembly("MaviNokta.API"));
            });
        }
    }
}
