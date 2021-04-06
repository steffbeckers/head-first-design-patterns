using System;

namespace HFDP.State
{
    // The State Pattern allows an object to alter its behavior
    // when its internal state changes. The object will appear to
    // change its class.

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gumball Machine");
            Console.WriteLine("---------------");

            Console.WriteLine();

            GumballMachine gumballMachine = new GumballMachine(5);
            Console.WriteLine(gumballMachine);

            Console.WriteLine();

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();

            Console.WriteLine();
            Console.WriteLine(gumballMachine);
            Console.WriteLine();

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();

            Console.WriteLine();
            Console.WriteLine(gumballMachine);
            Console.WriteLine();

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();

            Console.WriteLine();
            Console.WriteLine(gumballMachine);
            Console.WriteLine();

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();

            Console.WriteLine();
            Console.WriteLine(gumballMachine);
            Console.WriteLine();

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();

            Console.WriteLine();
            Console.WriteLine(gumballMachine);
            Console.WriteLine();

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();

            Console.WriteLine();
            Console.WriteLine(gumballMachine);
            Console.WriteLine();

            if (gumballMachine.State == gumballMachine.SoldOutState)
            {
                gumballMachine.Refill(20);
                Console.WriteLine();
            }

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();

            Console.WriteLine();
            Console.WriteLine(gumballMachine);
        }
    }
}
