using System;

namespace HFDP.Facade.Items
{
    public class CdPlayer
    {
        private string _name;
        private string _nowPlaying;

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
            Console.WriteLine($"{_name} eject");
        }

        public void Pause()
        {
            Console.WriteLine($"{_name} paused CD");
        }

        public void Play(string title)
        {
            _nowPlaying = title;
            Console.WriteLine($"{_name} playing \"{_nowPlaying}\"");
        }

        public void Stop()
        {
            Console.WriteLine($"{_name} stopped \"{_nowPlaying}\"");
            _nowPlaying = null;
        }

        public override string ToString()
        {
            return _name;
        }
    }
}