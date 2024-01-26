using Microsoft.AspNetCore.Mvc;

namespace gitproject.Controllers
{
    public class AlphaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
