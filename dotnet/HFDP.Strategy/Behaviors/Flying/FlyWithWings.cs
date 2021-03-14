using System;

namespace HFDP.Strategy.Behaviors.Flying
{
    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying");
        }
    }
}
