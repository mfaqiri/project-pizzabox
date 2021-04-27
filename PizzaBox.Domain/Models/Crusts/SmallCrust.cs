using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models.Crusts
{
  public class SmallCrust : ACrust
  {
    public SmallCrust()
    {
      name = "Small";
      size = 8;
      price = 5.99;
      vegan = false;
      veget = false;
    }
  }
}