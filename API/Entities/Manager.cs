using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace API.Entities
{
    public class Manager
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "שם מלא")]
        [Required(ErrorMessage = "הזן שם מלא")]
        public string FullName { get; set; }

        [Display(Name = "מספר טלפון")]
        [Required(ErrorMessage = "הזן מספר טלפון")]
        public string Phone { get; set; }

        [Display(Name = "כתובת מייל")]
        [Required(ErrorMessage = "הזן כתובת מייל")]
        [EmailAddress(ErrorMessage = "נא הכנס כתובת מייל נכונה")]
        public string Mail { get; set; }

        [Display(Name = "סיסמא")]
        [Required(ErrorMessage = "הזן סיסמא")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public List<Elections> Elections { get; set; }
    }
}
