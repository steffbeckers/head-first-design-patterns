using System;

namespace HFDP.Singleton
{
    public class ChocolateBoiler
    {
        private bool _empty;
        private bool _boiled;

        private static ChocolateBoiler _uniqueInstance;

        private ChocolateBoiler()
        {
            _empty = true;
            _boiled = false;
        }

        public static ChocolateBoiler GetInstance()
        {
            if (_uniqueInstance == null)
            {
                _uniqueInstance = new ChocolateBoiler();
            }

            return _uniqueInstance;
        }

        public void Fill()
        {
            if (IsEmpty())
            {
                _empty = false;
                _boiled = false;
                Console.WriteLine("Filling the boiler with a milk/chocolate mixture.");
            }
        }

        public void Drain()
        {
            if (!IsEmpty() && IsBoiled())
            {
                Console.WriteLine("Draining the boiled chocolate milk");
                _empty = true;
            }
        }

        public void Boil()
        {
            if (!IsEmpty() && !IsBoiled())
            {
                Console.WriteLine("Bring the contents to a boil");
                _boiled = true;
            }
        }

        public bool IsEmpty()
        {
            return _empty;
        }

        public bool IsBoiled()
        {
            return _boiled;
        }
    }
}
