using Microsoft.AspNetCore.Mvc;
using MyPortfolyo.DAL.Context;
using MyPortfolyo.DAL.Entities;

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

        [HttpPost]
        public IActionResult SendMessage(Message message)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { success = false, message = "Geçersiz veri." });

            message.SendDate = DateTime.Now;
            message.IsRead = false;
            portfolioContext.Messages.Add(message);
            portfolioContext.SaveChanges();

            return Ok(new { success = true, message = "Mesajınız gönderildi, teşekkür ederiz!" });
        }
    }
}
