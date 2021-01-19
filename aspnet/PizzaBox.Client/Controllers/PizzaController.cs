using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;
using PizzaBox.Domain.Models;
using PizzaBox.Storing.Repository;

namespace PizzaBox.Client.Controllers
{
  public class PizzaController : Controller
  {
    private PizzaRepository _PizzaRepo = new PizzaRepository();

    private CrustRepository _CrustRepo = new CrustRepository();

    private SizeRepository _SizeRepo = new SizeRepository();

    private ToppingRepository _ToppingRepo = new ToppingRepository();
    [HttpGet]
    public IActionResult Get()
    {
      return View();
    }

    public IActionResult Create()
    {
      return View(new PizzaViewModel());
    }
    [HttpPost]
    public IActionResult Create(PizzaViewModel pizzaviewmodel)
    {
      Pizza pizza = new Pizza();
      pizza.HasOrder = false;
      List<Crust> CrustList = _CrustRepo.Get();
      List<Size> SizeList = _SizeRepo.Get();
      foreach(var item in CrustList)
      {
        if(item.Name == pizzaviewmodel.Crust)
        {
          pizza.Crust = item;
          pizza.Name = item.Name + " ";
          pizza.Price += item.Price;
        }
      }
      foreach(var item in SizeList)
      {
        if(item.Name == pizzaviewmodel.Size)
        {
          pizza.Size = item;
          pizza.Name += item.Name + " ";
          pizza.Price += item.Price;
        }
      }
      for (int i = 0; i < pizzaviewmodel.Count; i++)
      {
        if(i == 0)
        {
          if(!pizzaviewmodel.Topping1)
          {
            pizzaviewmodel.ToppingList.Remove(_ToppingRepo.Get(pizzaviewmodel.Toppings[i]));
          }
        }
        else if(i == 1)
        {
          if(!pizzaviewmodel.Topping2)
          {
            pizzaviewmodel.ToppingList.Remove(_ToppingRepo.Get(pizzaviewmodel.Toppings[i]));
          }
        }
        else
        {
          if(!pizzaviewmodel.Topping3)
          {
            pizzaviewmodel.ToppingList.Remove(_ToppingRepo.Get(pizzaviewmodel.Toppings[i]));
          }
        }
      }
      List<PizzaTopping> PizzaToppingList = new List<PizzaTopping>();
      foreach (var item in pizzaviewmodel.ToppingList)
      {
        pizza.Price += item.Price;
        pizza.Name += item.Name + " ";
        PizzaToppingList.Add(new PizzaTopping(){Topping = item});
      }
      pizza.PizzaToppings = PizzaToppingList;
      _PizzaRepo.Post(pizza);
      return View("PizzaOrdered");

    }
  }
}
