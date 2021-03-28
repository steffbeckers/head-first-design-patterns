using System;

namespace HFDP.Facade.Items
{
    public class PopcornPopper
    {
        private string _name;

        public PopcornPopper(string name)
        {
            _name = name;
        }

        public void On()
        {
            Console.WriteLine($"{_name} on");
        }

        public void Off()
        {
            Console.WriteLine($"{_name} off");
        }

        public void Pop()
        {
            Console.WriteLine($"{_name} popping popcorn!");
        }

        public override string ToString()
        {
            return _name;
        }
    }
}
