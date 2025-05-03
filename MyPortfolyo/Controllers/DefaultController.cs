using Microsoft.AspNetCore.Mvc;

namespace MyPortfolyo.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.v = "https://i.hizliresim.com/aeprmr5.jpg";
            return View();
        }
    }
}
