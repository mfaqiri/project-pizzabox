using System;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models.Sauces;
using PizzaBox.Domain.Models.Toppings;

namespace PizzaBox.Domain.Models.Pizzas
{
  public class MeatloversPizza : APizza
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
    public MeatloversPizza()
    {
        name = "Meat Lover's Pizza";
        addSauce(new Marinara());
        addTopping(new ATopping[3]{new Sausage(), new GrilledChicken(), new Pepporoni()});


    }
  }
}