using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace EmployeeDAL.Entities
{
    public class Candidate
    {
        [Key]
        public int CandidateID { get; set; }

        [Required(ErrorMessage = "Vacancy is required")]
        public string Vacancy { get; set; }

        public DateTime? InterviewBeginsAt { get; set; }

        [Required(ErrorMessage = "Person ID is required")]
        [ForeignKey("Person")]
        public int FK_PersonID { get; set; }
        public Person Person { get; set; }
    }
}