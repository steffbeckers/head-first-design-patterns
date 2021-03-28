using HFDP.Adapter.Ducks;
using HFDP.Adapter.Turkeys;
using System;

namespace HFDP.Adapter
{
    // The Adapter Pattern converts the interface of a class
    // into another interface the clients expect. Adapter lets
    // classes work together that couldn't otherwise because of
    // incompatible interfaces.

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Duck & Turkey Simulator");
            Console.WriteLine("-----------------------");

            Console.WriteLine();

            MallardDuck duck = new MallardDuck();
            WildTurkey turkey = new WildTurkey();
            TurkeyAdapter turkeyAdapter = new TurkeyAdapter(turkey);

            Console.WriteLine("The Turkey says...");
            turkey.Gobble();
            turkey.Fly();

            Console.WriteLine();

            Console.WriteLine("The Duck says...");
            TestDuck(duck);

            Console.WriteLine();

            Console.WriteLine("The TurkeyAdapter says...");
            TestDuck(turkeyAdapter);
        }

        private static void TestDuck(IDuck duck)
        {
            duck.Quack();
            duck.Fly();
        }
    }
}
