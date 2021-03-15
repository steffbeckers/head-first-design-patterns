using HFDP.Strategy.Behaviors.Flying;
using HFDP.Strategy.Behaviors.Quacking;
using System;

namespace HFDP.Strategy.Ducks
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            _flyBehavior = new FlyNoWay();
            _quackBehavior = new Quack();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a model duck");
        }
    }
}
