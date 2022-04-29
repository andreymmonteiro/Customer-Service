using Customer.Domain.Entities.Contact;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Customer.Domain.Entities.Person
{
    public sealed class PersonEntity : BaseEntity
    {
        [MaxLength(200, ErrorMessage = "Property Name must be less than {0}")]
        [Required]
        public string Name { get; set; }

        [MaxLength(15, ErrorMessage = "Property Phone must be less than {0}")]
        public string Phone { get; set; }

        [MaxLength(15, ErrorMessage = "Property Phone must be less than {0}")]
        public string Document { get; set; }

        public IEnumerable<ContactEntity> Contacts { get; set; }
    }
}
