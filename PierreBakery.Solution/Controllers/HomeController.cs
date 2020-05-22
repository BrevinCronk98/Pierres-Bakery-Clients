using Microsoft.AspNetCore.Mvc;

namespace PierresBakery.Home.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }
    }
}