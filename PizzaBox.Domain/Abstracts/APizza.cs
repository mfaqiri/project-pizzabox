
using System.Collections.Generic;
using PizzaBox.Domain.Models.Orders;

namespace PizzaBox.Domain.Abstracts
{

    public abstract class APizza : AModels
    {
        public Order order{get;set;}
        public ACrust Crust{get;set;}
        public ASauce Sauce{get;set;}
        public string name{get;protected set;}
        public List<ATopping> Toppings = new List<ATopping>();

        public uint pizzaType{get; protected set;}
        public double price{get; protected set;}        
        private const uint _toppingLimit = 5;
      
        protected List<AIngrediant> ingrediants;

        public abstract void addCrust(ACrust crust = null);

        public abstract void addSauce(ASauce sauce = null);

        public abstract void addTopping(params ATopping[] toppings);



    }
}