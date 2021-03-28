using System;

namespace HFDP.Facade.Items
{
    public class Projector
    {
        private string _name;

        public Projector(string name)
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

        public void TvMode()
        {
            Console.WriteLine($"{_name} TV mode set");
        }

        public void WideScreenMode()
        {
            Console.WriteLine($"{_name} wide screen mode set");
        }

        public override string ToString()
        {
            return _name;
        }
    }
}
