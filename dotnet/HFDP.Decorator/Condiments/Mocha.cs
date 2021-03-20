﻿using HFDP.Decorator.Beverages;

namespace HFDP.Decorator.Condiments
{
    public class Mocha : CondimentDecorator
    {
        private readonly Beverage _beverage;

        public Mocha(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription() + ", Mocha";
        }

        public override double Cost()
        {
            return _beverage.Cost() + 0.20;
        }
    }
}
