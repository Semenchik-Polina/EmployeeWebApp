using EmployeeBLL.Interfaces;
using EmployeeBLL.DTO;
using EmployeeWebApp.Utils;
using EmployeeWebApp.Models;
using System.Web.Mvc;
using System.Web.UI;
using System.Collections.Generic;

namespace EmployeeWebApp.Controllers
{
    [RoutePrefix("employees")]
    public class EmployeesController : Controller
    {
        private readonly IEmployeeService employeeService;
        private readonly AMapper aMapper;

        public EmployeesController(IEmployeeService service)
        {
            employeeService = service;
            aMapper = new AMapper();
        }

        /// <summary>
        /// Get all employees 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route]
        [OutputCache(Location = OutputCacheLocation.None)]
        public ActionResult GetAll()
        {
            var employeeDTOs = employeeService.GetAll();
            var employeeVMs = aMapper.Mapper.Map<IEnumerable<EmployeeGetDTO>, IEnumerable<EmployeeViewModel>>(employeeDTOs);
            var employees = Json(employeeVMs, JsonRequestBehavior.AllowGet);
            return employees;
        }


    }
}