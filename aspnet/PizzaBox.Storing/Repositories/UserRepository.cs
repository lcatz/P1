using System.Collections.Generic;
using System.Linq;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storing.Repository
{
  public class UserRepository
  {
    private static readonly PizzaBoxContext _ctx = PizzaBoxContext.Instance;

    public List<User> Get()
    {
      return _ctx.User.ToList();
    }

    public User Get(string name)
    {
      return _ctx.User.SingleOrDefault(u => u.Name == name);
    }

    public bool Post(User user)
    {
      _ctx.User.Add(user);
      return _ctx.SaveChanges() == 1;
    }

    public bool Put(User user)
    {
      User SelectedUser = Get(user.Name);

      SelectedUser = user;
      return _ctx.SaveChanges() == 1;
    }
  }
}
