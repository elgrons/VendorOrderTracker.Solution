using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using VendorOrderTracker.Models;

namespace VendorOrderTracker.Controllers
{
  public class OrderController : Controller
  {
    [HttpGet("/orders/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/orders")]
    public ActionResult Create(string title, string description, int price, string date)
    {
      Order myOrder = new Order(title, description, price, date);
      return RedirectToAction("Index");
    }

    [HttpGet("/orders/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpGet("/orders/{id}")]
    public ActionResult Show(int id)
    {
      Order foundOrder = Order.Find(id);
      return View(foundOrder);
    }


  }
}