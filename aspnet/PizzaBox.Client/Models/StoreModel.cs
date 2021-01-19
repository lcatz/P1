using System.Collections.Generic;
using PizzaBox.Domain.Models;
using PizzaBox.Storing.Repository;

namespace PizzaBox.Client.Models
{
  public class StoreModel
  {
    private PizzaRepository _PizzaRepo = new PizzaRepository();

    private OrderRepository _OrderRepo = new OrderRepository();

    public List<Order> Orders { get; set; }

    public List<Pizza> Pizzas { get; set; }

    public decimal Sales { get; set; }

    public StoreModel()
    {
      Orders = _OrderRepo.Get();
      Pizzas = _PizzaRepo.Get();
    }
  }
}
