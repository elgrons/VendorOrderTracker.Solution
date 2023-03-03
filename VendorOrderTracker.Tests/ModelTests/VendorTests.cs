using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrderTracker.Models;
using System.Collections.Generic; 
using System;

namespace VendorOrderTracker.Tests
{
  [TestClass]

  public class VendorTests
  {
    [TestMethod]
    public void VendorConstructor_CreateInstanceofVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test vendor", "test desription");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }


  }
}