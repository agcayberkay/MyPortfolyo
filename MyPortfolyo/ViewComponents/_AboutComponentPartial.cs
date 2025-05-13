using Microsoft.AspNetCore.Mvc;
using MyPortfolyo.DAL.Context;

namespace MyPortfolyo.ViewComponents
{
    public class _AboutComponentPartial:ViewComponent
    {
        MyPortfolioContext portfolioContext = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
        ViewBag.Title = portfolioContext.Abouts.Select(x=>x.Title).FirstOrDefault();
        ViewBag.AboutSubDesc = portfolioContext.Abouts.Select(x=>x.SubDesc).FirstOrDefault();
        ViewBag.AboutDetail = portfolioContext.Abouts.Select(x=>x.Details).FirstOrDefault();
            return View();
        }
    }
}
