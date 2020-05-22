using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using PierresBakery.Models;

namespace PierresBakery.Controllers
{
  public class VendorsController : Controller
  {

    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
        return View();
    }

    [HttpPost("/vendors")]
    public ActionResult Create(string vendorName)
    {
        Vendor newVendor = new Vendor(vendorName);
        return RedirectToAction("Index");
    }

    [HttpGet("/vendors/{id}")]
    public ActionResult Show(int id)
    {
        Dictionary<string, object> vendorList = new Dictionary<string, object>();
        Vendor selectedVendor = Vendor.Find(id);
        List<Order> vendorOrders = selectedVendor.Orders;
        vendorList.Add("vendor", selectedVendor);
        vendorList.Add("orders", vendorOrders);
        return View(vendorList);
    }
    
    [HttpPost("/vendors/{vendorId}/orders")]
    public ActionResult Create(int vendorId, string orderDescription)
    {
       Dictionary<string, object> vendorList = new Dictionary<string, object>();
       Vendor foundVendor = Vendor.Find(vendorId);
       Order newOrder = new Order(orderDescription);
       List<Order> vendorOrders = foundVendor.Orders;
       vendorList.Add("order", vendorOrders);
       vendorList.Add("vendor", foundVendor);
       return View("Show", vendorList);
    }
  }
}