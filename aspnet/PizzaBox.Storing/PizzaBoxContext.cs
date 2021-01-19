using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storing
{
  public class PizzaBoxContext : DbContext
  {

    public DbSet<Store> Store { get; set; }

    public DbSet<Order> Order { get; set; }

    public DbSet<Pizza> Pizza { get; set; }

    public DbSet<Crust> Crust { get; set; }

    public DbSet<User> User { get; set; }

    public DbSet<Topping> Topping { get; set; }

    public DbSet<Size> Size { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
      builder.UseSqlServer("Server=tcp:projectp1server.database.windows.net,1433;Initial Catalog=lcatproject1db;Persist Security Info=False;User ID=sysadmin;Password=Abcd1234;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
    }

    private static readonly PizzaBoxContext _connection = new PizzaBoxContext();

    public PizzaBoxContext() {}

    public static PizzaBoxContext Instance
    {
      get{
        return _connection;
      }
    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Order>().HasKey(o => o.OrderID);
      builder.Entity<Store>().HasKey(s => s.StoreID);
      builder.Entity<User>().HasKey(u => u.UserID);
      builder.Entity<Crust>().HasKey(c => c.CrustID);
      builder.Entity<Pizza>().HasKey(p => p.PizzaID);
      builder.Entity<Size>().HasKey(s => s.SizeID);
      builder.Entity<Topping>().HasKey(t => t.ToppingID);
      builder.Entity<PizzaTopping>().HasKey(pt => new { pt.PizzaID, pt.ToppingID});

      builder.Entity<Order>().HasMany(o => o.Pizzas).WithOne(p => p.Order);
      builder.Entity<Store>().HasMany(s => s.Orders).WithOne(o => o.Store);
      builder.Entity<User>().HasMany(u => u.Orders).WithOne(o => o.User);
      builder.Entity<Pizza>().HasMany(p => p.PizzaToppings).WithOne(pt => pt.Pizza).HasForeignKey(pt => pt.PizzaID);
      builder.Entity<Crust>().HasMany(c => c.Pizzas).WithOne(p => p.Crust);
      builder.Entity<Size>().HasMany(s => s.Pizzas).WithOne(p => p.Size);
      builder.Entity<Topping>().HasMany(t => t.PizzaToppings).WithOne(pt => pt.Topping).HasForeignKey(pt => pt.ToppingID);

      builder.Entity<Store>().HasData(
        new Store() { StoreID = 1, Name = "Pizza Hut"},
        new Store() { StoreID = 2, Name = "Little Caesers"},
        new Store() { StoreID = 3, Name = "Dominoes"}
      );

      builder.Entity<Topping>().HasData(
        new Topping() {Name = "Cheese", Price = 0.99M},
        new Topping() {Name = "Pineapple", Price = 1.50M},
        new Topping() {Name = "Ham", Price = 1.99M},
        new Topping() {Name = "Pepperoni", Price = 1.99M},
        new Topping() {Name = "Sausage", Price = 1.99M},
        new Topping() {Name = "Sauce", Price = 1.99M}
      );

      builder.Entity<Crust>().HasData(
        new Crust() {Name = "Thin", Price = 2.00M},
        new Crust() {Name = "Thick", Price = 3.00M},
        new Crust() {Name = "Cheese-Stuffed", Price = 4.00M}
      );

      builder.Entity<Size>().HasData(
        new Size() {Name = "Medium", Price = 12.00M},
        new Size() {Name = "Large", Price = 15.00M},
        new Size() {Name = "X-Large", Price = 18.00M}
      );

      builder.Entity<User>().HasData(
        new User() {UserID = 1, Name = "Lawrence"}
      );

    }
  }
}
