using DataLayer.Repositories.DedicatedRepository.AbsenceRep;
using DataLayer.Repositories.DedicatedRepository.Todo;
using DataLayer.Repositories.DedicatedRepository.UserRep;
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
            services.AddTransient<IAbsenceService, AbsenceService>();
            services.AddTransient<IUserService, UserService>();


            //repository
            services.AddTransient<ITodoItemRepository, TodoItemRepository>();
            services.AddTransient<ITodoListItemRepository, TodoListItemRepository>();
            services.AddTransient<IAbsenceRepository, AbsenceRepository>();
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<ITodoCategoryRepository, TodoCategoryRepository>();


            return services;
        }
    }
}
