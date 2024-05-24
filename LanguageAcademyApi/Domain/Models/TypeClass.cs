using System.ComponentModel.DataAnnotations;

namespace LanguageAcademyApi.Domain.Models
{
    public class TypeClass
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }
    }
}
