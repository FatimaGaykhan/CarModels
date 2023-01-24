using Microsoft.AspNetCore.Mvc;

namespace CarModelsTask.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
