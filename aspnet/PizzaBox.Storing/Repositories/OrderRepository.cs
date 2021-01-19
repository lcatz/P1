using System.Collections.Generic;
using System.Linq;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storing.Repository
{
  public class OrderRepository
  {
    private static readonly PizzaBoxContext _ctx = PizzaBoxContext.Instance;

    public List<Order> Get()
    {
      return _ctx.Order.ToList();
    }

    public Order Get(long id)
    {
      return _ctx.Order.SingleOrDefault(o => o.OrderID == id);
    }

    public bool Post (Order order)
    {
      _ctx.Order.Add(order);
      return _ctx.SaveChanges() == 1;
    }

    public bool Put (Order order)
    {
      Order SelectedOrder = Get(order.OrderID);
      SelectedOrder = order;
      return _ctx.SaveChanges() == 1;
    }

  }
}
