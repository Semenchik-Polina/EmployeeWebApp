using EmployeeBLL.DTO;
using EmployeeBLL.Interfaces;
using EmployeeBLL.Utils;
using EmployeeDAL.Entities;
using EmployeeDAL.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeBLL.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly EmployeeRepository EmployeeRepository;
        private readonly AMapper AMapper; 

        public EmployeeService()
        {
            EmployeeRepository = new EmployeeRepository();
            AMapper = new AMapper();
        }
        
        /// <summary>
        /// Get all employees in asc order by FiredAt
        /// </summary>
        /// <returns></returns>
        public IEnumerable<EmployeeGetDTO> GetAll()
        {
            var employeeEntities = EmployeeRepository.GetAll();
            IEnumerable<Employee> currentemployeeEntities = employeeEntities.OrderBy(employee => employee.FiredAt);
            var employeeDTOs = AMapper.Mapper.Map<IEnumerable<Employee>, IEnumerable<EmployeeGetDTO>>(currentemployeeEntities);
            return employeeDTOs;
        }

    }
}
