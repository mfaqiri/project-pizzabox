
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models.Crusts
{
  public class LargeCrust : ACrust
  {
    public LargeCrust()
    {
      name = "Large";
      size = 14;
      price = 9.99;
      vegan = false;
      veget = false;
    }
  }
}