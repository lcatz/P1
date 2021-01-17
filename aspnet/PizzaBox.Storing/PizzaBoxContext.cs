using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storing
{
  public class PizzaBoxContext : DbContext
  {
    private readonly IConfiguration _configuration;

    public DbSet<Store> Stores { get; set; }

    public PizzaBoxContext(IConfiguration configuration)
    {
      _configuration = configuration;
    }


    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
      builder.UseSqlServer(_configuration.GetConnectionString("sqlserver"));
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Store>().HasKey(s => s.EntityID);
      builder.Entity<Store>().HasData(
        new Store() { EntityID = 1, Name = "Pizza Hut"},
        new Store() { EntityID = 2, Name = "Little Caesers"},
        new Store() { EntityID = 3, Name = "Dominoes"}
      );
    }
  }
}
