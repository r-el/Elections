using System.ComponentModel.DataAnnotations;

namespace API.Entities
{ // טלפון של מצביע בבחירות 
    public class VoterPhoneInElections
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public Elections Elections { get; set; }

        [Required]
        public Voter Voter { get; set; }

        [Display(Name = "בחירת מועמד")]
        public Candidate Candidate { get; set; }

        // איזור בחירה
        public VotingArea VotingArea { get; set; }
    }
}
