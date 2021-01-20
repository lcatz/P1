using System.Collections.Generic;
using PizzaBox.Domain.Models;
using PizzaBox.Storing.Repository;

namespace PizzaBox.Client.Models
{
  public class PizzaViewModel
  {
    private CrustRepository _CrustRepo = new CrustRepository();

    private SizeRepository _SizeRepo = new SizeRepository();

    private ToppingRepository _ToppingRepo = new ToppingRepository();

    public List<Crust> CrustList { get; set; }
    public List<Size> SizeList { get; set; }

    public List<Topping> ToppingList { get; set; }

    public string Crust { get; set; }

    public string Size { get; set; }

    public int Count { get; set; }

    public string[] Toppings { get; private set;}

    public bool Topping1 { get; set; }

    public bool Topping2 { get; set; }

    public bool Topping3 { get; set; }

    public bool Topping4 { get; set; }

    public bool Topping5 { get; set; }

    public bool Topping6 { get; set; }


    public PizzaViewModel()
    {
      CrustList = _CrustRepo.Get();
      SizeList = _SizeRepo.Get();
      ToppingList = _ToppingRepo.Get();
      Toppings = new string[ToppingList.Count];

      Count = ToppingList.Count;
      int count = 0;
      foreach(var item in ToppingList)
      {
        Toppings[count] = item.Name;

        count++;
      }

    }
  }
}
