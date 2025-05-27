using Microsoft.AspNetCore.Mvc;
using MyPortfolyo.DAL.Context;
using MyPortfolyo.DAL.Entities;

namespace MyPortfolyo.Controllers
{
    public class AboutController : Controller
    {
        MyPortfolioContext portfolioContext = new MyPortfolioContext();
        public IActionResult AboutList()
        {
            var values = portfolioContext.Abouts.ToList();
            return View(values);
        }


        [HttpGet]
        public IActionResult UpdateAbout(int id)
        {
            var about = portfolioContext.Abouts.Find(id);
            if (about == null)
            {
                return NotFound();
            }
            return View(about);
        }

        [HttpPost]
        public IActionResult UpdateAbout(About about)
        {
            portfolioContext.Abouts.Update(about);
            portfolioContext.SaveChanges();
            return RedirectToAction("AboutList");
        }
    }
}
