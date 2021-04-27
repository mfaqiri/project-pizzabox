using System;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models.Pizzas
{
  public class CustomPizza : APizza
  {
      public override void addCrust(ACrust crust)
      {
        Crust = crust;
        price += crust.price;
        price = Math.Round(price, 2);
      }

    public override void addSauce(ASauce sauce)
    {
      Sauce = sauce;
      price += sauce.price;
      price = Math.Round(price, 2);
    }

    public override void addTopping(params ATopping[] toppings)
    {
      foreach(ATopping topping in toppings)
      {
        if(topping == null)
          break;
        Toppings.Add(topping);
        topping.pizza = this;
        price += topping.price;
      }
      price = Math.Round(price, 2);
    }

    public CustomPizza()
    {
      name = "Custom Pizza";

    }
  }
}