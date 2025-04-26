using Carbook.Dto.CarDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Carbook.WebUI.Controllers
{
    public class AdminCarController : Controller
    {
        private IHttpClientFactory httpClientFactory;

        public AdminCarController(IHttpClientFactory httpClientFactory)
        {
            this.httpClientFactory = httpClientFactory;
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
    }
}
