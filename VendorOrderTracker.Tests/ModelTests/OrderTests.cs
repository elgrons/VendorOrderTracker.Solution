using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrderTracker.Models;
using System.Collections.Generic; 
using System;

namespace VendorOrderTracker.Tests
{
  [TestClass]

  public class OrderTests : IDisposable
  { 
    public void Dispose()
    {
      Order.ClearAll();
    }
  
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

    [TestMethod]
    public void GetDescription_ReturnDescription_String()
    {
      string title = "Test";
      string description = "Bread";
      int price = 100;
      string date = "Thursday";
      Order newOrder = new Order(title, description, price, date);
      string result = newOrder.Description;
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void GetPrice_ReturnPrice_Int()
    {
      string title = "Test";
      string description = "Bread";
      int price = 100;
      string date = "Thursday";
      Order newOrder = new Order(title, description, price, date);
      int result = newOrder.Price;
      Assert.AreEqual(price, result);
    }

    [TestMethod]
    public void GetDate_ReturnDate_String()
    {
      string title = "Test";
      string description = "Bread";
      int price = 100;
      string date = "Thursday";
      Order newOrder = new Order(title, description, price, date);
      string result = newOrder.Date;
      Assert.AreEqual(date, result);
    }

    [TestMethod]
    public void SetTitle_SetTitle_String()
    { 
      string title = "First Order";
      string description = "Bread";
      int price = 100;
      string date = "Thursday";
      Order newOrder = new Order(title, description, price, date);
      string updatedTitle = "Second Order";
      newOrder.Title = updatedTitle;
      string result = newOrder.Title;
      Assert.AreEqual(updatedTitle, result);
    }

    [TestMethod]
    public void SetDescription_SetDescription_String()
    { 
      string title = "First Order";
      string description = "Bread";
      int price = 100;
      string date = "Thursday";
      Order newOrder = new Order(title, description, price, date);
      string updatedDescription = "Pastries";
      newOrder.Description = updatedDescription;
      string result = newOrder.Description;
      Assert.AreEqual(updatedDescription, result);
    }

  }
}