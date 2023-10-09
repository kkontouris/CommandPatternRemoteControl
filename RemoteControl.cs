namespace CommandPatternRemoteControl
{
    //invoker
    class RemoteControl
    {
        ICommand command;

        public RemoteControl(ICommand command)
        {
            this.command = command;
        }

        public void PressButton()
        {
            command.Execute();
        }
        public void PressUndoButton()
        {
            command.UnExecute();
        }
    }

}