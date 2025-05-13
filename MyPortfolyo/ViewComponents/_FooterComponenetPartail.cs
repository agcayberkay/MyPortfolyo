using Microsoft.AspNetCore.Mvc;

namespace MyPortfolyo.ViewComponents
{
    public class _FooterComponenetPartail:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
