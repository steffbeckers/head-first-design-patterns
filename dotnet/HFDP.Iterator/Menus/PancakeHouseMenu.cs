using System.Collections.Generic;

namespace HFDP.Iterator.Menus
{
    public class PancakeHouseMenu : IMenu
    {
        private readonly List<MenuItem> _menuItems;

        public PancakeHouseMenu()
        {
            _menuItems = new List<MenuItem>();

            AddItem(
                "K&B's Pancake Breakfast",
                "Pancakes with scrambled eggs, and toast",
                2.99,
                true
            );
            AddItem(
                "Regular Pancake Breakfast",
                "Pancakes with fried eggs, sausage",
                2.99,
                false
            );
            AddItem(
                "Blueberry Pancakes",
                "Pancakes made with fresh blueberries",
                3.49,
                true
            );
            AddItem(
                "Waffles",
                "Waffles, with your choice of blueberries or strawberries",
                3.59,
                true
            );
        }

        public void AddItem(string name, string description, double price, bool vegetarian)
        {
            MenuItem menuItem = new MenuItem(name, description, price, vegetarian);
            _menuItems.Add(menuItem);
        }

        public IIterator CreateIterator()
        {
            return new PancakeHouseMenuIterator(_menuItems);
        }
    }

    public class PancakeHouseMenuIterator : IIterator
    {
        private readonly List<MenuItem> _items;
        private int _position = 0;

        public PancakeHouseMenuIterator(List<MenuItem> items)
        {
            _items = items;
        }

        public object Next()
        {
            MenuItem menuItem = _items[_position];
            _position++;

            return menuItem;
        }

        public bool HasNext()
        {
            if (_position >= _items.Count || _items[_position] == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
