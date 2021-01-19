using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;
using PizzaBox.Domain.Models;
using PizzaBox.Storing.Repository;

namespace PizzaBox.Client.Controllers
{
  public class StoreController : Controller
  {
    private StoreRepository _StoreRepo = new StoreRepository();
    [HttpGet]
    public IActionResult StoreHistory()
    {
      Store store = _StoreRepo.Get(TempData["store"].ToString());
      TempData.Keep("store");
      StoreModel storemodel = new StoreModel();
      storemodel.Orders.RemoveAll(item => item.StoreName != store.Name);
      return View(storemodel);
    }
    [HttpGet]
    public IActionResult StoreSales()
    {
      Store store = _StoreRepo.Get(TempData["store"].ToString());
      TempData.Keep("store");
      StoreModel storemodel = new StoreModel();
      storemodel.Orders.RemoveAll(item => item.StoreName != store.Name);
      foreach(var item in storemodel.Orders)
      {
        foreach(var i in storemodel.Pizzas)
        {
          if(i.Order ==item)
          {
            storemodel.Sales += i.Price;
          }
        }
      }
      return View(storemodel);
    }

    public IActionResult menu()
    {
      return View("StoreMenu");
    }
  }
}
