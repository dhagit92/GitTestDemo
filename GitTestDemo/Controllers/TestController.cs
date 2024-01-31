using Microsoft.AspNetCore.Mvc;

namespace GitTestDemo.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
