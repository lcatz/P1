using System;
using System.Collections.Generic;


namespace PizzaBox.Domain.Models
{
  public class Order
  {
    public Store Store { get; set; }

    public string StoreName { get; set; }

    public long OrderID { get; set; }

    public User User { get; set; }

    public string UserName { get; set; }

    public List<Pizza> Pizzas { get; set; }
  }
}
