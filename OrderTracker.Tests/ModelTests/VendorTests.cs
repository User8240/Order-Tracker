using System.Collections.Generic;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderTracker.Models;

namespace OrderTracker.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {

    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test name", "test description");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetNameAndDescription_ReturnsNameAndDescription_String()
    {
      //Arrange
      string name = "Test Vendor Name";
      string description = "Test Vendor Description";

      Vendor newVendor = new Vendor(name, description);

      //Act
      string result = newVendor.Name;
      string resultTwo = newVendor.Description;

      //Assert
      Assert.AreEqual(name, result);
      Assert.AreEqual(description, resultTwo);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      //Arrange
      string name = "Test Vendor Name";
      string description = "Test Vendor Description";

      Vendor newVendor = new Vendor(name, description);

      //Act
      int result = newVendor.Id;

      //Assert
      Assert.AreEqual(1, result);
    }
    
    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      //Arrange
      string name01 = "CompanyOne";
      string name02 = "CompanyTwo";
      Vendor newVendor1 = new Vendor(name01, "description placeholder");
      Vendor newVendor2 = new Vendor(name02, "description placeholder");
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };

      //Act
      List<Vendor> result = Vendor.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      //Arrange
      string name01 = "CompanyOne";
      string name02 = "CompanyTwo";
      Vendor newVendor1 = new Vendor(name01, "description placeholder");
      Vendor newVendor2 = new Vendor(name02, "description placeholder");

      //Act
      Vendor result = Vendor.Find(2);

      //Assert
      Assert.AreEqual(newVendor2, result);
    }

    [TestMethod]
    public void AddOrder_AssociatesOrderWithVendor_VendorList()
    {
      //Arrange
      Order newOrder = new Order("orderTitle", "orderDescription", 5, "orderDate");

      List<Order> newList = new List<Order> { newOrder };

      string name = "CompanyOne";
      Vendor newVendor = new Vendor(name, "vendorDescription");

      newVendor.AddOrder(newOrder);

      //Act
      List<Order> result = newVendor.Orders;

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }
  }
} 
