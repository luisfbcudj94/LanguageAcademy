using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LanguageAcademyApi.Domain.Models
{
    public class Class
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public Guid TypeClassId { get; set; }

        [ForeignKey("TypeClassId")]
        public TypeClass TypeClass { get; set; }

        [Required]
        public int MaxSlots { get; set; }

        [Required]
        public int AvailableSlots { get; set; }

        [Required]
        public DateTime StartAt { get; set; }

        [Required]
        public DateTime EndAt { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        [Required]
        public DateTime UpdatedAt { get; set; }

        [Required]
        public Guid TeacherId { get; set; }

        [ForeignKey("TeacherId")]
        public User Teacher { get; set; }

        [Required]
        public ClassStatus Status { get; set; }
    }
    public enum ClassStatus
    {
        Active = 0,
        Canceled = 1
    }
}
