﻿using Microsoft.AspNetCore.Mvc;
using MyPortfolyo.DAL.Context;

namespace MyPortfolyo.Controllers
{
    public class StatisticController : Controller
    {
        MyPortfolioContext portfolioContext = new MyPortfolioContext();
        public IActionResult Index()
        {
            ViewBag.v1 = portfolioContext.Skills.Count();
            ViewBag.v2 = portfolioContext.Messages.Count();
            ViewBag.v3 = portfolioContext.Messages.Where(x=> x.IsRead==false).Count();
            ViewBag.v4 = portfolioContext.Messages.Where(x=> x.IsRead==true).Count();
            ViewBag.v5 = portfolioContext.Experiences.Count();
            ViewBag.v6 = portfolioContext.Contacts.Count();
            ViewBag.v7 = portfolioContext.Testimonials.Count();
            return View();
        }
    }
}
