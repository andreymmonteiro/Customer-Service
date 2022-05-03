using Customer.Data.Mapping.Contact;
using Customer.Data.Mapping.Person;
using Customer.Domain.Entities.Contact;
using Customer.Domain.Entities.Person;
using Microsoft.EntityFrameworkCore;

namespace Customer.Data.Context
{
    public sealed class MyContext : DbContext
    {
        //public DbSet<PersonEntity> Person { get; set; }

        //public DbSet<ContactEntity> Contact { get; set; }

        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PersonEntity>(new PersonMapping().Configure);
            modelBuilder.Entity<ContactEntity>(new ContactMapping().Configure);
            base.OnModelCreating(modelBuilder);
        }
    }
}
