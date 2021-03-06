namespace HFDP.Decorator.Beverages
{
    public abstract class Beverage
    {
        private string _description = "Unknown Beverage";

        public virtual string GetDescription()
        {
            return _description;
        }

        public void SetDescription(string description)
        {
            _description = description;
        }

        public abstract double Cost();
    }
}
