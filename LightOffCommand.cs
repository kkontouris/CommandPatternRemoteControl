namespace CommandPatternRemoteControl
{
    //concrete command LightOff
    class LightOffCommand : ICommand
    {
        Light light;

        public LightOffCommand(Light light)
        {
            this.light = light;
        }
        public void Execute()
        {
            light.TurnOff();
        }
        public void UnExecute()
        {
            light.TurnOn();
        }
    }

}