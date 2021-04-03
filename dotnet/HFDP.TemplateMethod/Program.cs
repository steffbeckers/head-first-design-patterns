using HFDP.TemplateMethod.Beverages;
using System;

namespace HFDP.TemplateMethod
{
    // The Template Method Pattern defines the skeleton
    // of an algorithm in a method, deferring some steps to
    // subclasses. Template Method lets subclasses redefine
    // certain steps of an algorithm without changing the
    // algorithm's structure.

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starbuzz Recipes");
            Console.WriteLine("----------------");

            Console.WriteLine();

            Console.WriteLine("Coffee recipe");
            Coffee coffee = new Coffee();
            coffee.PrepareRecipe();

            Console.WriteLine();

            Console.WriteLine("Tea recipe");
            Tea tea = new Tea();
            tea.PrepareRecipe();

            Console.WriteLine();

            Console.WriteLine("Coffee with condiments question recipe");
            CoffeeWithHook coffeeWithHook = new CoffeeWithHook();
            coffeeWithHook.PrepareRecipe();
        }
    }
}
