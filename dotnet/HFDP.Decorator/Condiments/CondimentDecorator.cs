using HFDP.Decorator.Beverages;

namespace HFDP.Decorator.Condiments
{
    public abstract class CondimentDecorator : Beverage
    {
        public abstract string GetDescription();
    }
}
