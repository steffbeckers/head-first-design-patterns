using System;

namespace HFDP.Facade.Items
{
    public class TheaterLights
    {
        private string _name;

        public TheaterLights(string name)
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

        public void Dim(int percentage)
        {
            Console.WriteLine($"{_name} dimming to {percentage}%");
        }

        public override string ToString()
        {
            return _name;
        }
    }
}
