using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models.Toppings
{
  public class Mozzerella : ATopping
  {
    public Mozzerella()
    {
      name = "Mozzerella";
      veget = true;
      vegan = false;
      price = 0.50;
    }
  }
}