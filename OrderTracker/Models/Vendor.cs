using System.Collections.Generic;

namespace OrderTracker.Models
{
  public class Vendor
  {
    public string Name { get; set; }
    public string Description { get; set; }

    public Vendor(string VendorName, string VendorDescription)
    {
      Name = VendorName;
      Description = VendorDescription;
    }

  }
}