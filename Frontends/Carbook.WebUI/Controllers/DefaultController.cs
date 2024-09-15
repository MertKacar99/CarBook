using Microsoft.AspNetCore.Mvc;

namespace Carbook.WebUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
