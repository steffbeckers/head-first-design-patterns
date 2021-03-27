﻿using HFDP.Command.Receivers;

namespace HFDP.Command.Commands
{
    public class LightOnCommand : ICommand
    {
        private readonly Light _light;

        public LightOnCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.On();
        }
    }
}
