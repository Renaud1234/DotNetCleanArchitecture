using CleanArchitectureDemo.Application.Interfaces;
using CleanArchitectureDemo.Application.Services;
using CleanArchitectureDemo.Domain.Interfaces;
using CleanArchitectureDemo.Infra.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitectureDemo.Infrastructure.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //CleanArchitecture.Application
            services.AddScoped<IBookService, BookService>();

            //CleanArchitecture.Domain.Interfaces | CleanArchitecture.Infra.Data.Repositories
            services.AddScoped<IBookRepository, BookRepository>();
        }
    }
}
