using Microsoft.EntityFrameworkCore;

namespace Customer.Data.Context
{
    public sealed class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {
            
        }
    }
}
