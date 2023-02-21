using Microsoft.AspNetCore.Mvc;

namespace HRM.WebMVCApp.Controllers
{
    public class CandidateController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
