using Customer.Domain.Entities.Contact;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Customer.Data.Mapping.Person
{
    internal sealed class PersonMapping : IEntityTypeConfiguration<ContactEntity>
    {
        public void Configure(EntityTypeBuilder<ContactEntity> builder)
        {
            throw new System.NotImplementedException();
        }
    }
}
