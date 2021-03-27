using System;

namespace HFDP.Command.Receivers
{
    public class GarageDoor
    {
        public void Up()
        {
            Console.WriteLine("Garage Door is Open");
        }

        public void Down()
        {
            Console.WriteLine("Garage Door is Closed");
        }

        public void Stop()
        {
            Console.WriteLine("Garage Door stopped moving");
        }

        public void LightOn()
        {
            Console.WriteLine("Garage Door light is On");
        }

        public void LightOff()
        {
            Console.WriteLine("Garage Door light is Off");
        }
    }
}
