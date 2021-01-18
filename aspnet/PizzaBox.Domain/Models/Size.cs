using System;
using System.Collections.Generic;

namespace PizzaBox.Domain.Models
{
  public class Size
  {
    public long SizeID { get; set; }
    public string Name { get; set; }

    public decimal Price { get; set; }

    public List<Pizza> Pizzas { get; set; }

    public Size()
    {
      SizeID = DateTime.Now.Ticks;
    }
  }
}
