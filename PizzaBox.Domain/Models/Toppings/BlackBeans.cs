using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models.Toppings
{
  public class BlackBeans : ATopping
  {
    public BlackBeans()
    {
      name = "BlackBeans";
      veget = true;
      vegan = true;
      price = 0.50;
    }
  }
}