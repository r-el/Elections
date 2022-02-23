using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace API.Entities
{
    public class Candidate
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "שם מלא")]
        [Required]
        public string FullName { get; set; }

        public Elections Elections { get; set; }

        public List<VoterPhoneInElections> Voters { get; set; }

    }
}
