namespace HFDP.Iterator.Menus
{
    public class MenuItem
    {
        public readonly string Name;
        public readonly string Description;
        public readonly double Price;
        public readonly bool Vegetarian;

        public MenuItem(string name, string description, double price, bool vegetarian)
        {
            Name = name;
            Description = description;
            Price = price;
            Vegetarian = vegetarian;
        }
    }
}