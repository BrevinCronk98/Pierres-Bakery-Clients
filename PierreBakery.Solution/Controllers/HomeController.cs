using Microsoft.AspNetCore.Mvc;
using PierresBakery.Models;
using System.Collections.Generic;


namespace PierresBakery.Controllers
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