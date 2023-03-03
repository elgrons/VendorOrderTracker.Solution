using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrderTracker.Models;
using System.Collections.Generic; 
using System;

namespace VendorOrderTracker.Tests
{
  [TestClass]

  public class OrderTests
  {
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("test", "test", 1, "Thursday");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetTitle_ReturnTitle_String()
    {
      string title = "Test";
      string description = "Bread";
      int price = 100;
      string date = "Thursday";
      Order newOrder = new Order(title, description, price, date);
      string result = newOrder.Title;
      Assert.AreEqual(title, result);
    }

  }
}