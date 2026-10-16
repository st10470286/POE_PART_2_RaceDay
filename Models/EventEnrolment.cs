using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RaceDay.API.Models
{
    public class EventEnrolment
    {
        [Key]
        public int EnrolmentId { get; set; }

        [Required]
        public int ParticipantId { get; set; }

        [Required]
        public int CategoryId { get; set; }

        public DateTime EnrolmentDate { get; set; } = DateTime.UtcNow;

        [Required, MaxLength(20)]
        public string PaymentStatus { get; set; } = "Paid"; // Pending, Paid, Cancelled

        // Navigation
        [ForeignKey("ParticipantId")]
        public User? Participant { get; set; }

        [ForeignKey("CategoryId")]
        public EventCategory? Category { get; set; }

        public Result? Result { get; set; }
    }
}