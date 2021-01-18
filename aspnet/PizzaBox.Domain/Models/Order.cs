using System;
using System.Collections.Generic;


namespace PizzaBox.Domain.Models
{
  public class Order
  {
    public Store Store { get; set; }

    public long StoreEntityID { get; set; }

    public long OrderID { get; set; }

    public User User { get; set; }

    public List<Pizza> Pizzas { get; set; }
  }
}
