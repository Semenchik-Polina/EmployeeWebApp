using System;

namespace EmployeeWebApp.Models
{
    public class EmployeeViewModel
    {
        public int EmployeeID { get; set; }
        public string JobTitle { get; set; }
        public int Salary { get; set; }
        public DateTime? HiredAt { get; set; }
        public DateTime? FiredAt { get; set; }

        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}