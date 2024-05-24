using System.ComponentModel.DataAnnotations;

namespace LanguageAcademyApi.Domain.Models
{
    public class Role
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        [Required]
        public DateTime UpdatedAt { get; set; }
    }
}
