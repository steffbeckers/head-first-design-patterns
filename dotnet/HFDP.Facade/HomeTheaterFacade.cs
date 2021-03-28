using HFDP.Facade.Items;
using System;

namespace HFDP.Facade
{
    public class HomeTheaterFacade
    {
        private readonly Amplifier _amp;
        private readonly Tuner _tuner;
        private readonly DvdPlayer _dvd;
        private readonly CdPlayer _cd;
        private readonly Projector _projector;
        private readonly Screen _screen;
        private readonly TheaterLights _lights;
        private readonly PopcornPopper _popper;

        public HomeTheaterFacade(
            Amplifier amp,
            Tuner tuner,
            DvdPlayer dvd,
            CdPlayer cd,
            Projector projector,
            Screen screen,
            TheaterLights lights,
            PopcornPopper popper
        )
        {
            _amp = amp;
            _tuner = tuner;
            _dvd = dvd;
            _cd = cd;
            _projector = projector;
            _screen = screen;
            _lights = lights;
            _popper = popper;
        }

        public void WatchMovie(string movie)
        {
            Console.WriteLine("Get ready to watch a movie...");

            _popper.On();
            _popper.Pop();
            _lights.Dim(10);
            _screen.Down();
            _projector.On();
            _projector.WideScreenMode();
            _amp.On();
            _amp.SetDvd(_dvd);
            _amp.SetSurroundSound();
            _amp.SetVolume(5);
            _dvd.On();
            _dvd.Play(movie);
        }

        public void EndMovie()
        {
            Console.WriteLine("Shutting movie theater down...");

            _popper.Off();
            _lights.On();
            _screen.Up();
            _projector.Off();
            _amp.Off();
            _dvd.Stop();
            _dvd.Eject();
            _dvd.Off();
        }

        public void ListenToCd()
        {
        }

        public void EndCd()
        {
        }

        public void ListenToRadio()
        {
        }

        public void EndRadio()
        {
        }
    }
}
