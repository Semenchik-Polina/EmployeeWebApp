using System;

namespace EmployeeBLL.DTO
{
    public class CandidateGetDTO
    {
        public int CandidateID { get; set; }

        public string Vacancy { get; set; }

        public DateTime? InterviewBeginsAt { get; set; }

        public PersonGetDTO Person { get; set; }
    }
}
