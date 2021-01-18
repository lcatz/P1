using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storing
{
  public class PizzaBoxContext : DbContext
  {

    public DbSet<Store> Stores { get; set; }

    public DbSet<Order> Orders { get; set; }

    // public DbSet<Size> Size { get; set; }

    // public DbSet<PizzaBox> Pizza { get; set; }

    // public DbSet<User> User { get; set; }

    // public DbSet<Topping> Topping { get; set; }

    public PizzaBoxContext(DbContextOptions<PizzaBoxContext> options) : base(options) {}
    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Order>().HasKey(o => o.EntityID);
      builder.Entity<Store>().HasKey(s => s.EntityID);
      builder.Entity<Store>().HasData(
        new Store() { EntityID = 1, Name = "Pizza Hut"},
        new Store() { EntityID = 2, Name = "Little Caesers"},
        new Store() { EntityID = 3, Name = "Dominoes"}
      );

    }
  }
}
