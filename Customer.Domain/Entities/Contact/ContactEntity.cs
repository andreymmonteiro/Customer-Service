using System.ComponentModel.DataAnnotations;

namespace Customer.Domain.Entities.Contact
{
    public sealed class ContactEntity : BaseEntity
    {
        [MaxLength(200, ErrorMessage = "Property Phone must be less than {0}")]
        [Required]
        public string Name { get; set; }
    }
}
