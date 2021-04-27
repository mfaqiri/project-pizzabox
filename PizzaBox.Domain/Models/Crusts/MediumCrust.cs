using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models.Crusts
{
  public class MediumCrust : ACrust
  {
    public MediumCrust()
    {
      name = "Medium";
      size = 10;
      price = 7.99;
      vegan = false;
      veget = false;
    }
  }
}