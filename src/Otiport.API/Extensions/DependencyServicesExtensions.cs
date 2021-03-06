﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Otiport.API.Data;
using Otiport.API.Mappers;
using Otiport.API.Mappers.Implementations;
using Otiport.API.Providers;
using Otiport.API.Repositories;
using Otiport.API.Repositories.Implementations;
using Otiport.API.Services;
using Otiport.API.Services.Implementations;

namespace Otiport.API.Extensions
{
    public static class DependencyServicesExtensions
    {
        public static IServiceCollection AddaDataLayer(this IServiceCollection services)
        {
            var configuration = services.BuildServiceProvider().GetService<IConfiguration>();

            services.AddDbContext<OtiportDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("OtiportDb"), builder => builder.MigrationsAssembly("Otiport.API"));
            });
            return services;
        }

        public static IServiceCollection AddRepositoryLayer(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IAdressInformationRepository, AdressInformationRepository>();
            services.AddScoped<IMedicineRepository, MedicineRepository>();
            services.AddScoped<ITreatmentRepository, TreatmentRepository>();
            services.AddScoped<IProfileItemRepository,ProfileItemRepository>();
            return services;
        }

        public static IServiceCollection AddServicesLayer(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IAddressInformationService, AddressInformationService>();
            services.AddScoped<IMedicineService, MedicineService>();
            services.AddScoped<ITreatmentService, TreatmentService>();
            services.AddScoped<IProfileItemService, ProfileItemService>();

            return services;
        }

        public static IServiceCollection AddMapperLayer(this IServiceCollection services)
        {
            services.AddTransient<IUserMapper, UserMapper>();
            services.AddTransient<IMedicineMapper, MedicineMapper>();
            services.AddTransient<ITreatmentMapper, TreatmentMapper>();
            services.AddTransient<IProfileItemMapper, ProfileItemMapper>();
            return services;
        }

        public static IServiceCollection AddProviders(this IServiceCollection services)
        {
            services.AddTransient<ITokenProvider, TokenProvider>();
            return services;
        }
    }
}
