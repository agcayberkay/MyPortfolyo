using Microsoft.AspNetCore.Mvc;

namespace MyPortfolyo.ViewComponents
{
    public class _StatisticComponenetPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
