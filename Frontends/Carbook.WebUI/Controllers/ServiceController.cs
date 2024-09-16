using Carbook.Dto.ServiceDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;

namespace Carbook.WebUI.Controllers
{
    public class ServiceController : Controller
    {
 

        public IActionResult Index()
        {
           return View();
        }

    }
}
