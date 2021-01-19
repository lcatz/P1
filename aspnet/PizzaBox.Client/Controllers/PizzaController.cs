using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;
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
  }
}
