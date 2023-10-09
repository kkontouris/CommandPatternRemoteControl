namespace CommandPatternRemoteControl
{
    //concrete command LightOn
    class LightOnCommand:ICommand
    {
        Light light;

        public LightOnCommand(Light light)
        {
            this.light = light;
        }
        public void Execute()
        {
        light.TurnOn();
        }
        public void UnExecute()
        {
            light.TurnOff();
        }
    }

}