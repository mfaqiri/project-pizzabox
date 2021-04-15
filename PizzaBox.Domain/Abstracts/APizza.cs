
using System.Collections.Generic;

namespace PizzaBox.Domain.Abstracts
{
    public abstract class APizza
    {
        public uint pizzaType{get; protected set;}
        public uint price{get; protected set;}
        private uint _toppingLimit = 5;
        public List<uint> sizes;

        public enum toppings
        {
            spinach,
            mushroom,
            pepperoni,
            sausage,
            jalapeno,
            parmesan,
            basil,
            tomato,
            onion,
            pineapple
        }

        public enum crust
        {
            small,
            medium,
            large,
            xlarge
        }

        public enum sauce
        {
            tomato,
            bbq,
            alfredo
        }

    }
}