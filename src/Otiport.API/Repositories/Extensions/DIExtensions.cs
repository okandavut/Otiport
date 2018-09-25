using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Otiport.API.Repositories.Extensions
{
    public static class DIExtensions
    {
        public static void AddRepository(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<OtiportDbContext>(options =>
            {
                options.UseSqlServer(connectionString, builder => builder.MigrationsAssembly("Otiport.API"));
            });
        }
    }
}
