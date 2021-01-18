using System.Collections.Generic;
using System.Linq;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storing.Repository
{
  public class PizzaRepository
  {
    private  PizzaBoxContext _ctx;

    public PizzaRepository(PizzaBoxContext context)
    {
      _ctx = context;
    }

    public List<Pizza> Get()
    {
      return _ctx.Pizza.ToList();
    }

    public Pizza Get(long id)
    {
      return _ctx.Pizza.SingleOrDefault(p => p.PizzaID == id);
    }

    public bool Post(Pizza pizza)
    {
      _ctx.Pizza.Add(pizza);
      return _ctx.SaveChanges() == 1;
    }

    public bool Put(Pizza pizza)
    {
      Pizza SelectedPizza =Get(pizza.PizzaID);

      SelectedPizza = pizza;
      return _ctx.SaveChanges() == 1;
    }
  }
}
