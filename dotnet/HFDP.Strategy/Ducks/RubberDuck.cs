using HFDP.Strategy.Behaviors.Flying;
using HFDP.Strategy.Behaviors.Quacking;
using System;

namespace HFDP.Strategy.Ducks
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            _flyBehavior = new FlyNoWay();
            _quackBehavior = new Squeak();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a rubber duck");
        }
    }
}