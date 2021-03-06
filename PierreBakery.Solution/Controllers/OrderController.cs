using Microsoft.AspNetCore.Mvc;
using PierresBakery.Models;
using System.Collections.Generic;
using System;

namespace PierresBakery.Controllers
{
    public class OrdersController : Controller
    {
        
        [HttpGet("/vendors/{vendorId}/orders/new")]
        public ActionResult New(int vendorId)
        {
            Vendor vendor = Vendor.Find(vendorId);
            return View(vendor);
        }

        [HttpGet("/vendors/{vendorId}/orders/{orderId}")]
        public ActionResult Show(int vendorId, int orderId)
        {
            Order order = Order.Find(orderId);
            Vendor vendor = Vendor.Find(vendorId);
            Dictionary<string, object> vendorList = new Dictionary<string, object>();
            vendorList.Add("orders", order);
            vendorList.Add("vendors", vendor);
            return View(vendorList);
        }

         [HttpPost("/orders/delete")]
        public ActionResult DeleteAll()
        {
            Order.ClearAll();
            return RedirectToAction("Index");
        }

    }
}