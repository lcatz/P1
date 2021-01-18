using System;
using System.Collections.Generic;


namespace PizzaBox.Domain.Models
{
  public class Crust
  {
    public List<Pizza> Pizzas { get; set; }
    public string Name { get; set; }

    public decimal Price { get; set; }

    public long CrustID { get; set; }

    public Crust()
    {
      CrustID = DateTime.Now.Ticks;
    }

  }
}
