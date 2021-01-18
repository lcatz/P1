using System;

namespace PizzaBox.Domain.Abstracts
{
  public abstract class AModel
  {
    public long EntityID { get; set; }

    protected AModel()
    {
      EntityID = DateTime.Now.Ticks;
    }
  }
}
