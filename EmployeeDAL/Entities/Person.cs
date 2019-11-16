using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EmployeeDAL.Entities
{
    public class Person
    {
        [Key]
        public int PersonID { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage ="Surname is required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")]
        public string Email { get; set; }

        [StringLength(13, ErrorMessage ="Phone number length should be > 8 characters and < 13 characters",
            MinimumLength = 9)]
        public string PhoneNumber { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<Candidate> Candidates { get; set; }
    }
}