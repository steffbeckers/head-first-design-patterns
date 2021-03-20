namespace HFDP.Decorator.Beverages
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            SetDescription("House Blend Coffee");
        }

        public override double Cost()
        {
            return 0.89;
        }
    }
}
