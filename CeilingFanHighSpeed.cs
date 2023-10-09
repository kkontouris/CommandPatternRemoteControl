namespace CommandPatternRemoteControl
{
    //concrete command ceiling fan high speed 
    class CeilingFanHighSpeed : Command
    {
        public CeilingFanHighSpeed(CeilingFan ceilingFan) : base(ceilingFan, 3)
        {
        }
    }

}