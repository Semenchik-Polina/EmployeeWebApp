using System;

namespace EmployeeWebApp.Models
{
    public class CandidateViewModel
    {
        public int CandidateID { get; set; }
        public string Vacancy { get; set; }
        public DateTime? InterviewBeginsAt { get; set; }
        
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}