using Microsoft.Extensions.Configuration;

namespace PizzaBox.Client.Models
{
  public class CustomerViewModel
  {
    public string Name { get; set; }

    public OrderViewModel Order { get; set; }

    public CustomerViewModel(IConfiguration configuration)
    {
      Name = "Lawrence";
      Order = new OrderViewModel(configuration);
    }
  }
}
