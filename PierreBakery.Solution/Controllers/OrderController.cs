using Microsoft.AspNetCore.Mvc;
using PierresBakery.Models;
using System.Collections.Generic;
using System;

namespace PierresBakery.Controllers
{
    public class OrdersController : Controller
    {
        [HttpGet("/orders")]
        public ActionResult Index()
        {
            List<Order> allOrders = Order.GetAll();
            return View(allOrders);
        }

        [HttpGet("/vendors/{vendorId}/orders/new")]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost("/orders")]
        public ActionResult Create(string description)
        {
            Order myOrder = new Order(description);
            return RedirectToAction("Index");
        }

        [HttpPost("orders/delete")]
        public ActionResult DeleteAll()
        {
            Order.ClearAll();
            return RedirectToAction("Index");
        }

        [HttpGet("/vendors/{vendorId}/orders/{orderId")]
        public ActionResult Show(int vendorId, int orderId)
        {
            Order order = Order.Find(orderId);
            Vendor vendor = Vendor.Find(vendorId);
            Dictionary<string, object> vendorList = new Dictionary<string, object>();
            vendorList.Add("order", order);
            vendorList.Add("vendor", vendor);
            return View(vendorList);
        }
    }
}