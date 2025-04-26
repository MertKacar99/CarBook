using Carbook.Dto.BrandDtos;
using Carbook.Dto.CarDtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;

namespace Carbook.WebUI.Controllers
{
    public class AdminCarController : Controller
    {
        private IHttpClientFactory httpClientFactory;

        public AdminCarController(IHttpClientFactory _httpClientFactory)
        {
            this.httpClientFactory = _httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7233/api/Cars/GetCarWithBrand");
            if (responseMessage.IsSuccessStatusCode)
            {
               var jsonData = await responseMessage.Content.ReadAsStringAsync();
               var values= JsonConvert.DeserializeObject<List<ResultCArWithBrandsDtos>>(jsonData);
               return View(values);


            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> CreateCar()
        {
            var client = httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7233/api/Brands");
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultBrandDto>>(jsonData);
            List<SelectListItem> brandValues =(from x in values
                                               select new SelectListItem
                                               {
                                                   Text = x.name,
                                                   Value = x.brandID.ToString()
                                               }).ToList();
            ViewBag.brandValues = brandValues;
            return View();
        }

    }
}
