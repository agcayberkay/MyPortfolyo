using Microsoft.AspNetCore.Mvc;
using MyPortfolyo.DAL.Context;
using MyPortfolyo.DAL.Entities;

namespace MyPortfolyo.Controllers
{
    public class DefaultController : Controller
    {
        MyPortfolioContext portfolioContext = new MyPortfolioContext();
        public IActionResult Index()
        {            
            ViewBag.v = "https://i.hizliresim.com/b8tksh2.jpeg";
            return View();
        }
    }
}
