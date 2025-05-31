using Microsoft.AspNetCore.Mvc;
using MyPortfolyo.DAL.Context;
using MyPortfolyo.DAL.Entities;

namespace MyPortfolyo.Controllers
{
    public class ToDoListController : Controller
    {
        MyPortfolioContext portfolioContext = new MyPortfolioContext();
        public IActionResult Index()
        {
            var values = portfolioContext.ToDoList.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddToDo()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddToDo(ToDoList toDo)
        {
            portfolioContext.ToDoList.Add(toDo);
            portfolioContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteToDo(int id)
        {
            var value = portfolioContext.ToDoList.Find(id);
            portfolioContext.ToDoList.Remove(value);
            portfolioContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateToDo(int id)
        {
            var value = portfolioContext.ToDoList.Find(id);
            return View(value);
        }


        [HttpPost]
        public IActionResult UpdateToDo(ToDoList toDo)
        {
            portfolioContext.ToDoList.Update(toDo);
            portfolioContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult CompletedToDo(int id)
        {
            var value = portfolioContext.ToDoList.Find(id);
            value.Status = true;
            portfolioContext.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult UnCompletedToDo(int id)
        {
            var value = portfolioContext.ToDoList.Find(id);
            value.Status = false;
            portfolioContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
