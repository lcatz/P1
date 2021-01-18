using System.Collections.Generic;

namespace PizzaBox.Domain.Models
{
  public class User
  {
    public string Name { get; set; }

    public List<Order> Orders { get; set; }

    public long UserID { get; set; }
  }
}
