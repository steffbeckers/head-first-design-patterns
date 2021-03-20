using HFDP.Decorator.Beverages;
using HFDP.Decorator.Condiments;
using System;

namespace HFDP.Decorator
{
    // The Decorator Pattern attaches additional
    // responsibilities to an object dynamically.
    // Decorators provide a flexible alternative to
    // subclassing for extending functionality.

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starbuzz Coffee");
            Console.WriteLine("---------------");

            Console.WriteLine();

            Beverage beverage = new Espresso();
            Console.WriteLine($"{beverage.GetDescription()}: ${beverage.Cost()}");

            Beverage beverage2 = new DarkRoast();
            beverage2 = new Mocha(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);
            Console.WriteLine($"{beverage2.GetDescription()}: ${beverage2.Cost()}");

            Beverage beverage3 = new HouseBlend();
            beverage3 = new Soy(beverage3);
            beverage3 = new Mocha(beverage3);
            beverage3 = new Whip(beverage3);
            Console.WriteLine($"{beverage3.GetDescription()}: ${beverage3.Cost()}");
        }
    }
}
