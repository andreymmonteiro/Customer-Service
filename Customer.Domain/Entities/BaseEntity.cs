using System;
using System.ComponentModel.DataAnnotations;

namespace Customer.Domain.Entities
{
    public abstract class BaseEntity
    {
        [Key]
        public Guid Id { get; set; }
        
        public DateTime CreateAt { get; set; }

        public DateTime UpdateAt { get; set; }
    }
}
