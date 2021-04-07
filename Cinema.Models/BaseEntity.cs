using System;
using System.ComponentModel.DataAnnotations;

namespace Cinema.Models
{
    public class BaseEntity : IEntity
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
