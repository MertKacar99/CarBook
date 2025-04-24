using Microsoft.AspNetCore.Mvc;

namespace Carbook.WebUI.Controllers
{
    public class AdminCarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
