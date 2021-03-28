using System;

namespace HFDP.Facade.Items
{
    public class Tuner
    {
        private string _name;

        public Tuner(string name)
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

        public void SetAm()
        {
            Console.WriteLine($"{_name} set mode to AM");
        }

        public void SetFm()
        {
            Console.WriteLine($"{_name} set mode to FM");
        }

        public void SetFrequency(double frequency)
        {
            Console.WriteLine($"{_name} set frequency {frequency}");
        }

        public override string ToString()
        {
            return _name;
        }
    }
}