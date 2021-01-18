namespace PizzaBox.Storing.Repository
{
  public class OrderRepository
  {
    private  PizzaBoxContext _ctx;

    public OrderRepository(PizzaBoxContext context)
    {
      _ctx = context;
    }

    
  }
}
