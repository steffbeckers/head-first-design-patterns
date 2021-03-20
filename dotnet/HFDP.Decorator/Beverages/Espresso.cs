namespace HFDP.Decorator.Beverages
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            SetDescription("Espresso");
        }

        public override double Cost()
        {
            return 1.99;
        }
    }
}
