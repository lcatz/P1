using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;
using PizzaBox.Domain.Models;
using PizzaBox.Storing.Repository;

namespace PizzaBox.Client.Controllers
{
  public class HomeController : Controller
  {
    private UserRepository _UserRepo = new UserRepository();

    private StoreRepository _StoreRepo = new StoreRepository();

    public IActionResult Index()
    {
      return View();
    }

    [HttpPost]
    public IActionResult Login()
    {
      return View();
    }
    [HttpPost]
    public IActionResult Login(UserViewModel userviewmodel)
    {
      bool IsUser = false;
      bool IsStore = false;

      List<User> UserList = _UserRepo.Get();
      List<Store> StoreList = _StoreRepo.Get();

      foreach(var user in UserList)
      {
        if(userviewmodel.Name == user.Name)
        {
          IsUser = true;
          TempData["user"] = user.Name;
        }
      }

      foreach(var store in StoreList)
      {
        if(userviewmodel.Name == store.Name)
        {
          IsStore = true;
          TempData["store"] = store.Name;
        }
      }

      if(IsUser)
      {
        return View("UserMenu");
      }
      else if(IsStore)
      {
        return View("StoreMenu");
      }
      else
      {
        return View("FailedLogin");
      }
    }
  }
}
