using System.Collections.Generic;

namespace PierreBakery.Vendors.Models
{
  public class Vendor
  {
    private static List<Vendor> _instances = new List<Vendor> {};
    public string Name { get; set; }
    public int Id { get; }
    public List<Order> Orders { get; set; }

    public Vendor(string cendorName)
    {
      Name = categoryName;
      _instances.Add(this);
      Id = _instances.Count;
      Orders = new List<Order>{};
    }

     public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }

    public static Order Find(int searchId)
    {
      return _instances[searchId - 1];
    }

    public void AddOrder(Order order)
    {
      Order.Add(order);
    }
   
  }
}