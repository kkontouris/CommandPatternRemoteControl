namespace CommandPatternRemoteControl
{
    //concrete command ceiling fan low speed
    class CeilingFanLowSpeed : Command
    {
        public CeilingFanLowSpeed(CeilingFan ceilingFan) : base(ceilingFan, 1)
        {
        }
    }

}