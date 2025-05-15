using Microsoft.AspNetCore.Mvc;
using MyPortfolyo.DAL.Context;

namespace MyPortfolyo.ViewComponents
{
    public class _ExperienceComponentPartial:ViewComponent
    {
        MyPortfolioContext myPortfolioContext = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = myPortfolioContext.Experiences.ToList();
            return View(values);
        }
    }
}
