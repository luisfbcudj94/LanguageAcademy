using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LanguageAcademyApi.Domain.Models
{
    public class ScheduledClass
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public Guid StudentId { get; set; }

        [ForeignKey("StudentId")]
        public User Student { get; set; }

        [Required]
        public Guid ClassId { get; set; }

        [ForeignKey("ClassId")]
        public Class Class { get; set; }

        [Required]
        public ScheduledClassStatus Status { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        [Required]
        public DateTime UpdatedAt { get; set; }
    }
    public enum ScheduledClassStatus
    {
        Active,
        CanceledByTeacher,
        CanceledByStudent,
        RescheduledByTeacher,
        RescheduledByStudent
    }

}
