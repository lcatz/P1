using System.Collections.Generic;
using System.Linq;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storing.Repository
{
  public class CrustRepository
  {
    private  PizzaBoxContext _ctx;

    public CrustRepository(PizzaBoxContext context)
    {
      _ctx = context;
    }

    public List<Crust> Get()
    {
      return _ctx.Crust.ToList();
    }

    public Crust Get(long id)
    {
      return _ctx.Crust.SingleOrDefault(c => c.CrustID == id);
    }

    public bool Post(Crust crust)
    {
      _ctx.Crust.Add(crust);
      return _ctx.SaveChanges() == 1;
    }

    public bool Put(Crust crust)
    {
      Crust SelectedCrust =Get (crust.CrustID);

      SelectedCrust = crust;
      return _ctx.SaveChanges() == 1;
    }
  }
}
