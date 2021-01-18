using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
  public class Topping : AModel
  {
    public string Name { get; set; }

    public decimal Price { get; set; }

    public Topping() { }

    public Topping(string name, decimal price)
    {
      Name = name;
      Price = price;
    }

    public override string ToString()
    {
      return $"{Name}";
    }
  }
}
