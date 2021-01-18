using System;
using System.Collections.Generic;

namespace PizzaBox.Domain.Models
{
  public class Topping
  {
    public long ToppingID { get; set; }

    public string Name { get; set; }

    public decimal Price { get; set; }

    public List<PizzaTopping> PizzaToppings { get; set; }

    public Topping()
    {
      ToppingID = DateTime.Now.Ticks;
    }
  }
}
