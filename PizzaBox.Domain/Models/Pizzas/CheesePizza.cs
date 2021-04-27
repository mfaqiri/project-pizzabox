using System;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models.Toppings;

namespace PizzaBox.Domain.Models.Pizzas
{
  public class CheesePizza : APizza
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
        foreach(var topping in toppings)
        {
            if(topping == null)
              break;
            Toppings.Add(topping);
            topping.pizza = this;
            price += topping.price;
        }

        price = Math.Round(price, 2);
    }

    public CheesePizza()
    {

        name = "Cheese Pizza";
        addTopping(new ATopping[]{new Mozzerella()});

    }
  }
}