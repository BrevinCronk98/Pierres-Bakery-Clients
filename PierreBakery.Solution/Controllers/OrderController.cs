using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;
using System.Collections.Generic;

namespace Pierres.Orders.Controllers
{
    public class OrderController : Controllers
    {
        [HttpGet("/orders")]
        public ActionResult Index()
        {
            List<Order> allOrders = Order.GetAll();
            return View(allOrders);
        }
    }
}