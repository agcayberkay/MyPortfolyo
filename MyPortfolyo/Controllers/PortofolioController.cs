using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.Blazor;
using MyPortfolyo.DAL.Context;
using MyPortfolyo.DAL.Entities;

namespace MyPortfolyo.Controllers
{
    public class PortofolioController : Controller
    {
        MyPortfolioContext portfolioContext = new MyPortfolioContext();
        public IActionResult PortofolioList()
        {
            var values = portfolioContext.Portofilos.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddPortfolyo()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddPortfolyo(Portofilo portofilo)
        {
            portfolioContext.Add(portofilo);
            portfolioContext.SaveChanges();
            return RedirectToAction("PortofolioList");
        }

        [HttpGet]
        public IActionResult UpdatePortfolyo(int id)
        {
            var value = portfolioContext.Portofilos.Find(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdatePortfolyo(Portofilo portofilo)
        {

            portfolioContext.Portofilos.Update(portofilo);
            portfolioContext.SaveChanges();
            return RedirectToAction("PortofolioList");
        }

        public IActionResult DeletePortfolyo(int id)
        {
            var value = portfolioContext.Portofilos.Find(id);
            portfolioContext.Portofilos.Remove(value);
            portfolioContext.SaveChanges();
            return RedirectToAction("PortofolioList");
        }
    }
}
