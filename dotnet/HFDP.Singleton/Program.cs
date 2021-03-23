using System;

namespace HFDP.Singleton
{
    // The Singleton Pattern ensures a class has only one
    // instance, and provides a global point of access to it.

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chocolate Factory");
            Console.WriteLine("-----------------");

            Console.WriteLine();

            ChocolateBoiler chocolateBoiler = ChocolateBoiler.GetInstance();
            chocolateBoiler.Fill();
            chocolateBoiler.Boil();
            chocolateBoiler.Drain();
        }
    }
}
