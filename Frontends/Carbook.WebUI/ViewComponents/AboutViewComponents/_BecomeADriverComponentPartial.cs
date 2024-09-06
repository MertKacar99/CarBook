using Microsoft.AspNetCore.Mvc;

namespace Carbook.WebUI.ViewComponents.AboutViewComponents
{
    public class _BecomeADriverComponentPartial : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
             return View();
        }
    }
}
