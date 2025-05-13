using Microsoft.AspNetCore.Mvc;

namespace MyPortfolyo.ViewComponents
{
    public class _ExperienceComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
