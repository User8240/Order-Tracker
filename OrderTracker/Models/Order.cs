using System.Collections.Generic;

namespace OrderTracker.Models
{
  public class Order
  {
    public string Name { get; set; }
    public string Description { get; set; }

    public Order(string orderName, string orderDescription)
    {
      Name = orderName;
      Description = orderDescription;
    }
      
  }
}