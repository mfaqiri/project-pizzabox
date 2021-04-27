using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models.Toppings
{
  public class Chedder : ATopping
  {
    public Chedder()
    {
      name = "Chedder";
      veget = true;
      vegan = false;
      price = 0.50;
    }
  }
}