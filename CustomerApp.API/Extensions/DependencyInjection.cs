using CustomerApp.API.Middlewares;
using CustomerApp.Repository;
using CustomerApp.Repository.Interfaces;
using CustomerApp.Repository.Repositories;
using CustomerApp.Service.Interfaces;
using CustomerApp.Service.Services;
using DotNetEnv;
using Microsoft.EntityFrameworkCore;

namespace CustomerApp.API.Extensions
{
    public static class DependencyInjection
    {

        public static void ConfigureServices(this IServiceCollection services, IConfiguration configuration) {
            
            //register my service and repo
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<ICustomerService, CustomerService>();




 
        }
    }
}
