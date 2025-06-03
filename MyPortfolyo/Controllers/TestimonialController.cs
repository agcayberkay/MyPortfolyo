using Microsoft.AspNetCore.Mvc;
using MyPortfolyo.DAL.Context;
using MyPortfolyo.DAL.Entities;

namespace MyPortfolyo.Controllers
{
    public class TestimonialController : Controller
    {
        MyPortfolioContext portfolioContext = new MyPortfolioContext();
        public IActionResult TestimonialList()
        {
            var values = portfolioContext.Testimonials.ToList();
            return View(values);
        }


        public IActionResult TestimonialAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult TestimonialAdd(Testimonial testimonial)
        {
            portfolioContext.Testimonials.Add(testimonial);
            portfolioContext.SaveChanges();
            return RedirectToAction("TestimonialList");
        }

        public IActionResult TestimonialDelete(int id)
        {
            var value = portfolioContext.Testimonials.Find(id);
            portfolioContext.Testimonials.Remove(value);
            portfolioContext.SaveChanges();
            return RedirectToAction("TestimonialList");
        }

        public IActionResult TestimonialUpdate(int id)
        {
            var value = portfolioContext.Testimonials.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult TestimonialUpdate(Testimonial testimonial)
        {
            portfolioContext.Testimonials.Update(testimonial);
            portfolioContext.SaveChanges();
            return RedirectToAction("TestimonialList");
        }
    }
}
