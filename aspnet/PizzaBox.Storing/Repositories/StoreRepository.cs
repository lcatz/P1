using System.Collections.Generic;
using System.Linq;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storing.Repository
{
  public class StoreRepository
  {
    private static readonly PizzaBoxContext _ctx = PizzaBoxContext.Instance;

    public List<Store> Get()
    {
      return _ctx.Store.ToList();
    }

    public Store Get(string name)
    {
      return _ctx.Store.SingleOrDefault(s => s.Name == name);
    }

    public bool Post(Store store)
    {
      _ctx.Store.Add(store);
      return _ctx.SaveChanges() == 1;
    }

    public bool Put(Store store)
    {
      Store SelectedStore =Get(store.Name);

      SelectedStore = store;
      return _ctx.SaveChanges() == 1;
    }
  }
}
