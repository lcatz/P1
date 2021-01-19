using System.Collections.Generic;
using System.Linq;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storing.Repository
{
  public class ToppingRepository
  {
    private static readonly PizzaBoxContext _ctx = PizzaBoxContext.Instance;

    public List<Topping> Get()
    {
      return _ctx.Topping.ToList();
    }

    public Topping Get(string name)
    {
      return _ctx.Topping.SingleOrDefault(t => t.Name == name);
    }

    public Topping Get(long id)
    {
      return _ctx.Topping.SingleOrDefault(t => t.ToppingID == id);
    }

    public bool Post(Topping topping)
    {
      _ctx.Topping.Add(topping);
      return _ctx.SaveChanges() == 1;
    }

    public bool Put(Topping topping)
    {
      Topping SelectedTopping =Get(topping.ToppingID);

      SelectedTopping = topping;
      return _ctx.SaveChanges() == 1;
    }
  }
}
