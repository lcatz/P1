using System.Collections.Generic;
using PizzaBox.Domain.Models;
using PizzaBox.Storing.Repository;

namespace PizzaBox.Client.Models
{
  public class OrderViewModel
  {
    private PizzaRepository _PizzaRepo = new PizzaRepository();

    private StoreRepository _StoreRepo = new StoreRepository();

    public List<Pizza> Pizzas { get; set; }

    public List<Store> Stores { get; set; }

    public string Store { get; set; }

    public OrderViewModel()
    {
      Stores = _StoreRepo.Get();
      List<Pizza> Temp = _PizzaRepo.Get();
      Pizzas = new List<Pizza>();
      foreach(var pizza in Temp)
      {
        if(pizza.HasOrder == false)
        {
          Pizzas.Add(pizza);
        }
      }
    }
  }
}
