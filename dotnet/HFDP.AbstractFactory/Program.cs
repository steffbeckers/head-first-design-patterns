using HFDP.AbstractFactory.Pizzas;
using HFDP.AbstractFactory.Stores;
using System;

namespace HFDP.AbstractFactory
{
    // The Abstract Factory Pattern provides an interface
    // for creating families of related or dependent objects
    // without specifying their concrete classes.

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pizza Store");
            Console.WriteLine("-----------");

            Console.WriteLine();

            PizzaStore nyStore = new NYStylePizzaStore();
            PizzaStore chicagoStore = new ChicagoStylePizzaStore();

            Pizza pizza = nyStore.OrderPizza("cheese");
            Console.WriteLine($"Ethan ordered a {pizza.Name}");

            Console.WriteLine();

            pizza = chicagoStore.OrderPizza("clam");
            Console.WriteLine($"Joel ordered a {pizza.Name}");
        }
    }
}
