using Microsoft.AspNetCore.Mvc;

namespace Carbook.WebUI.ViewComponents.BlogViewComponents
{
    public class _BlogDetailsAuthorAboutComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View(); 
        }
    }
}
