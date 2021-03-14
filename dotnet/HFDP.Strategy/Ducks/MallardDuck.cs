using HFDP.Strategy.Behaviors.Flying;
using HFDP.Strategy.Behaviors.Quacking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
