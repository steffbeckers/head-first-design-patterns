using System;
using System.Collections.Generic;

namespace HFDP.FactoryMethod.Pizzas
{
    public abstract class Pizza
    {
        public string Name { get; set; }
        public string Dough { get; set; }
        public string Sauce { get; set; }
        public List<string> Toppings = new List<string>();

        public void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
            Console.WriteLine($"Tossing dough...");
            Console.WriteLine($"Adding sauce...");
            Console.WriteLine($"Adding toppings:");
            foreach (string topping in Toppings)
            {
                Console.WriteLine($"\t{topping}");
            }
        }

        public virtual void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 180");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        public virtual void Box()
        {
            Console.WriteLine("Place pizza in official Pizza Store box");
        }
    }
}
