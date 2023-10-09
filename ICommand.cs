namespace CommandPatternRemoteControl
{
    //Command Interface
    interface ICommand
    {
        void Execute();
        void UnExecute();
    }

}