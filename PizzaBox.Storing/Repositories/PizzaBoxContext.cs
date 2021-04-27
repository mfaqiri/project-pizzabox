using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models.Orders;
using PizzaBox.Domain.Models.Stores;
using PizzaBox.Domain.Models.Pizzas;
using PizzaBox.Domain.Models.Sauces;
using PizzaBox.Domain.Models.Crusts;
using PizzaBox.Domain.Models.Toppings;

namespace PizzaBox.Storing
{
  public class PizzaBoxContext : DbContext
  {
    public DbSet<AStore> Stores {get; set;}
    public DbSet<APizza> Pizzas {get; set;}
    public DbSet<ACrust> Crusts {get;set;}
    public DbSet<ASauce> Sauces {get;set;}
    public DbSet<Customer> Customers {get;set;}
    public DbSet<ATopping> Toppings {get;set;}
    public DbSet<Order> orders {get;set;}

    private readonly IConfiguration _configuration;
    public PizzaBoxContext()
    {
      _configuration = new ConfigurationBuilder().AddUserSecrets<PizzaBoxContext>().Build();
    }


    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
      builder.UseSqlServer(_configuration["mssql"]);
    }
  
    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<AStore>().HasKey(e => e.EntityId);
      builder.Entity<ChicagoStore>().HasBaseType<AStore>();
      builder.Entity<NewYorkStore>().HasBaseType<AStore>();

      builder.Entity<APizza>().HasKey(e => e.EntityId);
      builder.Entity<CustomPizza>().HasBaseType<APizza>();
      builder.Entity<MeatloversPizza>().HasBaseType<APizza>();
      builder.Entity<CheesePizza>().HasBaseType<APizza>();

      builder.Entity<ASauce>().HasKey(e => e.EntityId);
      builder.Entity<Alfredo>().HasBaseType<ASauce>();
      builder.Entity<Marinara>().HasBaseType<ASauce>();
      builder.Entity<Bbq>().HasBaseType<ASauce>();

      builder.Entity<ACrust>().HasKey(e => e.EntityId);
      builder.Entity<MediumCrust>().HasBaseType<ACrust>();
      builder.Entity<LargeCrust>().HasBaseType<ACrust>();
      builder.Entity<SmallCrust>().HasBaseType<ACrust>();
      builder.Entity<XLargeCrust>().HasBaseType<ACrust>();
      builder.Entity<Order>().HasKey(e => e.EntityId);
      builder.Entity<ATopping>().HasKey(e => e.EntityId);
      builder.Entity<Jalapeno>().HasBaseType<ATopping>();
      builder.Entity<Sausage>().HasBaseType<ATopping>();
      builder.Entity<Pepporoni>().HasBaseType<ATopping>();
      builder.Entity<BlackBeans>().HasBaseType<ATopping>();
      builder.Entity<Chedder>().HasBaseType<ATopping>();
      builder.Entity<Mozzerella>().HasBaseType<ATopping>();
      builder.Entity<Parmesan>().HasBaseType<ATopping>();
      builder.Entity<FriedEgg>().HasBaseType<ATopping>();
      builder.Entity<GrilledChicken>().HasBaseType<ATopping>();
      builder.Entity<Pineapple>().HasBaseType<ATopping>();
      builder.Entity<Spinach>().HasBaseType<ATopping>();
      builder.Entity<Tomato>().HasBaseType<ATopping>();









      builder.Entity<Customer>().HasKey(e => e.EntityId);

      // builder.Entity<Size>().HasMany<APizza>().WithOne(); // orm is creating the has
      // builder.Entity<APizza>().HasOne<Size>().WithMany();

      builder.Entity<AStore>().HasMany<Order>(s => s.orders).WithOne(o => o.store);
      builder.Entity<Customer>().HasMany<Order>(c => c.orders).WithOne(o => o.customer);
      builder.Entity<Order>().HasMany<APizza>(o => o.pizzas).WithOne(p => p.order);
      builder.Entity<APizza>().HasMany<ATopping>(p => p.Toppings).WithOne(t => t.pizza);


      /*builder.Entity<ChicagoStore>().HasData(new ChicagoStore[]
      {
        new ChicagoStore() { EntityId = 1, name = "Chitown Main Street" }
      });

      builder.Entity<NewYorkStore>().HasData(new NewYorkStore[]
      {
        new NewYorkStore() { EntityId = 2, name = "Big Apple" }
      });

      builder.Entity<Customer>().HasData(new Customer[]
      {
        new Customer() { EntityId = 1, name = "Uncle John" }
      });*/


    }
  }
}