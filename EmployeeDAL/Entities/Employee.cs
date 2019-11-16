using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeDAL.Entities
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }

        [Required(ErrorMessage = "Position is required")]
        public string JobTitle { get; set; }

        [Required(ErrorMessage = "Salary is required")]
        public int Salary { get; set; }

        //[Required(ErrorMessage = "Hiring date is required")]
        public DateTime? HiredAt { get; set; }

        public DateTime? FiredAt { get; set; }

        [Required(ErrorMessage = "Person ID is required")]
        [ForeignKey("Person")]
        public int FK_PersonID { get; set; }
        public Person Person { get; set; }
    }
}