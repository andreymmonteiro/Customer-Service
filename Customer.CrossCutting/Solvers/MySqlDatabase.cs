using Customer.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Customer.CrossCutting.Solvers
{
    public class MySqlDatabase : IBaseDatabase
    {
        private readonly string Connection;
        private string GetConnection()
        {
            return Connection;
        }

        public MySqlDatabase(string connection)
        {
            Connection = connection;
        }

        public void IncludeDataBase(IServiceCollection service)
        {
            service.AddDbContext<MyContext>(option => option.UseMySql(
                GetConnection(), 
                ServerVersion.Parse("5.7-mysql"), 
                mysql => mysql.EnableRetryOnFailure()));
        }
    }
}
