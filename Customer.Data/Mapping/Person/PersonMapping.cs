using Customer.Domain.Entities.Person;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Customer.Data.Mapping.Person
{
    internal sealed class PersonMapping : IEntityTypeConfiguration<PersonEntity>
    {
        private const string TABLE = "Person";
        public void Configure(EntityTypeBuilder<PersonEntity> builder)
        {
            builder.ToTable(TABLE);
        }
    }
}
