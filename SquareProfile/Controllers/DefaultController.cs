using Microsoft.AspNetCore.Mvc;

namespace SquareProfile.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
