using System;

namespace EmployeeBLL.DTO
{
    public class EmployeeGetDTO
    {
        public int EmployeeID { get; set; }

        public string JobTitle { get; set; }

        public int Salary { get; set; }

        public DateTime? HiredAt { get; set; }

        public DateTime? FiredAt { get; set; }

        public PersonGetDTO Person { get; set; }
    }
}
