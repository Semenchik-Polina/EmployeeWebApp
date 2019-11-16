using EmployeeBLL.DTO;
using System.Collections.Generic;

namespace EmployeeBLL.Interfaces
{
    public interface ICandidateService
    {
        IEnumerable<CandidateGetDTO> GetAll();
    }
}
