using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RaceDay.API.Models
{
    public class Result
    {
        [Key]
        public int ResultId { get; set; }

        [Required]
        public int EnrolmentId { get; set; }

        [Required, MaxLength(20)]
        public string FinishTime { get; set; } = string.Empty;

        [Required]
        public int OverallPosition { get; set; }

        [Required]
        public int CategoryPosition { get; set; }

        [Required, MaxLength(20)]
        public string Status { get; set; } = "Finished"; // Finished, DNF, DNS, Disqualified

        // Navigation
        [ForeignKey("EnrolmentId")]
        public EventEnrolment? Enrolment { get; set; }
    }
}