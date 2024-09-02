using Microsoft.AspNetCore.Mvc;

namespace Carbook.WebUI.Controllers
{
    public class UILayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
