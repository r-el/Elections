using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace API.Entities
{
    public class Problem
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public VoterPhoneInElections VoterPhoneInElections { get; set; }

        [Display(Name = "האם נפתרה")]
        [Required]
        public bool Status { get; set; } = false;

        [Display(Name = "תוכן התקלה")]
        [Required]
        public string Description { get; set; }

        public List<ProblemNotes> ProblemNotes { get; set; }
    }
}
