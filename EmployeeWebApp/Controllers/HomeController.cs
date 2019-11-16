using System.Web.Mvc;

namespace EmployeeWebApp.Controllers
{
    public class HomeController : Controller
    {    
        public ActionResult Index()
        {
            return View();
        }
    }
}