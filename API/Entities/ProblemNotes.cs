using System.ComponentModel.DataAnnotations;

namespace API.Entities
{
    public class ProblemNotes
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public Problem Problem { get; set; }

        [Required]
        public string SupervisorPhoneID { get; set; }

        [Display(Name = "הערות על תקלה")]
        [Required]
        public string Content { get; set; }
    }
}
