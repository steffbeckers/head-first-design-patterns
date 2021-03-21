using HFDP.FactoryMethod.Pizzas;
using HFDP.FactoryMethod.Stores;
using System;

namespace HFDP.FactoryMethod
{
    // The Factory Method Pattern defines an interface
    // for creating an object, but lets subclasses decide which
    // class to instantiate. Factory Method lets a class defer
    // instantiation to subclasses.

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

            pizza = chicagoStore.OrderPizza("cheese");
            Console.WriteLine($"Joel ordered a {pizza.Name}");
        }
    }
}
