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

    [TestMethod]
    public void SetPrice_SetPrice_Int()
    { 
      string title = "First Order";
      string description = "Bread";
      int price = 100;
      string date = "Thursday";
      Order newOrder = new Order(title, description, price, date);
      int updatedPrice = 5000;
      newOrder.Price = updatedPrice;
      int result = newOrder.Price;
      Assert.AreEqual(updatedPrice, result);
    }

    [TestMethod]
    public void SetDate_SetDate_String()
    { 
      string title = "First Order";
      string description = "Bread";
      int price = 100;
      string date = "Thursday";
      Order newOrder = new Order(title, description, price, date);
      string updatedDate = "Friday";
      newOrder.Date = updatedDate;
      string result = newOrder.Date;
      Assert.AreEqual(updatedDate, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      List<Order> newList = new List<Order> { };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnOrders_OrderList()
    {
      string title1 = "Order Title1";
      string title2 = "Order Title2";
      string description1 = "Bread";
      string description2 = "Crossaints";
      int price1 = 100;
      int price2 = 2000;
      string date1 = "Thursday";
      string date2 = "Monday";
      Order newOrder1 = new Order(title1, description1, price1, date1);
      Order newOrder2 = new Order(title2, description2, price2, date2);      
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      string title1 = "Order Title1";
      string title2 = "Order Title2";
      string description1 = "Bread";
      string description2 = "Crossaints";
      int price1 = 100;
      int price2 = 2000;
      string date1 = "Thursday";
      string date2 = "Monday";
      Order newOrder1 = new Order(title1, description1, price1, date1);
      Order newOrder2 = new Order(title2, description2, price2, date2); 
      Order result = Order.Find(2);
      Assert.AreEqual(newOrder2, result);
    }
  }
}