using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;

namespace Customer.Data.Context
{
    sealed class ContextFactory : IDesignTimeDbContextFactory<MyContext>
    {
        private const string MY_SQL_CONNECTION = "Server=127.0.0.1;Port=3306;Database=Customer;Uid=root;Pwd=masterkey";

        public MyContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<MyContext>();

            optionsBuilder.UseMySql(MY_SQL_CONNECTION, ServerVersion.Parse("5.7-mysql"), options => options.EnableRetryOnFailure(5, TimeSpan.FromSeconds(10), null));

            return new MyContext(optionsBuilder.Options);
        }
    }
}
