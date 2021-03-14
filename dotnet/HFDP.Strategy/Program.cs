using HFDP.Strategy.Behaviors.Flying;
using HFDP.Strategy.Ducks;
using System;

namespace HFDP.Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Duck Simulator");
            Console.WriteLine("--------------");

            Console.WriteLine();

            Duck mallardDuck = new MallardDuck();
            mallardDuck.Display();
            mallardDuck.Quack();
            mallardDuck.Fly();
            mallardDuck.Swim();

            Console.WriteLine();

            Duck rubberDuck = new RubberDuck();
            rubberDuck.Display();
            rubberDuck.Quack();
            rubberDuck.Fly();
            rubberDuck.Swim();

            Console.WriteLine();

            Duck modelDuck = new ModelDuck();
            modelDuck.Display();
            modelDuck.Quack();
            modelDuck.Fly();
            modelDuck.SetFlyBehavior(new FlyRocketPowered());
            modelDuck.Fly();
            modelDuck.Swim();
        }
    }
}
