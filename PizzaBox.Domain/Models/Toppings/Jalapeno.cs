using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models.Toppings
{
  public class Jalapeno : ATopping
  {
    public Jalapeno()
    {
      name = "Jalapeno";
      veget = true;
      vegan = true;
      price = 0.50;
    }
  }
}