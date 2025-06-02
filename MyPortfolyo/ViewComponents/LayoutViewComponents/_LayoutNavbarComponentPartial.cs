using Microsoft.AspNetCore.Mvc;
using MyPortfolyo.DAL.Context;

namespace MyPortfolyo.ViewComponents.LayoutViewComponents
{
    public class _LayoutNavbarComponentPartial : ViewComponent
    {
        MyPortfolioContext portfolioContext = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.toDoListCount = portfolioContext.ToDoList.Where(x=> x.Status==false).Count();
            var value = portfolioContext.ToDoList.Count(x => x.Status == false);
            return View(value);
        }
    }
}
