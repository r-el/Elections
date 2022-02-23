using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace API.Entities
{
    public class VotingArea
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "שם האיזור")]
        [Required]
        public string Name { get; set; }

        [Required]
        public List<VoterPhoneInElections> Voters { get; set; }
    }
}
