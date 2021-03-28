using System;

namespace HFDP.Facade.Items
{
    public class Screen
    {
        private string _name;

        public Screen(string name)
        {
            _name = name;
        }

        public void Up()
        {
            Console.WriteLine($"{_name} going up");
        }

        public void Down()
        {
            Console.WriteLine($"{_name} going down");
        }

        public override string ToString()
        {
            return _name;
        }
    }
}