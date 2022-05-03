using Customer.Domain.Entities.Contact;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Customer.Data.Mapping.Contact
{
    internal class ContactMapping : IEntityTypeConfiguration<ContactEntity>
    {
        private const string TABLE = "Contact";
        public void Configure(EntityTypeBuilder<ContactEntity> builder)
        {
            builder.ToTable(TABLE);
            builder.HasOne(one => one.Person).WithMany(many => many.Contacts);
        }
    }
}
