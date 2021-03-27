using HFDP.Command.Commands;
using HFDP.Command.Invokers;
using HFDP.Command.Receivers;
using System;

namespace HFDP.Command
{
    // The Command Pattern encapsulates a request as an
    // object, thereby letting you parameterize other objects
    // with different requests, queue or log requests, and
    // support undoable operations.

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Remote Controls");
            Console.WriteLine("---------------");

            Console.WriteLine();

            // Simple remote control

            Console.WriteLine("--- Simple Remote Control ---");

            Console.WriteLine();

            SimpleRemoteControl simpleRemoteControl = new SimpleRemoteControl();

            Light light = new Light();
            LightOnCommand lightOnCommand = new LightOnCommand(light);

            GarageDoor garageDoor = new GarageDoor();
            GarageDoorOpenCommand garageDoorOpenCommand = new GarageDoorOpenCommand(garageDoor);

            simpleRemoteControl.SetCommand(lightOnCommand);
            simpleRemoteControl.ButtonWasPressed();

            simpleRemoteControl.SetCommand(garageDoorOpenCommand);
            simpleRemoteControl.ButtonWasPressed();

            // Advanced remote control

            RemoteControl remoteControl = new RemoteControl();

            Light livingRoomLight = new Light("Living Room");
            Light kitchenLight = new Light("Kitchen");
            Stereo livingRoomStereo = new Stereo("Living Room");

            LightOnCommand livingRoomLightOnCommand = new LightOnCommand(livingRoomLight);
            LightOffCommand livingRoomLightOffCommand = new LightOffCommand(livingRoomLight);
            LightOnCommand kitchenLightOnCommand = new LightOnCommand(kitchenLight);
            LightOffCommand kitchenLightOffCommand = new LightOffCommand(kitchenLight);

            GarageDoorCloseCommand garageDoorCloseCommand = new GarageDoorCloseCommand(garageDoor);

            StereoOnWithCDCommand livingRoomStereoOnWithCDCommand = new StereoOnWithCDCommand(livingRoomStereo);
            StereoOffCommand livingRoomStereoOffCommand = new StereoOffCommand(livingRoomStereo);

            remoteControl.SetCommand(0, livingRoomLightOnCommand, livingRoomLightOffCommand);
            remoteControl.SetCommand(1, kitchenLightOnCommand, kitchenLightOffCommand);
            remoteControl.SetCommand(2, garageDoorOpenCommand, garageDoorCloseCommand);
            remoteControl.SetCommand(3, livingRoomStereoOnWithCDCommand, livingRoomStereoOffCommand);

            Console.Write(remoteControl);

            remoteControl.OnButtonWasPushed(0);
            remoteControl.OffButtonWasPushed(0);
            remoteControl.OnButtonWasPushed(1);
            remoteControl.OffButtonWasPushed(1);
            remoteControl.OnButtonWasPushed(2);
            remoteControl.OffButtonWasPushed(2);
            remoteControl.OnButtonWasPushed(3);
            remoteControl.OffButtonWasPushed(3);
            remoteControl.OnButtonWasPushed(4);
            remoteControl.OffButtonWasPushed(4);
            remoteControl.OnButtonWasPushed(5);
            remoteControl.OffButtonWasPushed(5);
            remoteControl.OnButtonWasPushed(6);
            remoteControl.OffButtonWasPushed(6);
        }
    }
}
