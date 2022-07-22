using System.Collections.Generic;

namespace OrderTracker.Models
{
  public class Order
  {
    // Change 'Details' to 'Title'
    public string Details { get; set; }
    // Add fields below and display inside the current 'Details' link
    // public string Description { get; set; }
    // public string Price{ get; set; }
    // public string Date { get; set; }
    public int Id { get; }
    private static List<Order> _instances = new List<Order> {}; 

    // ADD "string orderDescription" and others
    public Order(string orderDetails)
    {
      Details = orderDetails;
      // Description = orderDescription; & ADD OTHERS
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