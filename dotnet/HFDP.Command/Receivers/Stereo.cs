using System;

namespace HFDP.Command.Receivers
{
    public class Stereo
    {
        private readonly string _location;

        public Stereo(string location = null)
        {
            _location = location;
        }

        public void On()
        {
            Console.WriteLine("Stereo is On");
        }

        public void Off()
        {
            Console.WriteLine("Stereo is Off");
        }

        public void SetCd()
        {
            Console.WriteLine("Stereo set to CD");
        }

        public void SetDvd()
        {
            Console.WriteLine("Stereo set to DVD");
        }

        public void SetRadio()
        {
            Console.WriteLine("Stereo set to Radio");
        }

        public void SetVolume(int volume)
        {
            Console.WriteLine($"Stereo volume set to {volume}");
        }
    }
}
