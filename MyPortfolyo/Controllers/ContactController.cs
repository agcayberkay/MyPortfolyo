using Microsoft.AspNetCore.Mvc;
using MyPortfolyo.DAL.Context;
using MyPortfolyo.DAL.Entities;

namespace MyPortfolyo.Controllers
{
    public class ContactController : Controller
    {
        MyPortfolioContext portfolioContext = new MyPortfolioContext();
        public IActionResult ContactList()
        {
            var values = portfolioContext.Contacts.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddContact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddContact(Contact contact)
        {
            portfolioContext.Add(contact);
            portfolioContext.SaveChanges();
            return RedirectToAction("ContactList");
        }

        public IActionResult DeleteContact(int id)
        {
            var contact = portfolioContext.Contacts.Find(id);
            portfolioContext.Contacts.Remove(contact);
            portfolioContext.SaveChanges();
            return RedirectToAction("ContactList");
        }

        [HttpGet]
        public IActionResult UpdateContact(int id)
        {
            var value = portfolioContext.Contacts.Find(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateContact(Contact Contact)
        {
            portfolioContext.Contacts.Update(Contact);
            portfolioContext.SaveChanges();
            return RedirectToAction("ContactList");
        }
    }
}
