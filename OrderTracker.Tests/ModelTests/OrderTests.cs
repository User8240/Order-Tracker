using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using OrderTracker.Models;
namespace OrderTracker.Tests
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
      Order newOrder = new Order("orderTitle", "orderDescription", 5, "orderDate");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetAllProperties_ReturnsProperties_String()
    {
      // Arrange
      Order newOrder = new Order("orderTitle", "orderDescription", 5, "orderDate");

      // Act
      string result = newOrder.Title;
      string resultOne = newOrder.Description;
      int resultTwo = newOrder.Price;
      string resultThree = newOrder.Date;

      // Assert
      Assert.AreEqual("orderTitle", result);
      Assert.AreEqual("orderDescription", resultOne);
      Assert.AreEqual(5, resultTwo);
      Assert.AreEqual("orderDate", resultThree);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      // Arrange
      List<Order> newList = new List<Order> { };

      // Act
      List<Order> result = Order.GetAll();

      // Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsOrders_OrderList()
    {
      //Arrange
      Order newOrderOne = new Order("orderTitle", "orderDescription", 5, "orderDate");
      Order newOrderTwo = new Order("orderTitle", "orderDescription", 5, "orderDate");
      List<Order> newList = new List<Order> { newOrderOne, newOrderTwo };

      //Act
      List<Order> result = Order.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_OrdersInstantiateWithAnIdAndGetterReturns_Int()
    {
      //Arrange
      Order newOrder = new Order("orderTitle", "orderDescription", 5, "orderDate");

      //Act
      int result = newOrder.Id;

      //Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      //Arrange
      Order newOrderOne = new Order("orderTitle", "orderDescription", 5, "orderDate");
      Order newOrderTwo = new Order("orderTitle", "orderDescription", 5, "orderDate");

      //Act
      Order result = Order.Find(2);

      //Assert
      Assert.AreEqual(newOrderTwo, result);
    }
  }
} 