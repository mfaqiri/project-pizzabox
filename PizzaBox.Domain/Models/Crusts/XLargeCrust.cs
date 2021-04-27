using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models.Crusts
{
  public class XLargeCrust : ACrust
  {
    public XLargeCrust()
    {
      name = "XLarge";
      size = 18;
      price = 11.99;
      vegan = false;
      veget = false;
    }
  }
}