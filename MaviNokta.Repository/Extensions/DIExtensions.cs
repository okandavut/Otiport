using MaviNokta.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace MaviNokta
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
