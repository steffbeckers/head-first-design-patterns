using HFDP.Strategy.Behaviors.Flying;
using HFDP.Strategy.Behaviors.Quacking;
using System;

namespace HFDP.Strategy.Ducks
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            _flyBehavior = new FlyWithWings();
            _quackBehavior = new Quack();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a real Mallard duck");
        }
    }
}
