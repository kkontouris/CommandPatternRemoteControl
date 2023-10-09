namespace CommandPatternRemoteControl
{
    //concrete command ceiling fan medium speed
    class CeilingFanMediumSpeed : Command
    {
        public CeilingFanMediumSpeed(CeilingFan ceilingFan) : base(ceilingFan, 2)
        {
        }
    }

}