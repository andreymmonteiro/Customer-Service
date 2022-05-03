using Customer.Data.Repositories;
using Customer.Domain.Interfaces;
using Customer.Domain.Services;
using Customer.Service;
using Microsoft.Extensions.DependencyInjection;

namespace Customer.CrossCutting
{
    public static class ConfigureServicesApplication
    {
        public static void AddServices(IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
        }

        private static void CustomerService(IServiceCollection services)
        {
            services.AddScoped<IPersonService, PersonService>();
        }
    }
}
