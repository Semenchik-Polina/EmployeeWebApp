using EmployeeDAL.Interfaces;
using EmployeeDAL.Entities;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeDAL.Repositories
{
    public class EmployeeRepository: IEmployeeRepository
    {
        private EmployeeContext db = new EmployeeContext();

        /// <summary>
        /// Get all employees from db
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Employee> GetAll()
        {
            IEnumerable<Employee> employees = db.Employees;
            foreach (Employee employee in employees)
            {
                int personID = employee.FK_PersonID;
                Person person = db.Persons.FirstOrDefault(pers => pers.PersonID == personID);
                employee.Person = person;
            }

            return employees;
        }
    }
}
