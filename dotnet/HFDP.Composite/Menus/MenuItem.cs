using System;

namespace HFDP.Composite.Menus
{
    public class MenuItem : MenuComponent
    {
        public readonly string Name;
        public readonly string Description;
        public readonly double Price;
        public readonly bool Vegetarian;

        public MenuItem(string name, string description, double price, bool vegetarian)
        {
            Name = name;
            Description = description;
            Price = price;
            Vegetarian = vegetarian;
        }

        public bool IsVegetarian()
        {
            return Vegetarian;
        }

        public override void Print()
        {
            Console.Write($"   {Name}");
            if (IsVegetarian())
            {
                Console.Write(" (v)");
            }
            Console.WriteLine($", {Price}");
            Console.WriteLine($"      -- {Description}");
        }
    }
}