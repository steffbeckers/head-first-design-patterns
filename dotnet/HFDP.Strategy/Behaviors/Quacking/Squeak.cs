﻿using System;

namespace HFDP.Strategy.Behaviors.Quacking
{
    public class Squeak : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Squeak");
        }
    }
}
