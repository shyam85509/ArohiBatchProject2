using Microsoft.AspNetCore.Mvc;

namespace gitproject.Controllers
{
    public class AccController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
