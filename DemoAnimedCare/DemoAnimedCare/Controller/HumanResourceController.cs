using Microsoft.AspNetCore.Mvc;

namespace DemoAnimedCare.Controller
{
    public class HumanResourceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
