using System.Collections.Generic;

namespace EmployeeDAL.Interfaces
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
    }
}
