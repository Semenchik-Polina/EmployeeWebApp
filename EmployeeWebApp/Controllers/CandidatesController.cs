using EmployeeBLL.Interfaces;
using EmployeeBLL.DTO;
using EmployeeWebApp.Utils;
using EmployeeWebApp.Models;
using System.Web.Mvc;
using System.Web.UI;
using System.Collections.Generic;

namespace EmployeeWebApp.Controllers
{
    [RoutePrefix("candidates")]
    public class CandidatesController : Controller
    {
        private readonly ICandidateService candidateService;
        private readonly AMapper aMapper;
        
        public CandidatesController(ICandidateService service)
        {
            candidateService = service;
            aMapper = new AMapper();
        }

        /// <summary>
        /// Get all candidates having an interview no longer then a moth ago
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route]
        [OutputCache(Location = OutputCacheLocation.None)]
        public ActionResult GetAll()
        {
            var candidateDTOs = candidateService.GetAll();
            var candidateVMs = aMapper.Mapper.Map<IEnumerable<CandidateGetDTO>, IEnumerable<CandidateViewModel>>(candidateDTOs);
            var candidates = Json(candidateVMs, JsonRequestBehavior.AllowGet);
            return candidates;
        }
        
    }
}