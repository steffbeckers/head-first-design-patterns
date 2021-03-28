using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFDP.Facade.Items
{
    public class Amplifier
    {
        private string _name;
        private Tuner _tuner;
        private DvdPlayer _dvdPlayer;
        private CdPlayer _cdPlayer;

        public Amplifier(string name)
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

        public void SetCd(CdPlayer cdPlayer)
        {
            _cdPlayer = cdPlayer;
            Console.WriteLine($"{_name} setting CD player to {_cdPlayer}");
        }

        public void SetDvd(DvdPlayer dvdPlayer)
        {
            _dvdPlayer = dvdPlayer;
            Console.WriteLine($"{_name} setting DVD player to {_dvdPlayer}");
        }

        public void SetStereoSound()
        {
            Console.WriteLine($"{_name} stereo sound on (2 speakers)");
        }

        public void SetSurroundSound()
        {
            Console.WriteLine($"{_name} surround sound on (5 speakers, 1 subwoofer)");
        }

        public void SetTuner(Tuner tuner)
        {
            _tuner = tuner;
        }

        public void SetVolume(int volume)
        {
            Console.WriteLine($"{_name} setting volume to {volume}");
        }

        public override string ToString()
        {
            return _name;
        }
    }
}
