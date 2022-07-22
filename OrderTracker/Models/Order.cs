using System.Collections.Generic;

namespace OrderTracker.Models
{
  public class Order
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public int Id { get; }
    private static List<Order> _instances = new List<Order> {}; 
     
    public Order(string orderName, string orderDescription)
    {
      Name = orderName;
      Description = orderDescription;
      _instances.Add(this);
      Id = _instances.Count;
    }

      public static Order Find(int searchId)
    {
      return _instances[searchId-1];
    }  
  }
}