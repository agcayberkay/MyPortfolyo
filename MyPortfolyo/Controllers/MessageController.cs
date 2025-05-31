using Microsoft.AspNetCore.Mvc;
using MyPortfolyo.DAL.Context;

namespace MyPortfolyo.Controllers
{
    public class MessageController : Controller
    {
        MyPortfolioContext portfolioContext = new MyPortfolioContext();
        public IActionResult Inbox()
        {
            var values = portfolioContext.Messages.ToList();
            return View(values);
        }

        public IActionResult ChangeIsReadTrue(int id)
        {
            var values = portfolioContext.Messages.Find(id);
            values.IsRead = true;
            portfolioContext.SaveChanges();
            return RedirectToAction("Inbox");
        }
        public IActionResult ChangeIsReadFalse(int id)
        {
            var values = portfolioContext.Messages.Find(id);
            values.IsRead = false;
            portfolioContext.SaveChanges();
            return RedirectToAction("Inbox");
        }

        public IActionResult DeleteMessage(int id)
        {
            var values = portfolioContext.Messages.Find(id);
            portfolioContext.Messages.Remove(values);
            portfolioContext.SaveChanges();
            return RedirectToAction("Inbox");
        }

        public IActionResult MessageDetail(int id)
        {
            var values = portfolioContext.Messages.Find(id);
            return View(values);
        }
    }
}
