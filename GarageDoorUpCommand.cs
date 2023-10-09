namespace CommandPatternRemoteControl
{
    //concrete command garagedoorUp
    class GarageDoorUpCommand :ICommand
    {
        GarageDoor garageDoor;    //receiver

        public GarageDoorUpCommand(GarageDoor garageDoor)    //dependency injection
        {
            this.garageDoor = garageDoor;
        }

        public void Execute()
        {
            garageDoor.GarageDoorUp();
        }

        public void UnExecute()
        {
            garageDoor.GarageDoorDown();
        }
    }

}