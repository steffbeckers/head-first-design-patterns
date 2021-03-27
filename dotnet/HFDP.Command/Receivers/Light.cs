using System;

namespace HFDP.Command.Receivers
{
    public class Light
    {
        private readonly string _location;

        public Light(string location = null)
        {
            _location = location;
        }

        public void On()
        {
            Console.WriteLine(!string.IsNullOrEmpty(_location) ? $"{_location} light is On" : "Light is On");
        }

        public void Off()
        {
            Console.WriteLine(!string.IsNullOrEmpty(_location) ? $"{_location} light is Off" : "Light is Off");
        }
    }
}
