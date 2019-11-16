using EmployeeBLL.DTO;
using System.Collections.Generic;

namespace EmployeeBLL.Interfaces
{
    public interface IEmployeeService
    {
        IEnumerable<EmployeeGetDTO> GetAll();
    }
}
