using HFDP.Decorator.Beverages;

namespace HFDP.Decorator.Condiments
{
    public class Whip : CondimentDecorator
    {
        private readonly Beverage _beverage;

        public Whip(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription() + ", Whip";
        }

        public override double Cost()
        {
            return _beverage.Cost() + 0.10;
        }
    }
}
