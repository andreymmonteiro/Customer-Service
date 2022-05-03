using Customer.CrossCutting.Solvers;
using Customer.Domain.Models.DatabaseModels;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Customer.CrossCutting
{
    public static class ConfigureDatabase
    {
        private static Func<DatabaseTypes, IBaseDatabase> _dataBases;
        
        public static string Connection { get; set; }

        public static void AddDatabase()
        {
            _dataBases = new Func<DatabaseTypes, IBaseDatabase>(key =>
            {
                return key switch
                {
                    DatabaseTypes.mySql => new MySqlDatabase(Connection),
                    _ => new MySqlDatabase(Connection)
                };
            });
        }

        public static void InitializeDb(DatabaseTypes type, IServiceCollection services)
        {
            _dataBases(type).IncludeDataBase(services);
        }

    }
}
