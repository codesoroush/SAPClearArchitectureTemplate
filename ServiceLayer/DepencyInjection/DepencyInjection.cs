using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Hosting;
using DataAccessLayer.Uow;
using DataAccessLayer.Repositories.GenericRepository;

namespace ServiceLayer.DepencyInjection
{
    public static class DepencyInjection
    {


        public static IServiceCollection  AddInfraStructure(this IServiceCollection services)
        {

            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddTransient<IUnitOfWork, UnitOfWork>();

            return services;
        }
        public static IServiceCollection AddTodoDI(this IServiceCollection services, IConfiguration configuration, IWebHostEnvironment environment)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("DefaultConnection"),
                    b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));

        

            return services;
        }

    }
}
