using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
  public class Size : AModel
  {
    public APizzaModel Pizza = new APizzaModel();

    public string Name { get; set; }

    public decimal Price { get; set; }

    public Size() { }

    public Size(string name, decimal price)
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
