using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrderTracker.Models;
using System.Collections.Generic; 
using System;

namespace VendorOrderTracker.Tests
{
  [TestClass]

  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreateInstanceofVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test vendor", "test description");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnName_String()
    {
      string name = "Test Vendor";
      string description = "Test Description";
      Vendor newVendor = new Vendor(name, description);
      string result = newVendor.Name;
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetDescription_ReturnDescription_String()
    {
      string name = "Test Vendor";
      string description = "Test Description";
      Vendor newVendor = new Vendor(name, description);
      string result = newVendor.Description;
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      string name = "Test Vendor";
      string description = "Test Description";
      Vendor newVendor = new Vendor(name, description);
      int result = newVendor.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendorsFromList_VendorList()
    {
      string vendor1 = "Vendor1";
      string vendor2 = "Vendor2";
      string description1 = "Test description1";
      string description2 = "Test description2";
      Vendor newVendor1 = new Vendor(vendor1, description1);
      Vendor newVendor2 = new Vendor(vendor2, description2);
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      string vendor1 = "Wellspent Market";
      string vendor2 = "New Seasons";
      string description1 = "Bread";
      string description2 = "Pastries";
      Vendor newVendor1 = new Vendor(vendor1, description1);
      Vendor newVendor2 = new Vendor(vendor2, description2);
      Vendor result = Vendor.Find(2);
      Assert.AreEqual(newVendor2, result);
    }

    [TestMethod]
    public void AddOrder_AssociatesOrderWithVendor_OrderList()
    {
      string orderTitle = "Invoice";
      string orderDescription = "Bread";
      int orderPrice = 100;
      string orderDate = "Monday";
      Order newOrder = new Order(orderTitle, orderDescription, orderPrice, orderDate);
      List<Order> newList = new List<Order> { newOrder };

      string name = "Wellspent Market";
      string description = "NE Burnside location";
      Vendor newVendor = new Vendor(name, description);
      newVendor.AddOrder(newOrder);

      List<Order> result = newVendor.Orders;
      CollectionAssert.AreEqual(newList, result);
    }

  }
}