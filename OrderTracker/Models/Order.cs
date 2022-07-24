using System.Collections.Generic;

namespace OrderTracker.Models
{
  public class Order
  {
    // Change 'Details' to 'Title'
    public string Title { get; set; }
    public string Description { get; set; }
    public int Price{ get; set; }
    public string Date { get; set; }
    public int Id { get; }
    private static List<Order> _instances = new List<Order> {}; 

    // ADD "string orderDescription" and others
    public Order(string orderTitle, string orderDescription, int orderPrice, string orderDate)
    {
      Title = orderTitle;
      Description = orderDescription;
      Price = orderPrice;
      Date = orderDate;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

      public static Order Find(int searchId)
    {
      return _instances[searchId-1];
    }  
  }
}