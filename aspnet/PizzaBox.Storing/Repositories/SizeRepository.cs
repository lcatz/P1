using System.Collections.Generic;
using System.Linq;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storing.Repository
{
  public class SizeRepository
  {
    private  PizzaBoxContext _ctx;

    public SizeRepository(PizzaBoxContext context)
    {
      _ctx = context;
    }

    public List<Size> Get()
    {
      return _ctx.Size.ToList();
    }

    public Size Get(long id)
    {
      return _ctx.Size.SingleOrDefault(s => s.SizeID == id);
    }

    public bool Post(Size size)
    {
      _ctx.Size.Add(size);
      return _ctx.SaveChanges() == 1;
    }

    public bool Put(Size size)
    {
      Size SelectedSize =Get(size.SizeID);

      SelectedSize = size;
      return _ctx.SaveChanges() == 1;
    }
  }
}
