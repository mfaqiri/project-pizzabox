using System;
using System.Collections.Generic;
using PizzaBox.Domain.Models.Orders;

namespace PizzaBox.Domain.Abstracts
{
    public abstract class AStore : AModels
    {
        
        public string name{get; set;}
        public List<Order> orders = new List<Order>();
        //public string country{get; protected set;}
        //public string address{get; protected set;}

        public bool newOrder(Customer customer, Order order)
        {
           bool timeLimit = true;
            foreach(Order parse in customer.orders)
            {
                TimeSpan delta = DateTime.Now - parse.time;
                if(delta < new TimeSpan(2,0,0))
                {
                    timeLimit = false;
                }
            }
            if(timeLimit){
            order.store = this;
            order.price = 0.0;
            orders.Add(order);
            order.customer = customer;
            customer.orders.Add(order);
           }
           return timeLimit;
        }

        public void cancelOrder(Order order)
        {
            order.customer.orders.Remove(order);
        }

        public bool addPizza(Order order, APizza pizza)
        {
            order.pizzas.Add(pizza);
            order.price += pizza.price;
            if(order.price > 250)
            {
                removePizza(order, pizza);
                Console.WriteLine("Can't have an order over $250");
                return false;
            }

            order.price = Math.Round(order.price, 2);
            return true;
        }

        public void removePizza(Order order, APizza pizza)
        {
            order.pizzas.Remove(pizza);
            order.price -= pizza.price;
        }

    }
}