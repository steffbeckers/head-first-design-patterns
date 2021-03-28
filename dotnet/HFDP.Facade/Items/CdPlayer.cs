using System;

namespace HFDP.Facade.Items
{
    public class CdPlayer
    {
        private string _name;

        public CdPlayer(string name)
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

        public void Eject()
        {
            Console.WriteLine($"{_name} ejected CD");
        }

        public void Pause()
        {
            Console.WriteLine($"{_name} paused CD");
        }

        public void Play()
        {
            Console.WriteLine($"{_name} plays CD");
        }

        public void Stop()
        {
            Console.WriteLine($"{_name} stopped playing CD");
        }

        public override string ToString()
        {
            return _name;
        }
    }
}