using System;

namespace HFDP.Strategy.Behaviors.Flying
{
    public class FlyRocketPowered : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying with a rocket");
        }
    }
}