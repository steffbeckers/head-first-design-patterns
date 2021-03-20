namespace HFDP.Decorator.Beverages
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            SetDescription("Dark Roast Coffee");
        }

        public override double Cost()
        {
            return 0.99;
        }
    }
}
