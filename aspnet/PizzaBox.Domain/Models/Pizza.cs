using System.Collections.Generic;

namespace PizzaBox.Domain.Models
{
  public class Pizza
  {
    public long PizzaID { get; set; }

    public List<PizzaTopping> PizzaToppings { get; set; }

    public decimal Price { get; set; }

    public Order Order { get; set; }

    public bool HasOrder { get; set; }

    public Crust Crust { get; set; }

    public Size Size { get; set; }

    public string Name { get; set; }

    public Pizza()
    {

    }

    public override string ToString()
    {
      return $"{PizzaID} {Name} {Price} {Crust.Name} {Size.Name} {PizzaToppings.Count}";
    }

  }
}
