using Microsoft.AspNetCore.Mvc;
using PierresBakery.Models;
using System.Collections.Generic;

namespace Pierres.Controllers
{
    public class OrderController : Controller
    {
        [HttpGet("/orders")]
        public ActionResult Index()
        {
            List<Order> allOrders = Order.GetAll();
            return View(allOrders);
        }

        [HttpGet("/orders/new")]
        public ActionResult New()
        {
            return View("New");
        }
    }
}