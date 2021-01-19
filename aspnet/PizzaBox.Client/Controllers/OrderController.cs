using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;
using PizzaBox.Domain.Models;
using PizzaBox.Storing.Repository;

namespace PizzaBox.Client.Controllers
{
  public class OrderController : Controller
  {
    private PizzaRepository _PizzaRepo = new PizzaRepository();

    private OrderRepository _OrderRepo = new OrderRepository();

    private UserRepository _UserRepo = new UserRepository();
    [HttpGet]
    public IActionResult Get()
    {
      return View();
    }
    [HttpGet]
    public IActionResult Checkout()
    {
      return View(new OrderViewModel());
    }
    [HttpPost]
    public IActionResult Checkout(OrderViewModel OrderViewModel)
    {
      Order order = new Order();
      order.UserName = TempData["user"].ToString();
      TempData.Keep("user");
      order.StoreName = OrderViewModel.Store;
      _OrderRepo.Post(order);
      foreach(var item in OrderViewModel.Pizzas)
      {
        item.Order = order;
        item.HasOrder = true;
        _PizzaRepo.Put(item);
      }
      return View("UserMenu");
    }
    [HttpGet]
    public IActionResult UserHistory()
    {
      User user = _UserRepo.Get(TempData["user"].ToString());
      TempData.Keep("user");
      UserHistoryViewModel userhistoryviewmodel = new UserHistoryViewModel();
      userhistoryviewmodel.Orders.RemoveAll(item => item.UserName != user.Name);
      return View(userhistoryviewmodel);
    }

    public IActionResult menu()
    {
      return View("UserMenu");
    }
  }
}
