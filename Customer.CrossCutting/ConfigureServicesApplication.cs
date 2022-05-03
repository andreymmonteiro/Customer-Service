using Customer.Data.Repositories;
using Customer.Domain.Interfaces;
using Customer.Domain.Mapper;
using Customer.Domain.Services;
using Customer.Service;
using Customer.Service.Mapper;
using Microsoft.Extensions.DependencyInjection;

namespace Customer.CrossCutting
{
    public static class ConfigureServicesApplication
    {
        public static void AddServices(IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
            services.AddScoped<IServiceMapper, ServiceMapper>();

            CustomerService(services);
        }

        private static void CustomerService(IServiceCollection services)
        {
            services.AddScoped<IPersonService, PersonService>();
        }
    }
}
