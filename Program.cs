namespace CommandPatternRemoteControl
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Light light = new Light();
            GarageDoor garageDoor= new GarageDoor();

            RemoteControl remoteControlLight = new RemoteControl(new LightOnCommand(light));
            remoteControlLight.PressButton();
            remoteControlLight.PressUndoButton();

            RemoteControl remoteControlGarage = new RemoteControl(new GarageDoorUpCommand(garageDoor));
            remoteControlGarage.PressButton();
            remoteControlGarage.PressUndoButton();

            CeilingFan ceilingFan= new CeilingFan();
            RemoteControl remoteControlCeiling = new RemoteControl(new CeilingFanMediumSpeed(ceilingFan)); 
            remoteControlCeiling.PressButton();
            remoteControlCeiling.PressUndoButton();
        }
    }

}