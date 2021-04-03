using System;

namespace HFDP.Iterator.Menus
{
    public class DinerMenu : IMenu
    {
        private readonly int MAX_ITEMS = 6;
        private int _numberOfItems = 0;
        private MenuItem[] _menuItems;

        public DinerMenu()
        {
            _menuItems = new MenuItem[MAX_ITEMS];

            AddItem(
                "Vegetarian BLT",
                "(Fakin') Bacon with lettuce & tomato on whole wheat",
                2.99,
                true
            );
            AddItem(
                "BLT",
                "Bacon with lettuce & tomato on whole wheat",
                2.99,
                false
            );
            AddItem(
                "Soup of the day",
                "Soup of the day, with a side of potato salad",
                3.29,
                false
            );
            AddItem(
                "Hotdog",
                "A hot dog, with saurkraut, relish, onions, topped with cheese",
                3.05,
                false
            );
        }

        public void AddItem(string name, string description, double price, bool vegetarian)
        {
            MenuItem menuItem = new MenuItem(name, description, price, vegetarian);
            if (_numberOfItems >= MAX_ITEMS)
            {
                Console.WriteLine("Sorry, menu is full! Can't add item to menu");
            }
            else
            {
                _menuItems[_numberOfItems] = menuItem;
                _numberOfItems++;
            }
        }

        public IIterator CreateIterator()
        {
            return new DinerMenuIterator(_menuItems);
        }
    }

    public class DinerMenuIterator : IIterator
    {
        private readonly MenuItem[] _items;
        private int _position = 0;

        public DinerMenuIterator(MenuItem[] items)
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
            if (_position >= _items.Length || _items[_position] == null)
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
