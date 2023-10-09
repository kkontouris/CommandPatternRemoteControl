namespace CommandPatternRemoteControl
{
    //concrete command-command
    class Command : ICommand
    {
        private CeilingFan ceilingFan;
        private int newSpeed;
        private int prevSpeed;

        public Command(CeilingFan ceilingFan, int newSpeed)
        {
            this.ceilingFan = ceilingFan;
            this.newSpeed = newSpeed;
        }

        public void Execute()
        {
            prevSpeed= ceilingFan.GetSpeed();
            ceilingFan.SetSpeed(newSpeed);
        }

        public void UnExecute()
        {
            ceilingFan.SetSpeed(prevSpeed);
        }
    }

}