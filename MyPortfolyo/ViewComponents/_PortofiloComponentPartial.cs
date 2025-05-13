using Microsoft.AspNetCore.Mvc;

namespace MyPortfolyo.ViewComponents
{
    public class _PortofiloComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }   
    }
}
