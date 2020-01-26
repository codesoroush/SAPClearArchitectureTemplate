using DataLayer.Repositories.DedicatedRepository.Todo;
using DataLayer.Repositories.GenericRepository;
using DataLayer.Uow;
using Microsoft.Extensions.DependencyInjection;
using ServiceLayer.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer.DepencyInjection
{
    public static class DepencyInjection
    {
        /// <summary>
        /// inject basic depency like generic repository and unit of work 
        /// </summary>
        /// <param name="services"></param>
        /// <returns>IServiceCollection as services</returns>

        public static IServiceCollection AddInfraStructure(this IServiceCollection services)
        {

            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddTransient<IUnitOfWork, UnitOfWork>();

            return services;
        }
        public static IServiceCollection AddTodoDI(this IServiceCollection services)
        {
        

            //services
            services.AddTransient<ITodoService, TodoService>();


            //repository
            services.AddTransient<ITodoItemRepository, TodoItemRepository>();
            services.AddTransient<ITodoListItemRepository, TodoListItemRepository>();


            return services;
        }
    }
}
