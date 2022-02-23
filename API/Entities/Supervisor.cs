using System.ComponentModel.DataAnnotations;

namespace API.Entities
{
    public class Supervisor
    {
        [Key]
        public int Id { get; set; }

        [Required] // מקושר לטלפון של מצביע בבחירות
        public VoterPhoneInElections SupervisorID { get; set; }

        [Display(Name = "האם מפקח")]
        public bool IsSupervisor { get; set; } = true;
    }
}
