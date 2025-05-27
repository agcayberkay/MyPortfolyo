using Microsoft.AspNetCore.Mvc;
using MyPortfolyo.DAL.Context;
using MyPortfolyo.DAL.Entities;

namespace MyPortfolyo.Controllers
{
    public class ExperienceController : Controller
    {
        MyPortfolioContext portfolioContext = new MyPortfolioContext();
        public IActionResult ExperienceList()
        {
            var values = portfolioContext.Experiences.ToList();
            return View(values);
        }

        [HttpGet]

        public IActionResult CreateExperience()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateExperience(Experience experience)
        {
            portfolioContext.Experiences.Add(experience);
            portfolioContext.SaveChanges();
            return RedirectToAction("ExperienceList");
        }
        public IActionResult DeleteExperience(int id)
        {
            var experience = portfolioContext.Experiences.Find(id);
            if (experience != null)
            {
                portfolioContext.Experiences.Remove(experience);
                portfolioContext.SaveChanges();
            }
            return RedirectToAction("ExperienceList");
        }

        [HttpGet]
        public IActionResult UpdateExperience(int id)
        {
            var experience = portfolioContext.Experiences.Find(id);
            if (experience == null)
            {
                return NotFound();
            }
            return View(experience);
        }

        [HttpPost]

        public IActionResult UpdateExperience( Experience experience)
        {
          portfolioContext.Experiences.Update(experience);
            portfolioContext.SaveChanges();
            return RedirectToAction("ExperienceList");
        }
    }
}
