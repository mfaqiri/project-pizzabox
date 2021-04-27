using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models.Toppings
{
  public class Pepporoni : ATopping
  {
    public Pepporoni()
    {
      name = "Pepporoni";
      veget = false;
      vegan = false;
      price = 0.99;
    }
  }
}