using HFDP.Composite.Menus;
using System;

namespace HFDP.Composite
{
    // The Composite Pattern allows you
    // to compose objects into tree structures to
    // represent part-whole hierarchies. Composite
    // lets clients treat individual objects and
    // compositions of objects uniformly.

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Objectville Diner & Pancake House");
            Console.WriteLine("---------------------------------");

            Console.WriteLine();

            MenuComponent pancakeHouseMenu = new Menu("PANCAKE HOUSE MENU", "Breakfast");
            MenuComponent dinerMenu = new Menu("DINER MENU", "Lunch");
            MenuComponent cafeMenu = new Menu("CAFE MENU", "Dinner");
            MenuComponent dessertMenu = new Menu("DESSERT MENU", "Dessert of course!");

            MenuComponent allMenus = new Menu("ALL MENUS", "All menus combined");
            allMenus.Add(pancakeHouseMenu);
            allMenus.Add(dinerMenu);
            allMenus.Add(cafeMenu);

            // Add menu items here

            dinerMenu.Add(
                new MenuItem(
                    "Pasta",
                    "Spaghetti with Marinara Sauce, and a slice of sourdough bread",
                    3.89,
                    true
                )
            );
            dinerMenu.Add(dessertMenu);

            dessertMenu.Add(
                new MenuItem(
                    "Apple pie",
                    "Apple pie with a flakey crust, topped with vanilla ice cream",
                    1.59,
                    true
                )
            );

            Waitress waitress = new Waitress(allMenus);
            waitress.PrintMenu();
        }
    }
}
