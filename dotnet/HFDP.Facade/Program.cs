using HFDP.Facade.Items;
using System;

namespace HFDP.Facade
{
    // The Facade Pattern provides a unified interface to a
    // set of interfaces in a subsystem. Facade defines a higher
    // level interface that makes the subsystem easier to use.

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Home Sweet Home Theater");
            Console.WriteLine("-----------------------");

            Console.WriteLine();

            Amplifier amplifier = new Amplifier("Top-O-Line Amplifier");
            CdPlayer cdPlayer = new CdPlayer("Top-O-Line CD Player");
            DvdPlayer dvdPlayer = new DvdPlayer("Top-O-Line DVD Player");
            PopcornPopper popcornPopper = new PopcornPopper("Popcorn Popper");
            Projector projector = new Projector("Top-O-Line Projector");
            Screen screen = new Screen("Theater Screen");
            TheaterLights theaterLights = new TheaterLights("Theater Ceiling Lights");
            Tuner tuner = new Tuner("Top-O-Line Tuner");

            HomeTheaterFacade homeTheater = new HomeTheaterFacade(
                amplifier,
                tuner,
                dvdPlayer,
                cdPlayer,
                projector,
                screen,
                theaterLights,
                popcornPopper
            );

            homeTheater.WatchMovie("Raiders of the Lost Ark");
            homeTheater.EndMovie();
        }
    }
}
