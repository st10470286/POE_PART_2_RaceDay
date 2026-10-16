using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RaceDay.API.Models
{
    public class EventCategory
    {
        [Key]
        public int CategoryId { get; set; }

        [Required]
        public int EventId { get; set; }

        [Required, MaxLength(100)]
        public string CategoryName { get; set; } = string.Empty;

        [Required, Column(TypeName = "decimal(5,2)")]
        public decimal DistanceKm { get; set; }

        [Required, Column(TypeName = "decimal(10,2)")]
        public decimal EntryFee { get; set; }

        public int MaxParticipants { get; set; } = 500;

        // Navigation
        [ForeignKey("EventId")]
        public Event? Event { get; set; }

        public ICollection<EventEnrolment> Enrolments { get; set; } = new List<EventEnrolment>();
    }
}