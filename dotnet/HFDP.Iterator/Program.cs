using HFDP.Iterator.Menus;
using System;

namespace HFDP.Iterator
{
    // The Iterator Pattern provides a way to
    // access the elements of an aggregate object
    // sequentially without exposing its underlaying
    // representation.

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Objectville Diner & Pancake House");
            Console.WriteLine("---------------------------------");

            Console.WriteLine();

            PancakeHouseMenu pancakeHouseMenu = new PancakeHouseMenu();
            DinerMenu dinerMenu = new DinerMenu();

            Waitress waitress = new Waitress(pancakeHouseMenu, dinerMenu);

            waitress.PrintMenu();
        }
    }
}
