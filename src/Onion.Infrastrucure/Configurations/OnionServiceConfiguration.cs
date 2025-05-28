using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Onion.Application.Service_Interfaces;
using Onion.Application.Services;
using Onion.Domain.Pure_Interfaces.IRepositories;
using Onion.Domain.Pure_Interfaces.IUtilities;
using Onion.Infrastrucure.Repositories;


namespace Onion.Infrastrucure.Configurations
{
    public static class OnionServiceConfiguration
    {
         public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<OnionDbContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));


            // Application
            services.AddTransient<IUserService, UserService>();




            // Repository
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IDapperContext, OnionDapperContext>(); 



            // Domain
        


            return services;
        }
    }
}