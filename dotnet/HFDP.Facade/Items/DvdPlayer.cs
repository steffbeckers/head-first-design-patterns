using System;

namespace HFDP.Facade.Items
{
    public class DvdPlayer
    {
        private string _name;

        public DvdPlayer(string name)
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
            Console.WriteLine($"{_name} ejected DVD");
        }

        public void Pause()
        {
            Console.WriteLine($"{_name} paused DVD");
        }

        public void Play(string title)
        {
            Console.WriteLine($"{_name} plays DVD: {title}");
        }

        public void SetSurroundAudio()
        {
            Console.WriteLine($"{_name} surround sound set");
        }

        public void SetTwoChannelAudio()
        {
            Console.WriteLine($"{_name} stereo sound set");
        }

        public void Stop()
        {
            Console.WriteLine($"{_name} stopped playing DVD");
        }

        public override string ToString()
        {
            return _name;
        }
    }
}