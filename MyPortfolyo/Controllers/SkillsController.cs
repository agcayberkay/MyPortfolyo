using Microsoft.AspNetCore.Mvc;
using MyPortfolyo.DAL.Context;
using MyPortfolyo.DAL.Entities;

namespace MyPortfolyo.Controllers
{
    public class SkillsController : Controller
    {
        MyPortfolioContext portfolioContext = new MyPortfolioContext();
        public IActionResult SkillsList()
        {
            var values = portfolioContext.Skills.ToList();
            return View(values);
        }

        [HttpGet]

        public IActionResult CreateSkils()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateSkils(Skils skils)
        {
            portfolioContext.Skills.Add(skils);
            portfolioContext.SaveChanges();
            return RedirectToAction("SkillsList");
        }
        public IActionResult DeleteSkils(int id)
        {
            var skils = portfolioContext.Skills.Find(id);
            if (skils != null)
            {
                portfolioContext.Skills.Remove(skils);
                portfolioContext.SaveChanges();
            }
            return RedirectToAction("SkillsList");
        }

        [HttpGet]
        public IActionResult UpdateSkils(int id)
        {
            var skils = portfolioContext.Skills.Find(id);
            if (skils == null)
            {
                return NotFound();
            }
            return View(skils);
        }

        [HttpPost]

        public IActionResult UpdateSkils(Skils skils)
        {
            portfolioContext.Skills.Update(skils);
            portfolioContext.SaveChanges();
            return RedirectToAction("SkillsList");
        }
    }
}
